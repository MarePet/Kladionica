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

namespace Client.FormeKorisnik
{
    public partial class FrmInformacijeTiket : Form
    {
        private readonly MainController mainController;
        Tiket izabraniTiket;

        public FrmInformacijeTiket(MainController mainController,Tiket izabraniTiket)
        {
            InitializeComponent();
            this.mainController = mainController;
            this.izabraniTiket = izabraniTiket;
            PopuniInformacijama();
            
        }

        private void PopuniInformacijama()
        {
            txtDatum.Text = izabraniTiket.DatumUplate.ToString("dd.MM.yyyy.");
            txtUplata.Text = izabraniTiket.Uplata.ToString();
            txtStatus.Text = izabraniTiket.StatusT.ToString();
            txtIsplata.Text = izabraniTiket.PotencijalnaIsplata.ToString();
            dgvStavkeTiketa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStavkeTiketa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            mainController.UcitajStavkeTiketa(dgvStavkeTiketa, izabraniTiket);
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStavkeTiketa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ObojRedove();
        }

        private void ObojRedove()
        {
            foreach (DataGridViewRow r in dgvStavkeTiketa.Rows)
            {
                string dobitan = Convert.ToString(r.Cells[3].Value);

                if (dobitan == Status.Dobitan.ToString())
                {
                    r.DefaultCellStyle.BackColor = Color.LightGreen;

                }
                else if (dobitan == Status.Gubitan.ToString())
                {
                    r.DefaultCellStyle.BackColor = Color.LightCoral;

                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
