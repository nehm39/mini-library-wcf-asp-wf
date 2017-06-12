using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projekt.MS3.LibraryService;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Projekt.MS3
{
    public partial class Default : System.Web.UI.Page
    {
        public String webServiceUrl = "";
        /// <summary>
        /// Ustawienie tytułu strony.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object senderr, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            LibraryServiceClient lib = new LibraryServiceClient();
            String url = lib.Endpoint.Address.Uri.ToString();
            String serviceName = "LibraryService.svc";
            url = url.Remove(url.Length - serviceName.Length, serviceName.Length);
            url = url + "covers/";
            webServiceUrl = url;
            Page.Title = "Biblioteka";
        }

        /// <summary>
        /// Metoda wywołująca się podczas "wpisywania" danych do listy dla każdego elementu. Sprawdza czy 
        /// dana książka ma okładkę, jeśli nie ustawia na domyślne zdjęcie z napisem "brak okładki".
        /// </summary>
        protected void ListView1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                HyperLink hl = (HyperLink)e.Item.FindControl("K_OKLADKAImage");
                String x = hl.ImageUrl.ToString();
                if (String.IsNullOrWhiteSpace(hl.ImageUrl.ToString()))
                {
                    hl.ImageUrl = webServiceUrl + "brak-okladki.jpg";
                }
                else
                {
                    hl.ImageUrl = webServiceUrl + hl.ImageUrl.ToString();
                }
            }
        }

        public BookForListLong[] getBooksList()
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            return lib.getBooksListLong();
        }
    }
}