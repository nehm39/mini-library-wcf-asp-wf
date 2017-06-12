using Projekt.MS3.WinForms.LibraryService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.MS3.WinForms
{
    public partial class Details : Form
    {
        private int id = 0;

        public Details()
        {
            InitializeComponent();
        }

        public Details(int id) : this()
        {
            this.id = id;
            bookToForm(id);
            btnConfirm.Text = "Edytuj";
            this.Text = "Edycja książki";
        }

        private bool isBookDataValid()
        {
            if (txtTitle.Text.Length < 3)
            {
                MessageBox.Show("Za krótki tytuł!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDescription.Text.Length < 3)
            {
                MessageBox.Show("Za krótki opis!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAuthors.Text.Length < 3)
            {
                MessageBox.Show("Za krótki autor!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPublisher.Text.Length < 3)
            {
                MessageBox.Show("Za krótkie wydawnictwo!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void clearEditingControls()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtAuthors.Clear();
            txtPublisher.Clear();
            cbBinding.SelectedIndex = 1;
            txtDimensions.Clear();
            numericPagesNumber.Value = 0;
            txtISBN.Clear();

            pictureBox1.Image = null;
        }

        private Book bookFromForm()
        {
            Book b = new Book();

            b.Id = this.id;
            b.tytul = txtTitle.Text;
            b.autorzy = txtAuthors.Text;
            b.wydawnictwo = txtPublisher.Text;
            b.oprawa = cbBinding.SelectedItem != null ? cbBinding.SelectedItem.ToString() : string.Empty;
            b.wymiary = txtDimensions.Text;
            b.iloscStron = (int) numericPagesNumber.Value;
            b.isbn = txtISBN.Text;
            b.opis = txtDescription.Text.Replace("\r\n", "<br> ");
            b.wydawnictwo = txtPublisher.Text;
            b.okladka = pictureBox1.Image != null ? imageToString(pictureBox1.Image) : null;

            return b;
        }

        private void bookToForm(int id)
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            Book b = lib.getBookInfo(id);
            String url = lib.Endpoint.Address.Uri.ToString();
            String serviceName = "LibraryService.svc";
            url = url.Remove(url.Length - serviceName.Length, serviceName.Length);
            url = url + "covers/";
            try
            {
                txtDescription.Text = b.opis.Replace("<br> ", "\r\n");
            }
            catch (Exception)
            {

            }
            txtTitle.Text = b.tytul;
            txtPublisher.Text = Form1.getData(b.wydawnictwo);
            txtAuthors.Text = b.autorzy;
            if (!string.IsNullOrWhiteSpace(b.oprawa))
            {
                if (b.oprawa == "miękka")
                    cbBinding.SelectedIndex = 0;
                else if(b.oprawa == "twarda")
                    cbBinding.SelectedIndex = 1;
                else
                    cbBinding.SelectedIndex = -1;
            }
            txtISBN.Text = Form1.getData(b.isbn);
            txtDimensions.Text = Form1.getData(b.wymiary);
            numericPagesNumber.Value = b.iloscStron;


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
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!isBookDataValid())
            {
                return;
            }

            if (id > 0)
            {
                LibraryServiceClient lib = new LibraryServiceClient();

                if (lib.updateBook(bookFromForm()))
                {
                    MessageBox.Show("Książka edytowana poprawnie.", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Książka nie została zaktualizowana", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LibraryServiceClient lib = new LibraryServiceClient();

                if (lib.addBook(bookFromForm()))
                {
                    MessageBox.Show("Książka dodana poprawnie.", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Książka nie została dodana", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCoverRemove_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Tag = null;
        }

        private void btnCoverLoad_Click(object sender, EventArgs e)
        {
            if (ofdCover.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdCover.FileName);
            }
            //if (FileUpload1.HasFile)
            //{
            //    if (!(String.IsNullOrWhiteSpace(FileUpload1.FileName)))
            //    {
            //        byte[] image = FileUpload1.FileBytes;
            //        book.okladka = Encoding.Default.GetString(image, 0, image.Length);
            //    }
            //}

            
        }

        private string imageToString(Image image)
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] msArray = ms.ToArray();
                return Encoding.Default.GetString(msArray, 0, msArray.Length);
            }

            return null;
        }
    }
}
