using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projekt.MS3.LibraryService;

namespace Projekt.MS3
{
    public partial class Search : System.Web.UI.Page
    {
        String query = "";
        /// <summary>
        /// Ustawinie tytułu strony. Po otworzeniu strony z parametrm "string" rozpoczęcie wyszukiwania podstawowego.
        /// Jeśli strona została załadowana ponownie z parametrem "command" w ViewState - wyszukiwanie zaawansowane.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Biblioteka - Wyszukiwarka";
            query = Request.QueryString["string"];

            if (!Page.IsPostBack)
            {
                
                int page = 1;
                Int32.TryParse(Request.QueryString["page"], out page);

                if (query != null && !query.Equals(""))
                {
                    ListView1.DataSource = searchSimple(query);
                    ListView1.DataBind();
                    txtSzukanyTekst.Text = query;
                    ListView1.Visible = true;
                }
                else
                {
                    ListView1.Visible = false;
                }
            }

        }

        public BookForListShort[] searchSimple(String text)
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            return lib.searchBooksSimple(text);
        }

        /// <summary>
        /// Guzik odpowiadający za wyszukiwanie zaawansowane.
        /// </summary>
        protected void btnSzukanieZaawansowane_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                query = txtSzukanyTekst.Text.ToString();
                ListView1.Visible = true;
                LibraryServiceClient lib = new LibraryServiceClient();
                Boolean titleDesc = chbxSzukajWOpisie.Checked;
                String authors = txtAutor.Text.ToString();
                String publisher = txtWydawnictwo.Text.ToString();
                int binding = ddOprawa.SelectedIndex;
                int pages = -1;
                if (!String.IsNullOrWhiteSpace(txtIloscStron.Text.ToString())) pages = Int32.Parse(txtIloscStron.Text.ToString());
                int pagesSearchType = ddIloscStron.SelectedIndex;
                String isbn = txtISBN.Text.ToString();
                ListView1.DataSource = lib.searchBooksAdvanced(query, titleDesc, authors, publisher, binding, pages, pagesSearchType, isbn);
                ListView1.DataBind();
            }
        }

        /// <summary>
        /// CustomValidator odpowiadający za sprawdzenie długości tekstu w kontrolkach.
        /// </summary>
        protected void SzukanyTekstCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (txtISBN.Text.Trim().Length > 0)
            {
                args.IsValid = true;
                return;
            }

            if (args.Value.Trim().Length < 3)
                args.IsValid = false;
        }

    }
}