using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projekt.MS3.LibraryService;
using System.Text;

namespace Projekt.MS3
{
    public partial class Add : System.Web.UI.Page
    {
        string id;

        /// <summary>
        /// Sprawdzanie czy uzytkownik jest zalogowany (jeśli nie zostaje przekierowany na stronę logowania. Jeśli w adresie podaliśmy 
        /// parametr "editID" z prawidłowym (znajdującym się w bazie) ID książki do aopowiednich kontrolek zostają wczytane wszystkie dane na jej temat.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Biblioteka - Dodaj książkę";

            if (Session["LOGIN"] == null)
                Response.Redirect("~/Login.aspx");

            id = Request.QueryString["editID"];

            if (!Page.IsPostBack)
            {
                if (id != null)
                {
                    if (loadData(id))
                    {
                        btnZapisz.Visible = false;
                        btnUpdate.Visible = true;

                        Page.Title = "Biblioteka - Edytuj książkę";
                    }
                    else
                    {
                        Response.Redirect("~/Default.aspx");
                    }
                }
            }
        }

        /// <summary>
        /// Po kliknieciu w guzik sprawdzamy czy strona nie zawiera błędów (walidatory). Jeśli wybraliśmy jakiś plik pobieramy go na serwer
        /// i dodajemy nową książkę w tabeli SQL. 3 pierwsze pola są wymagane
        /// </summary>
        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Book book = new Book();

                book.okladka = null;
                if (FileUpload1.HasFile)
                {
                    if (!(String.IsNullOrWhiteSpace(FileUpload1.FileName)))
                    {
                        byte[] image = FileUpload1.FileBytes;
                        book.okladka = Encoding.Default.GetString(image, 0, image.Length);
                    }
                }

                book.tytul = txtTytul.Text.ToString();
                book.opis = txtOpis.Text.ToString();
                book.autorzy = txtAutorzy.Text.ToString();
                if (txtWydawnictwo.Text.Length > 0)
                    book.wydawnictwo = txtWydawnictwo.Text;
                else
                    book.wydawnictwo = null;

                book.oprawa = ddOprawa.SelectedItem.Text;

                if (txtWymiaryX.Text.Length > 0 && txtWymiaryY.Text.Length > 0)
                    book.wymiary = string.Format("{0}x{1}", txtWymiaryX.Text, txtWymiaryY.Text);
                else
                    book.wymiary = null;
                if (txtIloscStron.Text.Length > 0)
                    book.iloscStron = Int32.Parse(txtIloscStron.Text.ToString());
                else
                    book.iloscStron = 0;
                if (txtISBN.Text.Length > 0)
                    book.isbn = txtISBN.Text;
                else
                    book.isbn = null;

                LibraryServiceClient lib = new LibraryServiceClient();
                Boolean result = lib.addBook(book);
                if (result)
                {
                    txtTytul.Text = String.Empty;
                    txtOpis.Text = String.Empty;
                    txtAutorzy.Text = String.Empty;
                    txtWydawnictwo.Text = String.Empty;
                    txtWymiaryY.Text = String.Empty;
                    txtWymiaryX.Text = String.Empty;
                    txtIloscStron.Text = String.Empty;
                    txtISBN.Text = String.Empty;
                    string script = "alert(\"Dodano pomyślnie.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                }
                else
                {
                    string script = "alert(\"Wystąpił błąd podczas dodawania. Spróbuj ponownie.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
        }

        /// <summary>
        /// Walidator dla kontrolki FileUpload. Sprawdza format pliku.
        /// </summary>
        protected void FileUploadCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string fileName = args.Value;
            string fileExt = Path.GetExtension(fileName).ToLower();

            if (fileExt.Equals(".jpg"))
                args.IsValid = true;
            else
                args.IsValid = false;

        }

        /// <summary>
        /// Walidator dla kontrolek wymiarów książki.
        /// </summary>
        protected void WymiaryCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int number = 0;
            Int32.TryParse(args.Value, out number);

            if (number > 0 && number < 1000)
                args.IsValid = true;
            else
                args.IsValid = false;
        }

        /// <summary>
        /// Walidator dla kontrolki przyjmującej ilośc stron danej książki.
        /// </summary>
        protected void IloscStronCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int number = 0;
            Int32.TryParse(args.Value, out number);

            if (number > 0 && number < 100000)
                args.IsValid = true;
            else
                args.IsValid = false;
        }

        /// <summary>
        /// Walidator dla kontrolek: Tytuł, Opis, Autorzy i Wydawnictwo.
        /// </summary>
        protected void TytulCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length < 3)
                args.IsValid = false;
            else
                args.IsValid = true;
        }

        /// <summary>
        /// Metoda ładująca dane książki do odpowiednich kontrolek.
        /// </summary>
        /// <param name="id">ID książki</param>
        /// <returns>True jeśli odczytwaliśmy dane z bazy, false przy braku danych.</returns>
        private bool loadData(string id)
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            Book book = lib.getBookInfo(Int32.Parse(id));
            if (book != null)
            {
                String url = lib.Endpoint.Address.Uri.ToString();
                String serviceName = "LibraryService.svc";
                url = url.Remove(url.Length - serviceName.Length, serviceName.Length);
                url = url + "covers/";
                txtTytul.Text = book.tytul;
                txtOpis.Text = book.opis;
                txtAutorzy.Text = book.autorzy;
                txtWydawnictwo.Text = book.wydawnictwo;
                string oprawa = book.oprawa;
                if (oprawa.Equals("miękka"))
                    ddOprawa.SelectedIndex = 0;
                else if (oprawa.Equals("twarda"))
                    ddOprawa.SelectedIndex = 1;
                string[] dimentions = readDimentions(book.wymiary);
                txtWymiaryX.Text = dimentions[0];
                txtWymiaryY.Text = dimentions[1];
                if (book.iloscStron == 0) txtIloscStron.Text = "";
                else txtIloscStron.Text = book.iloscStron.ToString();
                txtISBN.Text = book.isbn;
                string fileName = book.okladka;
                if (!String.IsNullOrWhiteSpace(fileName))
                    imgOkldka.ImageUrl = string.Format(url + fileName);
                else
                    imgOkldka.ImageUrl = string.Format(url + "brak-okladki.jpg");
                return true;
            }
            else
            {
                return false;
            }

        }
  

        /// <summary>
        /// Metoda rozdzielająca wartości wymiarów książki zapisanych w formacie 123x123.
        /// </summary>
        private string[] readDimentions(string dimentions)
        {
            string[] d = dimentions.Split('x');

            if(d.Length < 2)
            {
                return new string[2];
            }
            
            return d;
        }

        /// <summary>
        /// Po kliknieciu w guzik sprawdzamy czy strona nie zawiera błędów (walidatory). Jeśli wybraliśmy jakiś plik pobieramy go na serwer
        /// i aktualizujemy dane w tabeli SQL.
        /// </summary>
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                Book book = new Book();
                book.Id = Int32.Parse(id);
                String imgurl = imgOkldka.ImageUrl.ToString();
                book.okladka = imgurl.Substring(imgurl.LastIndexOf('/') + 1);
                if (FileUpload1.HasFile)
                {
                    if (!(String.IsNullOrWhiteSpace(FileUpload1.FileName)))
                    {
                        byte[] image = FileUpload1.FileBytes;
                        book.okladka = Encoding.Default.GetString(image, 0, image.Length);
                    }
                }

                book.tytul = txtTytul.Text.ToString();
                book.opis = txtOpis.Text.ToString();
                book.autorzy = txtAutorzy.Text.ToString();
                if (txtWydawnictwo.Text.Length > 0)
                    book.wydawnictwo = txtWydawnictwo.Text;
                else
                    book.wydawnictwo = null;

                book.oprawa = ddOprawa.SelectedItem.Text;

                if (txtWymiaryX.Text.Length > 0 && txtWymiaryY.Text.Length > 0)
                    book.wymiary = string.Format("{0}x{1}", txtWymiaryX.Text, txtWymiaryY.Text);
                else
                    book.wymiary = null;
                if (txtIloscStron.Text.Length > 0)
                    book.iloscStron = Int32.Parse(txtIloscStron.Text.ToString());
                else
                    book.iloscStron = 0;
                if (txtISBN.Text.Length > 0)
                    book.isbn = txtISBN.Text;
                else
                    book.isbn = null;

                LibraryServiceClient lib = new LibraryServiceClient();
                Boolean result = lib.updateBook(book);
                if (result) Response.Redirect("~/Show.aspx?id=" + id);

            }
        }
    }
}