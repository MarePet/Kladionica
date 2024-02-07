using Client.Exceptioni;
using Client.FormeKorisnik;
using Client.Helperi;
using Client.Komunikacija;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.KontroleriS
{
    public class LoginController
    {
        private MainController mainController = new MainController();

        internal bool PoveziSe()
        {
            try
            {
                Komunikacija.Komunikacija.Instanca.PoveziSe();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška pri povezivanju sa serverom");
                return false;
            }
        }

        internal void Login(TextBox txtKorisnickoIme,TextBox txtLozinka,FrmLogin frmLogin,RadioButton rbKorisnik,RadioButton rbAdministrator)
        {
            if(!UserControlsHelp.PraznoPoljeValidacija(txtKorisnickoIme) | !UserControlsHelp.PraznoPoljeValidacija(txtLozinka))
            {
                return;
            }
            try
            {
                if(rbKorisnik.Checked == true)
                {
                    Korisnik k = Komunikacija.Komunikacija.Instanca.Login(txtKorisnickoIme.Text, txtLozinka.Text);
                    if (k != null)
                    {
                        if (k.Ulogovan)
                        {
                            throw new Exception("Korisnik je već ulogovan!");
                        }
                        MessageBox.Show("Uspešno ste se ulogovali");
                        mainController.ulogovaniKorisnik = k;
                        FrmKorisnik frmKorisnik = new FrmKorisnik(mainController);
                        frmLogin.Visible = false; 
                        frmKorisnik.ShowDialog();
                        frmLogin.Visible = true; 
                    }
                    else
                    {
                        throw new Exception("Niste uneli odgovarajuće podatke");
                    }
                }
                else if(rbAdministrator.Checked == true)
                {
                    Administrator a = Komunikacija.Komunikacija.Instanca.LoginAdministrator(txtKorisnickoIme.Text, txtLozinka.Text);
                    if (a != null)
                    {
                        MessageBox.Show("Uspešno ste se ulogovali");
                        mainController.ulogovaniAdministrator = a;
                        FrmAdministrator frmAdministrator = new FrmAdministrator(mainController);
                        frmLogin.Visible = false;
                        frmAdministrator.ShowDialog();
                        frmLogin.Visible = true;
                    }
                    else
                    {
                        throw new Exception("Niste uneli odgovarajuće podatke");

                    }
                }
                else
                {
                    MessageBox.Show("Odaberite opciju Korisnik ili Administrator!");
                    return;
                }
            }
            catch (SistemskaOperacijaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void OtvoriRegistraciju(FrmLogin frmLogin)
        {
            FrmRegistracija frmRegistracija = new FrmRegistracija(mainController);
            frmLogin.Visible = false;
            frmRegistracija.ShowDialog();
            frmLogin.Visible = true;
        }
    }
}
