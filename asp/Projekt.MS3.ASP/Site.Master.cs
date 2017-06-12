using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt.MS3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        /// <summary>
        /// Dla zalogowanych użytkowników pokazywanie powitania i guzików kierujących do Panelu Administracyjnego oraz Wylogowania.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOGIN"] != null)
            {
                login_info.Visible = true;
                HyperLinkLogin.Visible = false;
                LabelLoginInfo.Text = string.Format("Witaj {0}", Session["LOGIN"]);
            }
            else
            {
                login_info.Visible = false;
                HyperLinkLogin.Visible = true;
            }
        }
        /// <summary>
        /// Guzik kierujący użytkownia do strony wyszukiwania w zależności do wpisanej treści.
        /// </summary>
        protected void ButtonSzukaj_Click(object sender, EventArgs e)
        {
            if (SzukajCustomValidator.IsValid)
            {
                if (TextBoxSzukaj.Text.Length >= 3)
                    Response.Redirect(string.Format("~/Search.aspx?string={0}", Server.UrlEncode(TextBoxSzukaj.Text)));
                else
                    Response.Redirect("~/Search.aspx");
            }
        }

        /// <summary>
        /// Guzik odpowiadający za wylogowanie. Czyści sesje i kieruje do odpowiedniej strony.
        /// </summary>
        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            string url = Request.RawUrl;
            if(!url.Contains("ACP.aspx"))
                Response.Redirect(Request.RawUrl);
            else
                Response.Redirect("~/Default.aspx");
        }

        /// <summary>
        /// Guzik kierujący do panelu administracyjnego.
        /// </summary>
        protected void LinkButtonACP_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ACP.aspx");
        }

        /// <summary>
        /// Walidator wyszukiwania.
        /// </summary>
        protected void SzukajCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Trim().Length == 0 || args.Value.Trim().Length >= 3)
            {
                args.IsValid = true;
                return;
            }

            if (args.Value.Trim().Length < 3)
                args.IsValid = false;
        }
    }
}