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

namespace Projekt.MS3.WinForms
{
    public partial class Login : Form
    {
        Form1 form;
        public Login(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LibraryServiceClient lib = new LibraryServiceClient();
            Boolean check = lib.checkCredentials(txtLogin.Text.ToString(), txtPassword.Text.ToString());
            if (check)
            {
                form.logged = true;
                form.changeLogonState(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Podano błędne dane.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }
    }
}
