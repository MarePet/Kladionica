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
    public partial class FrmIzmenaNaloga : Form
    {
        private readonly MainController mainController;
        public FrmIzmenaNaloga(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            txtIme.Text = mainController.ulogovaniKorisnik.Ime;
            txtPrezime.Text = mainController.ulogovaniKorisnik.Prezime;
            txtGodine.Text = mainController.ulogovaniKorisnik.Godine.ToString();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.IzmeniKorisnickiNalog(txtIme, txtPrezime, txtGodine, txtKorisnickoIme, txtLozinka);
            this.Close();
        }
    }
}
