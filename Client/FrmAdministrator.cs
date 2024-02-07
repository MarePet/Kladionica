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

namespace Client
{
    public partial class FrmAdministrator : Form
    {
        private readonly MainController mainController;
        public FrmAdministrator(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            lblUlogovaniAdministrator.Text = mainController.ulogovaniAdministrator.KorisnickoIme.ToUpper();
        }         

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OtvoriFrmKorisnici(this);
        }

        private void utakmiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OtvoriFrmDodajUtakmicu(this);
        }

        private void tiketiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OtvoriFrmIzmeniUtakmice(this);
        }
    }
}
