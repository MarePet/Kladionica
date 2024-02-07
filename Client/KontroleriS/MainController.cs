using Client.Exceptioni;
using Client.FormeAdministrator;
using Client.FormeKorisnik;
using Client.Helperi;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.KontroleriS
{
    public class MainController
    {
        public Korisnik ulogovaniKorisnik { get; set; } = new Korisnik();
        public Administrator ulogovaniAdministrator { get; set; } = new Administrator();



        public void KreirajKorisnickiNalog(TextBox txtIme,TextBox txtPrezime,TextBox txtGodine,TextBox txtKorisnickoIme,TextBox txtLozinka)
        {
            if(!UserControlsHelp.PraznoPoljeValidacija(txtIme) | !UserControlsHelp.PraznoPoljeValidacija(txtPrezime) | !UserControlsHelp.PraznoPoljeValidacija(txtGodine) | !UserControlsHelp.PraznoPoljeValidacija(txtKorisnickoIme) | !UserControlsHelp.PraznoPoljeValidacija(txtLozinka))
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }
            if(Convert.ToInt32(txtGodine.Text) < 18)
            {
                MessageBox.Show("Morate biti punoletni da biste kreirali nalog!");
                return;
            }
            try
            {
                Korisnik korisnik = new Korisnik
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Godine = Convert.ToInt32(txtGodine.Text),
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                };
                Komunikacija.Komunikacija.Instanca.KreirajKorisnickiNalog(korisnik);
                MessageBox.Show("Sistem je uspešno kreirao vaš nalog.");
            }
            catch (SistemskaOperacijaException ex)
            {
                MessageBox.Show("Sistem ne može da kreira nalog. \n" + ex.Message);
            }
            catch(ServerException ex)
            {
                MessageBox.Show("Sistem ne može da kreira nalog. \n" + ex.Message);
            }
        }

        internal void SacuvajKomponente(DataGridView dataGridView1,TextBox txtNaziv,TextBox txtOpis)
        {
            //try
            //{
                foreach (RacunarskaKomponenta rk in listaKomponenti)
                {
                    Komunikacija.Komunikacija.Instanca.SacuvajKomponente(rk);
                }
                MessageBox.Show("Sistem je zapamtio komponente.");
                OcistiformuKomponente(dataGridView1, txtNaziv, txtOpis);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Naziv neke komponente vec postoji u bazi");
            //}


        }

        private void OcistiformuKomponente(DataGridView dgv,TextBox txtnaziv,TextBox txtopis)
        {
            dgv.DataSource = new BindingList<RacunarskaKomponenta>();
            txtnaziv.Text = "";
            txtopis.Text = "";
        }

        internal void PopuniCbTip(ComboBox cbTip,DataGridView dgvKomponente)
        {
            cbTip.DataSource = listaTipovaKomp;
            dgvKomponente.DataSource = listaKomponenti;
        }

        private List<string> listaTipovaKomp = new List<string>()
        {
            "I",
            "U",
            "U/I",
            "OSTALO"
        };
        private BindingList<RacunarskaKomponenta> listaKomponenti = new BindingList<RacunarskaKomponenta>();
        internal void DodajNovuKomponentu(TextBox txtNaziv, TextBox txtOpis, ComboBox cbTip, DataGridView dataGridView1)
        {
            if(!UserControlsHelp.PraznoPoljeValidacija(txtNaziv) | !UserControlsHelp.PraznoPoljeValidacija(txtOpis) | cbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }

            RacunarskaKomponenta rk = new RacunarskaKomponenta
            {
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text,
                Tip = (string)cbTip.SelectedItem

            };

            List<RacunarskaKomponenta> listaIzBaze = new List<RacunarskaKomponenta>();
            listaIzBaze = Komunikacija.Komunikacija.Instanca.VratiKomponente();

            foreach (RacunarskaKomponenta r in listaIzBaze)
            {
                if(rk.Naziv == r.Naziv)
                {
                    MessageBox.Show("Komponenta vec postoji u bazi");
                    return;
                }
            }

            listaKomponenti.Add(rk);



        }

        internal void OtvoriFrmDodajKomponentu(FrmKorisnik frmKorisnik)
        {
            FrmDodajKomponente frmDodajKomponente = new FrmDodajKomponente(this);
            frmKorisnik.Visible = false;
            frmDodajKomponente.ShowDialog();
            frmKorisnik.Visible = true;
        }

        internal void IzmeniUtakmicu(ComboBox cbUtakmice, ComboBox cbRezultat)
        {
            if(cbUtakmice.SelectedIndex == -1 | cbRezultat.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }

            try
            {
                Utakmica izabrana = (Utakmica)cbUtakmice.SelectedItem;
                Utakmica u = new Utakmica
                {
                    UtakmicaID = izabrana.UtakmicaID,
                    RezultatUtakmice = (string)cbRezultat.SelectedItem,
                };
                StavkaTiketa st = new StavkaTiketa();
                st.Rezultat = u.RezultatUtakmice;
                foreach (StavkaTiketa stavka in listaStavki)
                {
                    if(st.Rezultat == stavka.Rezultat)
                    {
                        stavka.Status = Status.Dobitan;
                    }
                }
                

                Komunikacija.Komunikacija.Instanca.IzmeniUtakmicu(u);
                MessageBox.Show("Sistem je zapamtio rezultat utakmice.");

                PopuniVrednostiZaUtamice(cbUtakmice, cbRezultat);
                

            }
            catch (SistemskaOperacijaException ex)
            {
                MessageBox.Show("Sistem nije uspeo da sacuva rezultat utakmice\n" + ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Sistem nije uspeo da sacuva rezultat utakmice\n" + ex.Message);
            }
        }

        private List<string> ListaMogucihRezultata = new List<string>()
        {
            "Tim 1 pobedjuje",
            "Nerešeno",
            "Tim 2 pobedjuje"
        };
        internal void PopuniVrednostiZaUtamice(ComboBox cbUtakmice, ComboBox cbRezultat)
        {
            Utakmica u = new Utakmica();
            u.uslov = $"u.RezultatUtakmice = '' OR u.RezultatUtakmice IS NULL";
            cbUtakmice.DataSource = Komunikacija.Komunikacija.Instanca.UcitajUtakmice(u);
            cbUtakmice.SelectedIndex = -1;
            cbRezultat.DataSource = ListaMogucihRezultata;
            cbRezultat.SelectedIndex = -1;

        }

        internal void OtvoriFrmIzmeniUtakmice(FrmAdministrator frmAdministrator)
        {
            FrmIzmeniUtakmice frmIzmeniUtakmice = new FrmIzmeniUtakmice(this);
            frmAdministrator.Visible = false;
            frmIzmeniUtakmice.ShowDialog();
            frmAdministrator.Visible = true;
        }

        internal void UcitajStavkeTiketa(DataGridView dgvStavkeTiketa,Tiket izabraniTiket)
        {
            StavkaTiketa st = new StavkaTiketa();
            st.uslov = $"st.TiketID = {izabraniTiket.TiketID}";
            dgvStavkeTiketa.DataSource = Komunikacija.Komunikacija.Instanca.UcitajStavkeTiketa(st);

        }

        internal void OtvoriTiketInformacije(FrmSviTiketi frmSviTiketi,Tiket izabraniTiket)
        {
            FrmInformacijeTiket frmInformacije = new FrmInformacijeTiket(this, izabraniTiket);
            frmInformacije.ShowDialog();
        }

        internal void OtvoriFrmSviTiketi(FrmKorisnik frmKorisnik)
        {
            FrmSviTiketi frmSviTiketi = new FrmSviTiketi(this);
            frmKorisnik.Visible = false;
            frmSviTiketi.ShowDialog();
            frmKorisnik.Visible = true;
        }

        public List<Tiket> nadjeniTiketi = new List<Tiket>();

        internal void UcitajTikete(DataGridView dgvSviTiketi)
        {
            Tiket t = new Tiket();
            t.uslov = $"t.KorisnikID = {ulogovaniKorisnik.KorisnikID}";
            nadjeniTiketi = Komunikacija.Komunikacija.Instanca.UcitajTikete(t);

            if (nadjeniTiketi.Count == 0)
            {
                MessageBox.Show("Trenutno nemate odigrane tikete.");
                return;
            }
            else
            {
                dgvSviTiketi.DataSource = nadjeniTiketi;
            }
        }

        internal void AzurirajIsplatu(TextBox txtIsplata, TextBox txtUplata, TextBox txtKvota)
        {
            if(double.TryParse(txtUplata.Text, out double _))
                txtIsplata.Text = (Convert.ToDouble(txtUplata.Text) * Convert.ToDouble(txtKvota.Text)).ToString();
        }

        internal void SacuvajTiket(TextBox txtUplata, TextBox txtDatumUplate,TextBox txtKvota, TextBox txtPotencijalnaIsplata, DataGridView dgvStavkeTiketa)
        {
            try
            {
                Tiket tiket = new Tiket();
                tiket.Uplata = Convert.ToDouble(txtUplata.Text);
                tiket.DatumUplate = DateTime.Now;
                tiket.PotencijalnaIsplata = Convert.ToDouble(txtPotencijalnaIsplata.Text);
                tiket.StatusT = Status.Dodat;
                tiket.Korisnik=new Korisnik();
                tiket.Korisnik.KorisnikID = ulogovaniKorisnik.KorisnikID;
                StavkaTiketa s=new StavkaTiketa();
                tiket.StavkeTiketa = listaStavki.ToList();
                
                foreach (var st in tiket.StavkeTiketa)
                {
                    s.Tiket = tiket;
                    s.Rezultat = st.Rezultat;
                    s.IzabranaKvota = st.IzabranaKvota;
                    s.Status = st.Status;
                    s.Utakmica = new Utakmica();
                    s.Utakmica.UtakmicaID = st.Utakmica.UtakmicaID;
                }

                Komunikacija.Komunikacija.Instanca.SacuvajTiket(tiket);
                MessageBox.Show("Sistem je zapamtio tiket.");
                OcistiFormu(txtUplata, txtKvota, txtPotencijalnaIsplata, dgvStavkeTiketa);
            }
            catch (SistemskaOperacijaException ex)
            {
                MessageBox.Show("Sistem ne može da zapamti tiket. \n"+ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Sistem ne može da zapamti tiket. \n" + ex.Message);
            }
        }

        private void OcistiFormu(TextBox txtUplata,TextBox txtKvota,TextBox txtIsplata,DataGridView dgvStavke)
        {
            txtUplata.Text = "";
            txtKvota.Text = "1";
            txtIsplata.Text = "";
            listaStavki = new BindingList<StavkaTiketa>();
            dgvStavke.DataSource = listaStavki;
        }

        internal void ObrisiStavkuTiketa(DataGridView dgvStavkeTiketa,TextBox txtUplata,TextBox txtIsplata, TextBox txtKvota)
        {
            StavkaTiketa s = dgvStavkeTiketa.SelectedRows[0].DataBoundItem as StavkaTiketa;            
            listaStavki.Remove(s);
            double kvota = s.IzabranaKvota;
            //Nije dobar nacin racunanja
            //iznosIsplate -= Convert.ToDouble(txtUplata.Text) * kvota;
            txtKvota.Text = Math.Round((Convert.ToDouble(txtKvota.Text) / kvota),2).ToString();
            txtIsplata.Text = Math.Round((Convert.ToDouble(txtUplata.Text) * Convert.ToDouble(txtKvota.Text)),2).ToString();
        }

        //private double iznosIsplate = 0;
        internal void DodajNovuStavku(DataGridView dgvStavkeTiketa,DataGridView dgvUtakmica,TextBox txtUplata,TextBox txtIsplata,TextBox txtKvota)
        {
            if(!UserControlsHelp.PraznoPoljeValidacija(txtUplata) )
            {
                MessageBox.Show("Unesite iznos uplate");
                return;
            }
            if (!UserControlsHelp.DoubleValidacija(txtUplata))
            {
                MessageBox.Show("Iznos ne sme biti negativan i  mora biti bar 50 dinara");
                return;
            }

            int selectedrowindex = dgvUtakmica.SelectedCells[0].RowIndex;
            int selectedcolindex = dgvUtakmica.SelectedCells[0].ColumnIndex;
            DataGridViewRow selectedRow = dgvUtakmica.Rows[selectedrowindex];
           
            Utakmica u = selectedRow.DataBoundItem as Utakmica;

            

            StavkaTiketa st = new StavkaTiketa();
            st.Utakmica = new Utakmica();
            st.Utakmica.Domacin = u.Domacin;
            st.Utakmica.Gost = u.Gost;
            st.Utakmica.UtakmicaID = u.UtakmicaID;
            st.Status = Status.Dodat;         
            if (selectedcolindex == 2)
                ObradiIzabranuKvotu(st, "Tim 1 pobedjuje", Convert.ToDouble(selectedRow.Cells[2].Value));
            else if (selectedcolindex == 3)
                ObradiIzabranuKvotu(st, "Nerešeno", Convert.ToDouble(selectedRow.Cells[3].Value));
            else if (selectedcolindex == 4)
                ObradiIzabranuKvotu(st, "Tim 2 pobedjuje", Convert.ToDouble(selectedRow.Cells[4].Value));
            else
            {
                MessageBox.Show("Izaberite kvotu!");
                return;
            }

            if (!listaStavki.Any(s=>(st.Utakmica.Domacin == s.Utakmica.Domacin) && (st.Utakmica.Gost == s.Utakmica.Gost)))
            {
                //Nije dobar nacin racunanja 
                //iznosIsplate += Convert.ToDouble(txtUplata.Text) * st.IzabranaKvota;
                txtKvota.Text = Math.Round((Convert.ToDouble(txtKvota.Text) * st.IzabranaKvota),2).ToString();
                listaStavki.Add(st);
                txtIsplata.Text = Math.Round((Convert.ToDouble(txtUplata.Text) * Convert.ToDouble(txtKvota.Text)),2).ToString();
            }
            else
            {
                MessageBox.Show("Vec ste izabrali ovu utakmicu");
            }


            
        }

        private void ObradiIzabranuKvotu(StavkaTiketa st,string rezultat,double kvota)
        {
            st.Rezultat = rezultat;
            st.IzabranaKvota = kvota;
        }

        private BindingList<StavkaTiketa> listaStavki = new BindingList<StavkaTiketa>();
        internal void PopuniPolja(TextBox txtDatumUplate,DataGridView dgvStavkeTiketa)
        {
            txtDatumUplate.Text = DateTime.Now.ToString("dd.MM.yyyy.");
            dgvStavkeTiketa.DataSource = listaStavki;


        }

        internal void UcitajUtakmice(DataGridView dgvUtakmice)
        {
            Utakmica u = new Utakmica();
            u.uslov = $"u.RezultatUtakmice = '' OR u.RezultatUtakmice IS NULL";
            dgvUtakmice.DataSource = new BindingList<Utakmica>(Komunikacija.Komunikacija.Instanca.UcitajUtakmice(u));
        }

        internal void OtvoriFrmKreirajTiket(FrmKorisnik frmKorisnik)
        {
            FrmKreirajTiket frmKreirajTiket = new FrmKreirajTiket(this);
            listaStavki = new BindingList<StavkaTiketa>();
            frmKorisnik.Visible = false;
            frmKreirajTiket.ShowDialog();
            frmKorisnik.Visible = true;
        }

        private void OcistiPolja(TextBox txtNazivDrzave, TextBox txtVremePocetka, TextBox txtKvota1,TextBox txtKvotaX,TextBox txtKvota2 ,ComboBox cbDomacin, ComboBox cbGost, ComboBox cbGrad, ComboBox cbVrstaUtakmice)
        {
            txtKvota1.Text = "";
            txtKvotaX.Text = "";
            txtKvota2.Text = "";
            txtNazivDrzave.Text = "";
            txtVremePocetka.Text = "";
            cbDomacin.SelectedIndex = -1;
            cbGost.SelectedIndex = -1;
            cbGrad.SelectedIndex = -1;
            cbVrstaUtakmice.SelectedIndex = -1;
        }

        internal void UnesiUtakmicu(TextBox txtNazivDrzave, TextBox txtVremePocetka, TextBox txtKvota1,TextBox txtKvotaX,TextBox txtKvota2, ComboBox cbDomacin, ComboBox cbGost, ComboBox cbGrad, ComboBox cbVrstaUtakmice)
        {
            if(!UserControlsHelp.PraznoPoljeValidacija(txtKvota1) | !UserControlsHelp.PraznoPoljeValidacija(txtKvotaX) | !UserControlsHelp.PraznoPoljeValidacija(txtKvota2) | !UserControlsHelp.PraznoPoljeValidacija(txtVremePocetka) | !UserControlsHelp.PraznoPoljeValidacija(txtNazivDrzave) | cbDomacin.SelectedIndex == -1 | cbGost.SelectedIndex == -1 | cbGrad.SelectedIndex == -1 | cbVrstaUtakmice.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }
            if(!UserControlsHelp.KvotaValidacija(txtKvota1) | !UserControlsHelp.KvotaValidacija(txtKvotaX) | !UserControlsHelp.KvotaValidacija(txtKvota2))
            {
                MessageBox.Show("Kvota moze biti u intervalu od 1 do 10.");
                return;
            }
            if (!UserControlsHelp.DatumVremeValidacija(txtVremePocetka))
            {
                MessageBox.Show("Datum treba biti u formatu yyyy.MM.dd HH:mm ");
                return;

            }
            
            try
            {
                Utakmica utakmica = new Utakmica
                {
                    NazivDrzave = txtNazivDrzave.Text,
                    Kvota1 = double.Parse(txtKvota1.Text, NumberStyles.Any, CultureInfo.CurrentCulture),
                    KvotaX = double.Parse(txtKvotaX.Text, NumberStyles.Any, CultureInfo.CurrentCulture),
                    Kvota2 = double.Parse(txtKvota2.Text, NumberStyles.Any, CultureInfo.CurrentCulture),
                VremePocetka = DateTime.ParseExact(txtVremePocetka.Text, "dd.MM.yyyy HH:mm", null),
                    Domacin = new Klub
                    {
                        KlubID = ((Klub)cbDomacin.SelectedItem).KlubID
                    },
                    Gost = new Klub
                    {
                        KlubID = ((Klub)cbGost.SelectedItem).KlubID
                    },
                    
                    Grad = new Grad
                    {
                        GradID = ((Grad)cbGrad.SelectedItem).GradID
                    },
                    VrstaUtakmice = (VrstaUtakmice)cbVrstaUtakmice.SelectedItem,
                };
                if(utakmica.Domacin.KlubID == utakmica.Gost.KlubID)
                {
                    MessageBox.Show("Ne moze biti isti domacin i gost");
                    return;
                }
                Komunikacija.Komunikacija.Instanca.UnesiUtakmicu(utakmica);
                MessageBox.Show("Sistem je zapamtio novu utakmicu");
                OcistiPolja(txtNazivDrzave, txtVremePocetka, txtKvota1, txtKvotaX, txtKvota2, cbDomacin, cbGost, cbGrad, cbVrstaUtakmice);
            }
            catch (SistemskaOperacijaException ex)
            {
                MessageBox.Show("Sistem ne može da zapamti novu utakmicu \n" + ex.Message);
            }
            catch(ServerException ex)
            {
                MessageBox.Show("Sistem ne može da zapamti novu utakmicu \n" + ex.Message);
            }

        }

        internal void ucitajVrsteUtakmica(ComboBox cbVrstaUtakmice)
        {
            cbVrstaUtakmice.DataSource = Enum.GetValues(typeof(VrstaUtakmice));
            cbVrstaUtakmice.SelectedIndex = -1;
        }

        internal void UcitajKlubove(ComboBox cbDomacin,ComboBox cbGost)
        {
            cbDomacin.DataSource = Komunikacija.Komunikacija.Instanca.VratiKlubove();
            cbGost.DataSource = Komunikacija.Komunikacija.Instanca.VratiKlubove();
            cbDomacin.SelectedIndex = -1;
            cbGost.SelectedIndex = -1;

        }

        internal void UcitajGradove(ComboBox cbGrad)
        {
            cbGrad.DataSource = Komunikacija.Komunikacija.Instanca.VratiGradove();
            cbGrad.SelectedIndex = -1;
        }

        internal void OtvoriFrmDodajUtakmicu(FrmAdministrator frmAdministrator)
        {
            FrmDodajUtakmicu frmDodajUtakmicu = new FrmDodajUtakmicu(this);
            frmAdministrator.Visible = false;
            frmDodajUtakmicu.ShowDialog();
            frmAdministrator.Visible = true;
        }

        internal void OtvoriFrmKorisnici(FrmAdministrator frmAdministrator)
        {          
            FrmKorisnici frmKorisnici = new FrmKorisnici(this);
            frmAdministrator.Visible = false;
            frmKorisnici.ShowDialog();
            frmAdministrator.Visible = true;
        
        }

        internal void OtvoriInformacije(Form frmAdministrator,Korisnik izabraniKorisnik)
        {
            FrmInfoKorisnik frmInformacije = new FrmInfoKorisnik(this,izabraniKorisnik);
            frmInformacije.ShowDialog();
        }

        internal void PretraziTikete(TextBox txtPretrazi, DataGridView dgvSviTiketi)
        {
            if (!UserControlsHelp.PraznoPoljeValidacija(txtPretrazi))
            {
                MessageBox.Show("Unesite kriterijum pretrage!");
                return;
            }
            Tiket t = new Tiket();
            if (int.TryParse(txtPretrazi.Text, out int result))
            {
                t.uslov= $"t.KorisnikID = {ulogovaniKorisnik.KorisnikID} AND (t.Uplata = '{txtPretrazi.Text}'" +
                $" OR t.PotencijalnaIsplata = '{txtPretrazi.Text}'" +
                $" OR YEAR(t.DatumUplate) LIKE {result}" +
                $" OR DAY(t.DatumUplate) LIKE {result}" +
                $" OR MONTH(t.DatumUplate) LIKE {result}" +
                $" OR YEAR(t.DatumUplate) LIKE {result})";
            }
            else
            {
                t.uslov= $"t.KorisnikID = {ulogovaniKorisnik.KorisnikID} AND t.Status LIKE '{txtPretrazi.Text}%'";
            }
            nadjeniTiketi = Komunikacija.Komunikacija.Instanca.PretraziTikete(t);

            if (nadjeniTiketi.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe tikete po zadatoj vrednosti.");
                txtPretrazi.Text = "";
                return;
            }
            else
            {
                dgvSviTiketi.DataSource = nadjeniTiketi;
                MessageBox.Show("Sistem je našao tikete po zadatoj vrednosti.");

            }
        }

        public List<Korisnik> nadjeniKorisnici = new List<Korisnik>();
        internal void PretraziKorisnike(TextBox txtPretrazi, DataGridView dgvKorisnici)
        {
            if (!UserControlsHelp.PraznoPoljeValidacija(txtPretrazi))
            {
                MessageBox.Show("Unesite kriterijum pretrage!");
                return;
            }
            Korisnik k = new Korisnik();
            

            if (int.TryParse(txtPretrazi.Text, out int result))
                k.uslov = $"k.Godine = '{txtPretrazi.Text}'";
            else
            {
                k.uslov = $"k.Ime LIKE '{txtPretrazi.Text}%' " + $"OR k.Prezime LIKE '{txtPretrazi.Text}%'";
            }


            nadjeniKorisnici = Komunikacija.Komunikacija.Instanca.PretraziKorisnike(k);

            if(nadjeniKorisnici.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe korisnike po zadatoj vrednosti.");
                txtPretrazi.Text = "";
                return;
            }
            else
            {
                dgvKorisnici.DataSource = nadjeniKorisnici;
                MessageBox.Show("Sistem je našao korisnike po zadatoj vrednosti.");
                
            }

        }

        internal void UcitajKorisnike(DataGridView dgvKorisnici)
        {
            dgvKorisnici.DataSource = new BindingList<Korisnik>(Komunikacija.Komunikacija.Instanca.UcitajKorisnike());
        }

        public void IzmeniKorisnickiNalog(TextBox txtIme, TextBox txtPrezime, TextBox txtGodine, TextBox txtKorisnickoIme, TextBox txtLozinka)
        {
            if (!UserControlsHelp.PraznoPoljeValidacija(txtKorisnickoIme) | !UserControlsHelp.PraznoPoljeValidacija(txtLozinka))
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }
            try
            {
                Korisnik korisnik = new Korisnik
                {

                    KorisnikID=ulogovaniKorisnik.KorisnikID,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Godine = Convert.ToInt32(txtGodine.Text),
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                };
                Komunikacija.Komunikacija.Instanca.IzmeniKorisnickiNalog(korisnik);
                MessageBox.Show("Sistem je uspešno promenio vaše podatke.");

            }
            catch (SistemskaOperacijaException ex)
            {
                MessageBox.Show("Sistem nije uspeo da promeni podatke\n" + ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Sistem nije uspeo da promeni podatke\n" + ex.Message);
            }
        }

        internal void OtvoriFormuIzmenaKorisnickogNaloga(FrmKorisnik frmKorisnik)
        {
            FrmIzmenaNaloga frmIzmenaNaloga = new FrmIzmenaNaloga(this);
            frmKorisnik.Visible = false;
            frmIzmenaNaloga.ShowDialog();
            frmKorisnik.Visible = true;

        }

    }
}
