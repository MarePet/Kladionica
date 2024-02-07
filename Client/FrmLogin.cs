using Client.KontroleriS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController = new LoginController();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginController.PoveziSe())
                {
                    loginController.Login(txtKorisnickoIme, txtLozinka, this, rbKorisnik, rbAdministrator);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginController.PoveziSe())
                {
                    loginController.OtvoriRegistraciju(this);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
