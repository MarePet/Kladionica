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
    public partial class FrmKreirajTiket : Form
    {
        private readonly MainController mainController;

        public FrmKreirajTiket(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;

        }

        private void FrmKreirajTiket_Load(object sender, EventArgs e)
        {
            
            dgvUtakmice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvUtakmice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            mainController.UcitajUtakmice(dgvUtakmice);
            mainController.PopuniPolja(txtDatumUplate,dgvStavkeTiketa);
            txtKvota.Text = "1";
        }

        private void dgvUtakmice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUtakmice.SelectedCells.Count > 0)
            {
                mainController.DodajNovuStavku(dgvStavkeTiketa, dgvUtakmice,txtUplata,txtPotencijalnaIsplata,txtKvota);
                //dgvUtakmice.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            mainController.ObrisiStavkuTiketa(dgvStavkeTiketa, txtUplata, txtPotencijalnaIsplata, txtKvota);
        }

        private void txtUplata_TextChanged(object sender, EventArgs e)
        {
            mainController.AzurirajIsplatu(txtPotencijalnaIsplata,txtUplata,txtKvota);
        }

        private void txtUplata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !='.' && e.KeyChar !=',' && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
            
        }

        private void btnOsveži_Click(object sender, EventArgs e)
        {
            mainController.UcitajUtakmice(dgvUtakmice);
        }

        private void btnKreirajTiket_Click(object sender, EventArgs e)
        {
            mainController.SacuvajTiket(txtUplata, txtDatumUplate,txtKvota, txtPotencijalnaIsplata, dgvStavkeTiketa);
        }

        private void dgvStavkeTiketa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
