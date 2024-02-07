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
    public partial class FrmSviTiketi : Form
    {
        private readonly MainController mainController;

        public FrmSviTiketi(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void FrmSviTiketi_Load(object sender, EventArgs e)
        {
            dgvSviTiketi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSviTiketi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            mainController.UcitajTikete(dgvSviTiketi);
        }

        private void txtPretrazi_Enter(object sender, EventArgs e)
        {
            txtPretrazi.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvSviTiketi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati tiket.");
                return;
            }
            Tiket t = dgvSviTiketi.SelectedRows[0].DataBoundItem as Tiket;
            mainController.OtvoriTiketInformacije(this, t);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.PretraziTikete(txtPretrazi, dgvSviTiketi);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainController.UcitajTikete(dgvSviTiketi);
        }

        private void dgvSviTiketi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ObojRedove();
        }

        private void ObojRedove()
        {
            foreach (DataGridViewRow r in dgvSviTiketi.Rows)
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

