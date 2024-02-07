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
    public partial class FrmDodajKomponente : Form
    {
        private readonly MainController mainController;

        public FrmDodajKomponente(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            mainController.DodajNovuKomponentu(txtNaziv, txtOpis, cbTip, dataGridView1);
        }

        private void FrmDodajKomponente_Load(object sender, EventArgs e)
        {
            mainController.PopuniCbTip(cbTip,dataGridView1);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            mainController.SacuvajKomponente(dataGridView1,txtNaziv,txtOpis);
        }
    }
}
