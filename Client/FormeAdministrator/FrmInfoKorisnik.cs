using Client.KontroleriS;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormeAdministrator
{
    public partial class FrmInfoKorisnik : Form
    {
        private readonly MainController mainController;
        Korisnik izabraniKorisnik;
        public FrmInfoKorisnik(MainController mainController,Korisnik izabraniKorisnik)
        {
            InitializeComponent();
            this.mainController = mainController;
            this.izabraniKorisnik = izabraniKorisnik;
            txtIme.Text = izabraniKorisnik.Ime;
            txtPrezime.Text = izabraniKorisnik.Prezime;
            txtGodine.Text = izabraniKorisnik.Godine.ToString();
            txtKorisnickoIme.Text = izabraniKorisnik.KorisnickoIme;
            txtLozinka.Text = izabraniKorisnik.Lozinka;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
