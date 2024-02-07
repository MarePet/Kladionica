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
    public partial class FrmKorisnici : Form
    {
        private readonly MainController mainController;
        public FrmKorisnici(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainController.UcitajKorisnike(dgvKorisnici);

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.PretraziKorisnike(txtPretrazi, dgvKorisnici);

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati korisnika.");
                return;
            }
            Korisnik k = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            mainController.OtvoriInformacije(this, k);
        }

        private void txtPretrazi_Enter(object sender, EventArgs e)
        {
            txtPretrazi.Text = "";
        }

        private void FrmKorisnici_Load(object sender, EventArgs e)
        {
            dgvKorisnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKorisnici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            mainController.UcitajKorisnike(dgvKorisnici);
        }

        private void txtPretrazi_Leave(object sender, EventArgs e)
        {

        }
    }
}
