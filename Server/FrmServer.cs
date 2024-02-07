using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
        }
        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtServerInfo.Text = "Server nije pokrenut...";
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Pokreni();
                Thread nit=new Thread(s.Osluskuj);
                nit.IsBackground = true;
                nit.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                txtServerInfo.Text = "Server je pokrenut!";
                txtServerInfo.BackColor = Color.LightGreen;

            }
            catch (SocketException ex)
            {
                MessageBox.Show("Neuspesno pokretanje servera" + ex.Message);
                throw;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            try
            {
                s.Zaustavi();
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
                txtServerInfo.Text = "Server je zaustavljen!";
                txtServerInfo.BackColor = Color.LightCoral;
            }
            catch (SocketException)
            {
                Console.WriteLine(">>>Server je zaustavljen");
            }
        }
    }
}
