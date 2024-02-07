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
    public partial class FrmDodajUtakmicu : Form
    {
        private readonly MainController mainController;

        public FrmDodajUtakmicu(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            mainController.UcitajGradove(cbGrad);
            mainController.UcitajKlubove(cbDomacin,cbGost);
            mainController.ucitajVrsteUtakmica(cbVrstaUtakmice);
           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            mainController.UnesiUtakmicu(txtNazivDrzave, txtVremePocetka, txtKvota1,txtKvotaX,txtKvota2, cbDomacin, cbGost, cbGrad, cbVrstaUtakmice);
        }

        
    }
}
