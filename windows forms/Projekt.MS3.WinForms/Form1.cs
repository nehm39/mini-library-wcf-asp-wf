using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.MS3.WinForms.LibraryService;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Projekt.MS3.WinForms
{
    public partial class Form1 : Form
    {
        public Boolean logged = false;

        public Form1()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            InitializeComponent();
            cbSearchPagesType.SelectedIndex = 2;
            cbSearchBinding.SelectedIndex = 0;
            getBooks();          
        }

        private void getBooks()
        {
            gvBooksList.Rows.Clear();
            LibraryServiceClient lib = new LibraryServiceClient();
            foreach (BookForListShort b in lib.getBooksListShort())
            {
                gvBooksList.Rows.Add(b.Id.ToString(), b.tytul.ToString());
            }
            
        }

        public void changeLogonState(Boolean log)
        {
            if (log)
            {
                loginToolStripMenuItem.Text = "Wyloguj";
                btnAddBook.Visible = true;
                btnEditBook.Visible = true;
                btnDeleteBook.Visible = true;
            }
            else
            {
                loginToolStripMenuItem.Text = "Zaloguj";
                btnAddBook.Visible = false;
                btnEditBook.Visible = false;
                btnDeleteBook.Visible = false;
            }
        }

        private void gvBooksList_SelectionChanged(object sender, EventArgs e)
        {

            if (gvBooksList.Rows.Count > 0)
            {
                LibraryServiceClient lib = new LibraryServiceClient();
                String url = lib.Endpoint.Address.Uri.ToString();
                String serviceName = "LibraryService.svc";
                url = url.Remove(url.Length - serviceName.Length, serviceName.Length);
                url = url + "covers/";
                Book b = lib.getBookInfo(Int32.Parse(gvBooksList.CurrentRow.Cells["Id"].Value.ToString()));
                try
                {
                    txtDescription.Text = b.opis.Replace("<br> ", "\r\n");
                }
                catch (Exception)
                {

                }
                txtPublisher.Text = getData(b.wydawnictwo);
                txtAuthors.Text = b.autorzy;
                txtBinding.Text = b.oprawa;
                txtISBN.Text = getData(b.isbn);
                txtDimensions.Text = getData(b.wymiary);
                if (b.iloscStron == 0) txtPagesNumber.Text = "Brak danych";
                else txtPagesNumber.Text = b.iloscStron.ToString();


                string fileName = b.okladka;
                if (!String.IsNullOrWhiteSpace(fileName))
                {
                    pictureBox1.ImageLocation = string.Format(url + fileName);
                    pictureBox1.Tag = b.okladka;
                }
                else
                {
                    pictureBox1.ImageLocation = string.Format(url + "brak-okladki.jpg");
                    pictureBox1.Tag = null;
                }
            }
        }

        public static string getData(string data)
        {
            if (!String.IsNullOrWhiteSpace(data))
                return data;
            else
                return "Brak danych";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                MessageBox.Show("Wylogowano pomyślnie", "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                changeLogonState(false);
                logged = false;
            }
            else
            {
                Login zal = new Login(this);
                zal.ShowDialog();
            }

        }

        private void btnShowAdvancedSearch_Click(object sender, EventArgs e)
        {
            if (panelSearch.Visible)
            {
                txtSearchSimple.Text = txtSearchQuery.Text;
                panelSearch.Visible = false;
                btnShowAdvancedSearch.Text = "Rozwiń zaawansowane wyszukiwanie";
                txtSearchSimple.Enabled = true;
                btnSimpleSearch.Enabled = true;
            }
            else
            {
                txtSearchQuery.Text = txtSearchSimple.Text;
                panelSearch.Visible = true;
                btnShowAdvancedSearch.Text = "Zwiń zaawansowane wyszukiwanie";
                txtSearchSimple.Enabled = false;
                btnSimpleSearch.Enabled = false;
            }
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            gvBooksList.Rows.Clear();
            foreach (BookForListShort b in lib.searchBooksSimple(txtSearchSimple.Text.ToString()))
            {
                gvBooksList.Rows.Add(b.Id.ToString(), b.tytul.ToString());
            }
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            gvBooksList.Rows.Clear();
            String query = txtSearchQuery.Text.ToString();
            Boolean titleDesc = cbSearchBoth.Checked;
            String authors = txtSearchAuthor.Text.ToString();
            String publisher = txtSearchPublisher.Text.ToString();
            int binding = cbSearchBinding.SelectedIndex;
            int pages = -1;
            if (nudSearchPages.Value > 0) pages = (int)nudSearchPages.Value;
            int pagesSearchType = cbSearchPagesType.SelectedIndex;
            String isbn = txtSearchISBN.Text.ToString();
            foreach (BookForListShort b in lib.searchBooksAdvanced(query, titleDesc, authors, publisher, binding, pages, pagesSearchType, isbn))
            {
                gvBooksList.Rows.Add(b.Id.ToString(), b.tytul.ToString());
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tą książkę?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LibraryServiceClient lib = new LibraryServiceClient();
                int selection = Convert.ToUInt16(gvBooksList.CurrentRow.Cells["Id"].Value.ToString());
                int index = gvBooksList.CurrentCell.RowIndex;
                if (index == 0) index++;
                lib.deleteBook(selection);
                getBooks();
                gvBooksList.CurrentCell = gvBooksList.Rows[index - 1].Cells[1];
            }
            
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                Details d = new Details(Convert.ToUInt16(gvBooksList.CurrentRow.Cells["Id"].Value.ToString()));
                if (d.ShowDialog() == DialogResult.OK)
                {
                    getBooks();
                }
            }
        }

        private void txtSearchSimple_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSimpleSearch;
        }

        private void txtSearchSimple_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                Details d = new Details();
                if (d.ShowDialog() == DialogResult.OK)
                {
                    getBooks();
                }
            }
        }
    }
}
