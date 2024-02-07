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

namespace Client.FormeAdministrator
{
    public partial class FrmIzmeniUtakmice : Form
    {
        private readonly MainController mainController;
        public FrmIzmeniUtakmice(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void FrmIzmeniUtakmice_Load(object sender, EventArgs e)
        {
            mainController.PopuniVrednostiZaUtamice(cbUtakmice,cbRezultat);

        }

        private void btnIzmeniRezultat_Click(object sender, EventArgs e)
        {
            mainController.IzmeniUtakmicu(cbUtakmice, cbRezultat);
        }
    }
}
