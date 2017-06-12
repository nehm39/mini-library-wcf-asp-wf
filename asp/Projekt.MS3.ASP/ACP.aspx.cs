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
    public partial class ACP : System.Web.UI.Page
    {
        /// <summary>
        /// Ustawienie tytułu strony, timera odliczajacego czas do przekierowania i 
        /// wyświetlenie odpowiedniej treści dla zalogowanego lub niezalogowanego użytkownika (przekierowanie).
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Biblioteka - Panel Adminisracyjny";

            if (!IsPostBack)
            {
                ViewState["CZAS"] = 2;
            }

            if (Session["LOGIN"] != null)
            {
                access_denied.Visible = false;
                access_granted.Visible = true;
            }
            else
            {
                access_denied.Visible = true;
                access_granted.Visible = false;
                Timer1.Enabled = true;
            }

        }

        public BookForListShort[] getBooksList()
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            return lib.getBooksListShort();
        }

        /// <summary>
        /// Aktualizacja labelki z czasem.
        /// </summary>
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            int czas = int.Parse(ViewState["CZAS"].ToString());
            LabelTime.Text = czas.ToString();
            czas--;
            ViewState["CZAS"] = czas;

            if (czas < 0)
            {
                Timer1.Dispose();

                Response.Redirect("~/Default.aspx");
            }
        }

        /// <summary>
        /// Ustawienie ilości wyświetlanych elementów na stronę po wybraniu w kontrolce DropDownList. 
        /// </summary>
        protected void ddElementowNaStrone_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataPager1.PageSize = Convert.ToInt32(ddElementowNaStrone.SelectedValue);
        }

        /// <summary>
        /// Guzik usuwający z bazy zaznaczone książki.
        /// </summary>
        protected void btnUsunZaznaczone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in ListView1.Items)
            {
                CheckBox chbox = lvi.FindControl("CheckBoxItem") as CheckBox;

                if (chbox.Checked)
                {
                    try
                    {
                        HiddenField hf = lvi.FindControl("ID_KSIAZKA") as HiddenField;
                        string id = hf.Value;

                        LibraryServiceClient lib = new LibraryServiceClient();
                        lib.deleteBook(Int32.Parse(id));

                    }
                    catch (Exception)
                    {
                    }
                }
            }

            ListView1.DataBind();
            showInfo("Pomyślnie usunięto zaznaczone elementy");
        }

        /// <summary>
        /// Metoda wyświetlająca zielony pasek na górze strony i informacją podaną w parametrze.
        /// </summary>
        /// <param name="text">treść informacji</param>
        private void showInfo(string text)
        {
            lblInfo.Text = text;
            info.Visible = true;
        }

        /// <summary>
        /// Guzik zaznaczający wszyskie elementy (książki) na liście.
        /// </summary>
        protected void btnZaznaczWszystko_Click(object sender, EventArgs e)
        {
            bool ch = Convert.ToBoolean(ViewState["zaznaczone"]);

            foreach (ListViewItem lvi in ListView1.Items)
            {
                CheckBox chbox = lvi.FindControl("CheckBoxItem") as CheckBox;
                chbox.Checked = ch ? false : true;
            }

            if (ch)
            {
                btnZaznaczWszystko.Text = "Zaznacz wszystko";
                ViewState["zaznaczone"] = false;
            }
            else
            {
                btnZaznaczWszystko.Text = "Odznacz wszystko";
                ViewState["zaznaczone"] = true;
            }
        }
    }
}