using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projekt.MS3.LibraryService;

namespace Projekt.MS3
{
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// Ustawienie tytułu strony i przekierowanie na stronę główną jeśli jesteśmy już zalogowani.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Biblioteka - Logowanie";

            if (Session["LOGIN"] != null)
                Response.Redirect("~/Default.aspx");

            error.Visible = false;
        }

        /// <summary>
        /// Guzik odpowiadający za logowanie użytkownika. Po walidacji danych przechowuje w sesji login użytkownika.
        /// Udane logowanie przekierowuje do panelu administracyjnego.
        /// </summary>
        protected void ButtonZaloguj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLogin.Text) || string.IsNullOrWhiteSpace(TextBoxHaslo.Text))
            {
                LabelError.Text = "Wpisz login i hasło.";
                error.Visible = true;
            }
            else
            {
                LibraryServiceClient lib = new LibraryServiceClient();
                Boolean credentialsCorrect = lib.checkCredentials(TextBoxLogin.Text.ToString(), TextBoxHaslo.Text.ToString());
                if (credentialsCorrect)
                {
                    Session["LOGIN"] = TextBoxLogin.Text;
                    Response.Redirect("~/ACP.aspx");
                }
                else
                {
                    LabelError.Text = "Błędne dane.";
                    error.Visible = true;
                }
            }
        }
    }
}