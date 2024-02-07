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
    public partial class FrmKorisnik : Form
    {
        private readonly MainController mainController;
        public FrmKorisnik()
        {
        }
        public FrmKorisnik(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            lblUlogovaniKorisnik.Text = mainController.ulogovaniKorisnik.Ime +" "+ mainController.ulogovaniKorisnik.Prezime;
        }

        private void btnIzmeniNalog_Click(object sender, EventArgs e)
        {
            mainController.OtvoriFormuIzmenaKorisnickogNaloga(this);
        }

        private void kreirajTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OtvoriFrmKreirajTiket(this);
        }

        private void FrmKorisnik_Load(object sender, EventArgs e)
        {

        }

        private void pogledajSvojeTiketeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OtvoriFrmSviTiketi(this);
        }

        private void dodajKomponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OtvoriFrmDodajKomponentu(this);
        }
    }
}
