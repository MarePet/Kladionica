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

namespace Client.FormeKorisnik
{
    public partial class FrmRegistracija : Form
    {
        private readonly MainController mainController;


        public FrmRegistracija(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {
            mainController.KreirajKorisnickiNalog(txtIme, txtPrezime, txtGodine, txtKorisnickoIme, txtLozinka);
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
