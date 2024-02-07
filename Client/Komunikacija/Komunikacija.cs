using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.Komunikacija
{
    public class Komunikacija
    {
        private Socket soket;
        private KomunikacijaKlijent klijent;
        private static Komunikacija instanca;
        public static Komunikacija Instanca
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new Komunikacija();
                }
                return instanca;
            }
        }
        private Komunikacija()
        {

        }

        public void PoveziSe()
        {
            if(soket!=null && soket.Connected)
            {
                return;
            }
            soket=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Connect("127.0.0.1", 9999);
            klijent = new KomunikacijaKlijent(soket);
        }

        public void OtkaciSe()
        {
            soket.Close();
            soket = null;
        }

        internal Korisnik Login(string korisnickoIme,string lozinka)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.Login,
                ZahtevObjekat = new Korisnik
                {
                    KorisnickoIme = korisnickoIme,
                    Lozinka = lozinka
                }
            };
            klijent.PosaljiZahtev(zahtev);
            return (Korisnik)klijent.VratiRezultatOdgovora();
        }

        

        internal Administrator LoginAdministrator(string korisnickoIme, string lozinka)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.LoginAdmin,
                ZahtevObjekat = new Administrator
                {
                    KorisnickoIme = korisnickoIme,
                    Lozinka = lozinka
                }
            };
            klijent.PosaljiZahtev(zahtev);
            return (Administrator)klijent.VratiRezultatOdgovora();
        }

        internal void KreirajKorisnickiNalog(Korisnik korisnik)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.KreirajKorisnickiNalog,
                ZahtevObjekat = korisnik
            };
            klijent.PosaljiZahtev(zahtev);
            klijent.VratiRezultatOdgovora();
        }

        internal void SacuvajKomponente(RacunarskaKomponenta rk)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.SacuvajKomponentu,
                ZahtevObjekat = rk
            };
            klijent.PosaljiZahtev(zahtev);
            klijent.VratiRezultatOdgovora();
        }

        internal List<StavkaTiketa> UcitajStavkeTiketa(StavkaTiketa st)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UcitajStavkeTiketa,
                ZahtevObjekat = st

            };
            klijent.PosaljiZahtev(zahtev);
            return (List<StavkaTiketa>)klijent.VratiRezultatOdgovora();
        }

        internal void IzmeniUtakmicu(Utakmica u)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.IzmeniUtakmicu,
                ZahtevObjekat = u
            };
            klijent.PosaljiZahtev(zahtev);
            klijent.VratiRezultatOdgovora();
        }

        

        internal List<Utakmica> UcitajUtakmice(Utakmica u)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UcitajUtakmice,
                ZahtevObjekat = u
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<Utakmica>)klijent.VratiRezultatOdgovora();
        }

        internal List<Tiket> UcitajTikete(Tiket t)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UcitajSveTikete,
                ZahtevObjekat = t
                
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<Tiket>)klijent.VratiRezultatOdgovora();
        }

        internal List<RacunarskaKomponenta> VratiKomponente()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.VratiKomponente
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<RacunarskaKomponenta>)klijent.VratiRezultatOdgovora();
        }

        internal List<Klub> VratiKlubove()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.VratiKlubove
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<Klub>)klijent.VratiRezultatOdgovora();
        }

        internal List<Grad> VratiGradove()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.VratiGradove
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<Grad>)klijent.VratiRezultatOdgovora();
        }

        internal List<Korisnik> UcitajKorisnike()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UcitajKorisnike,
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<Korisnik>)klijent.VratiRezultatOdgovora();
        }

        internal void SacuvajTiket(Tiket tiket)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.KreirajTiket,
                ZahtevObjekat = tiket
            };
            klijent.PosaljiZahtev(zahtev);
            klijent.VratiRezultatOdgovora();
        }

        internal List<Korisnik> PretraziKorisnike(Korisnik k)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.PretraziKorisnike,
                ZahtevObjekat = k
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<Korisnik>)klijent.VratiRezultatOdgovora();
        }

        internal void IzmeniKorisnickiNalog(Korisnik korisnik)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.IzmeniKorisnickiNalog,
                ZahtevObjekat = korisnik
            };
            klijent.PosaljiZahtev(zahtev);
            klijent.VratiRezultatOdgovora();
        }

        internal void UnesiUtakmicu(Utakmica utakmica)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UnesiUtakmicu,
                ZahtevObjekat = utakmica
            };
            klijent.PosaljiZahtev(zahtev);
            klijent.VratiRezultatOdgovora();
        }

        internal List<Tiket> PretraziTikete(Tiket t)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.PretraziTikete,
                ZahtevObjekat = t
            };
            klijent.PosaljiZahtev(zahtev);
            return (List<Tiket>)klijent.VratiRezultatOdgovora();
        }
    }
}
