using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Hosting;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Projekt.MS3.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LibraryService : ILibraryService
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);

        public List<BookForListShort> getBooksListShort()
        {
            List<BookForListShort> booksList = new List<BookForListShort>();
            SqlCommand cmd = new SqlCommand(string.Format("select ID_KSIAZKA, K_TYTUL from Ksiazki"), connection);
            connection.Open(); //otworzenie polaczenia
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read()) // czytamy wiersze danych do momentu ich skonczenia
                {
                    BookForListShort b = new BookForListShort();
                    b.Id = Int32.Parse(rdr["ID_KSIAZKA"].ToString());
                    b.tytul = rdr["K_TYTUL"].ToString();
                    booksList.Add(b);
                }
            }

            if (rdr != null)
                rdr.Close();

            if (connection != null)
                connection.Close();

            return booksList;
        }

        public List<BookForListLong> getBooksListLong()
        {
            List<BookForListLong> booksList = new List<BookForListLong>();
            SqlCommand cmd = new SqlCommand(string.Format("select ID_KSIAZKA, K_TYTUL, K_OPIS, K_OKLADKA  from Ksiazki"), connection);
            connection.Open(); //otworzenie polaczenia
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read()) // czytamy wiersze danych do momentu ich skonczenia
                {
                    BookForListLong b = new BookForListLong();
                    b.Id = Int32.Parse(rdr["ID_KSIAZKA"].ToString());
                    b.tytul = rdr["K_TYTUL"].ToString();
                    String opis = rdr["K_OPIS"].ToString();
                    if (opis.Length > 700) b.opis = opis.Substring(0, 700) + "...";
                    else b.opis = opis;
                    b.okladka = Convert.ToString(rdr["K_OKLADKA"]);
                    booksList.Add(b);
                }
            }

            if (rdr != null)
                rdr.Close();

            if (connection != null)
                connection.Close();

            return booksList;
        }

        public Book getBookInfo(int id)
        {
            Book b = new Book();
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand(string.Format("select * from Ksiazki where ID_KSIAZKA = {0}", id), connection);
                connection.Open(); //otworzenie polaczenia
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read()) // czytamy wiersze danych do momentu ich skonczenia
                    {
                        b.Id = id;
                        b.tytul = rdr["K_TYTUL"].ToString();
                        b.opis = rdr["K_OPIS"].ToString();
                        b.autorzy = rdr["K_AUTORZY"].ToString();
                        b.wydawnictwo = rdr["K_WYDAWNICTWO"].ToString();
                        b.oprawa = rdr["K_OPRAWA"].ToString();
                        b.wymiary = rdr["K_WYMIARY"].ToString();
                        String x = rdr["K_ILOSC_STRON"].ToString();
                        if (String.IsNullOrWhiteSpace(x)) b.iloscStron = 0;
                        else b.iloscStron = Int32.Parse(rdr["K_ILOSC_STRON"].ToString());
                        b.isbn = rdr["K_ISBN"].ToString();
                        b.okladka = Convert.ToString(rdr["K_OKLADKA"]);

                    }
                }

                if (rdr != null)
                    rdr.Close();

                if (connection != null)
                    connection.Close();
            }
            return b;
        }

        private String getBookCover(int id)
        {
            String returnString = null;
            try
            {
                if (id > 0)
                {
                    SqlCommand cmd = new SqlCommand(string.Format("select K_OKLADKA from Ksiazki where ID_KSIAZKA = {0}", id), connection);
                    connection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        returnString = rdr.GetString(0);
                    }
                }
            }
            catch (Exception) { }

            if (connection != null)
                connection.Close();

            return returnString;
        }

        public Boolean deleteBook(int id)
        {
            try
            {
                deleteCoverFile(id);

                using (connection)
                {
                    SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM Ksiazki WHERE ID_KSIAZKA = {0}", id));
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void deleteCoverFile(int id)
        {
                string imagesPath = HostingEnvironment.MapPath("~/covers/");
                string cover = getBookCover(id);
                if (!String.IsNullOrWhiteSpace(cover))
                {
                    string file = imagesPath + getBookCover(id);
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                }
        }

        public Boolean addBook(Book book)
        {
            try
            {
                using (connection)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Ksiazki (K_TYTUL, K_OPIS, K_AUTORZY, K_WYDAWNICTWO, K_OPRAWA, K_WYMIARY, K_ILOSC_STRON, K_ISBN, K_OKLADKA) VALUES (@K_TYTUL, @K_OPIS, @K_AUTORZY, @K_WYDAWNICTWO, @K_OPRAWA, @K_WYMIARY, @K_ILOSC_STRON, @K_ISBN, @K_OKLADKA)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@K_TYTUL", book.tytul);
                    cmd.Parameters.AddWithValue("@K_OPIS", book.opis);
                    cmd.Parameters.AddWithValue("@K_AUTORZY", book.autorzy);
                    if (book.wydawnictwo != null) cmd.Parameters.AddWithValue("@K_WYDAWNICTWO", book.wydawnictwo);
                    else cmd.Parameters.AddWithValue("@K_WYDAWNICTWO", DBNull.Value);
                    cmd.Parameters.AddWithValue("@K_OPRAWA", book.oprawa);
                    if (book.wymiary != null) cmd.Parameters.AddWithValue("@K_WYMIARY", book.wymiary);
                    else cmd.Parameters.AddWithValue("@K_WYMIARY", DBNull.Value);
                    if(book.iloscStron > 0) cmd.Parameters.AddWithValue("@K_ILOSC_STRON", book.iloscStron);
                    else cmd.Parameters.AddWithValue("@K_ILOSC_STRON", DBNull.Value);
                    if (book.isbn != null) cmd.Parameters.AddWithValue("@K_ISBN", book.isbn);
                    else cmd.Parameters.AddWithValue("@K_ISBN", DBNull.Value);
                    string file = null;
                    if (book.okladka != null)
                    {
                        try
                        {
                            string imagesPath = HostingEnvironment.MapPath("~/covers/");
                            Regex pattern = new Regex("[/:*?<>|\"\\ ]");
                            string fileName = pattern.Replace(book.tytul, String.Empty);
                            if (File.Exists(imagesPath + fileName + ".jpg"))
                                fileName = fileName + "_" + DateTime.Now.Ticks.ToString() + ".jpg";
                            byte[] image = Encoding.Default.GetBytes(book.okladka);
                            MemoryStream ms = new MemoryStream(image);
                            Image i = Image.FromStream(ms);
                            i.Save(imagesPath + fileName + ".jpg", ImageFormat.Jpeg);
                            file = fileName + ".jpg";
                        }
                        catch (Exception) { }
                    }
                    if (file != null)  cmd.Parameters.AddWithValue("@K_OKLADKA", file);
                    else cmd.Parameters.AddWithValue("@K_OKLADKA", DBNull.Value);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception) { return false; }
        }

        public Boolean updateBook(Book book)
        {
            try
            {
                if (book.okladka != getBookCover(book.Id))
                {
                    deleteCoverFile(book.Id);
                }
                using (connection)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Ksiazki SET K_TYTUL = @K_TYTUL, K_OPIS = @K_OPIS, K_AUTORZY = @K_AUTORZY, K_WYDAWNICTWO = @K_WYDAWNICTWO, K_OPRAWA = @K_OPRAWA, K_WYMIARY = @K_WYMIARY, K_ILOSC_STRON = @K_ILOSC_STRON, K_ISBN = @K_ISBN, K_OKLADKA = @K_OKLADKA WHERE ID_KSIAZKA = " + book.Id, connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@K_TYTUL", book.tytul);
                    cmd.Parameters.AddWithValue("@K_OPIS", book.opis);
                    cmd.Parameters.AddWithValue("@K_AUTORZY", book.autorzy);
                    if (book.wydawnictwo != null) cmd.Parameters.AddWithValue("@K_WYDAWNICTWO", book.wydawnictwo);
                    else cmd.Parameters.AddWithValue("@K_WYDAWNICTWO", DBNull.Value);
                    cmd.Parameters.AddWithValue("@K_OPRAWA", book.oprawa);
                    if (book.wymiary != null) cmd.Parameters.AddWithValue("@K_WYMIARY", book.wymiary);
                    else cmd.Parameters.AddWithValue("@K_WYMIARY", DBNull.Value);
                    if (book.iloscStron > 0) cmd.Parameters.AddWithValue("@K_ILOSC_STRON", book.iloscStron);
                    else cmd.Parameters.AddWithValue("@K_ILOSC_STRON", DBNull.Value);
                    if (book.isbn != null) cmd.Parameters.AddWithValue("@K_ISBN", book.isbn);
                    else cmd.Parameters.AddWithValue("@K_ISBN", DBNull.Value);
                    string file = null;
                    if (book.okladka != null)
                    {
                        try
                        {
                            string imagesPath = HostingEnvironment.MapPath("~/covers/");
                            Regex pattern = new Regex("[/:*?<>|\"\\ ]");
                            string fileName = pattern.Replace(book.tytul, String.Empty);
                            if (File.Exists(imagesPath + fileName + ".jpg"))
                                fileName = fileName + "_" + DateTime.Now.Ticks.ToString() + ".jpg";
                            byte[] image = Encoding.Default.GetBytes(book.okladka);
                            MemoryStream ms = new MemoryStream(image);
                            Image i = Image.FromStream(ms);
                            i.Save(imagesPath + fileName + ".jpg", ImageFormat.Jpeg);
                            file = fileName + ".jpg";
                        }
                        catch (Exception) { }
                    }
                    if (file != null) cmd.Parameters.AddWithValue("@K_OKLADKA", file);
                    else cmd.Parameters.AddWithValue("@K_OKLADKA", book.okladka);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception) { return false; }
        }

        public Boolean checkCredentials(String login, String password)
        {
            Boolean returnValue;
            SqlCommand cmd = new SqlCommand(String.Format("select ID_UZYTKOWNIK from Uzytkownicy where U_LOGIN = '{0}' and U_HASLO = '{1}'", login, password), connection);
            connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                returnValue = true;
            }
            else returnValue = false;

            if (rdr != null)
                rdr.Close();

            if (connection != null)
                connection.Close();

            return returnValue;
        }

        public List<BookForListShort> searchBooksSimple(String text)
        {
            List<BookForListShort> booksList = new List<BookForListShort>();
            SqlCommand cmd = new SqlCommand(string.Format("select ID_KSIAZKA, K_TYTUL from Ksiazki where K_TYTUL like '%{0}%'", text), connection);
            connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read()) // czytamy wiersze danych do momentu ich skonczenia
                {
                    BookForListShort b = new BookForListShort();
                    b.Id = Int32.Parse(rdr["ID_KSIAZKA"].ToString());
                    b.tytul = rdr["K_TYTUL"].ToString();
                    booksList.Add(b);
                }
            }

            if (rdr != null)
                rdr.Close();

            if (connection != null)
                connection.Close();

            return booksList;
        }

        public List<BookForListShort> searchBooksAdvanced(String query, Boolean titleDesc, String authors, String publisher, int binding, int pages, int pagesSearchType, String isbn)
        {
            List<BookForListShort> booksList = new List<BookForListShort>();
            string commandBegin = "select ID_KSIAZKA, K_TYTUL from Ksiazki";
            string command = string.Format("{0} where (K_TYTUL like '%{1}%'", commandBegin, query);

            if (titleDesc)
                command += string.Format("or K_OPIS like '%{0}%')", query);
            else
                command += ")";

            if (!String.IsNullOrWhiteSpace(authors)) command += string.Format("and K_AUTORZY like '%{0}%'", authors);
            if (!String.IsNullOrWhiteSpace(publisher)) command += string.Format("and K_WYDAWNICTWO like '%{0}%'", publisher);
            if (binding != 0)
            {
                if (binding == 1) command += "and K_OPRAWA like 'miękka'";
                else if (binding == 2) command += "and K_OPRAWA like 'twarda'";
            }
            if (pages != -1)
            {
                if (pagesSearchType == 0) command += string.Format("and K_ILOSC_STRON < {0}", pages);
                else if (pagesSearchType == 1) command += string.Format("and K_ILOSC_STRON = {0}", pages);
                else if (pagesSearchType == 2) command += string.Format("and K_ILOSC_STRON > {0}", pages);
            }
            if (!String.IsNullOrWhiteSpace(isbn))
            {
                command = string.Format("{0} where K_ISBN like '{1}'", commandBegin, isbn);
                isbn = isbn.Replace("-", "");
                command += string.Format("or K_ISBN like '{0}'", isbn);
            }

            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read()) // czytamy wiersze danych do momentu ich skonczenia
                {
                    BookForListShort b = new BookForListShort();
                    b.Id = Int32.Parse(rdr["ID_KSIAZKA"].ToString());
                    b.tytul = rdr["K_TYTUL"].ToString();
                    booksList.Add(b);
                }
            }

            if (rdr != null)
                rdr.Close();

            if (connection != null)
                connection.Close();

            return booksList;
        }
    }
}
