using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projekt.MS3.LibraryService;

namespace Projekt.MS3
{
    public partial class Show : System.Web.UI.Page
    {
        string id;

        /// <summary>
        /// Ustawienie nazwy strony. Jeśli użytkownik jest zalogowany, włącznie guzików edycji i usunięcia wyświetlanej książki.
        /// Jeśli został podany parapetr "id" wyświetlenie informacji o książce, jeśli nie przekierowanie na stronę główną.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Biblioteka - Szczegóły książki";

            if (Session["LOGIN"] != null)
                edit.Visible = true;

            id = Request.QueryString["id"];

            if (id != null)
            {
                LibraryServiceClient lib = new LibraryServiceClient();
                String url = lib.Endpoint.Address.Uri.ToString();
                String serviceName = "LibraryService.svc";
                url = url.Remove(url.Length - serviceName.Length, serviceName.Length);
                url = url + "covers/";
                LibraryService.Book b = lib.getBookInfo(Int32.Parse(id));
                LabelTytul.Text = b.tytul;
                Page.Title = string.Format("Biblioteka - {0}", LabelTytul.Text);
                LabelOpis.Text = b.opis;
                LabelAutorzy.Text = b.autorzy;
                LabelWydawnictwo.Text = getData(b.wydawnictwo);
                LabelOprawa.Text = b.oprawa;
                LabelWymiary.Text = getData(b.wymiary);
                if (b.iloscStron == 0) LabelLiczbaStron.Text = "Brak danych";
                else LabelLiczbaStron.Text = b.iloscStron.ToString();
                LabelISBN.Text = getData(b.isbn);
                string fileName = b.okladka;
                if (!String.IsNullOrWhiteSpace(fileName))
                    ImageOkladka.ImageUrl = string.Format(url + fileName);
                else
                    ImageOkladka.ImageUrl = string.Format(url + "brak-okladki.jpg");
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }


        /// <summary>
        /// Po kliknięci "Edytuj" przekierowanie do strony edycji (tylko dla zalogowanych).
        /// </summary>
        protected void lbtnEdytuj_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/Add.aspx?editID={0}", id));
        }

        /// <summary>
        /// Po kliknięciu "Usuń" usunięcie z bazy danej książki i przekierowanie na stronę główną.
        /// </summary>
        protected void lbtnUsun_Click(object sender, EventArgs e)
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            lib.deleteBook(Int32.Parse(id));
            Response.Redirect("~/Default.aspx");
        }

        private string getData(string data)
        {
            if (!String.IsNullOrWhiteSpace(data))
                return data;
            else
                return "Brak danych";
        }
    }
}