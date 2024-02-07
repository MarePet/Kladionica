using Common;
using ControllerK;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class KlijentHandler
    {
        private Socket klijent;
        private readonly BindingList<Korisnik> korisnici;
        private readonly BindingList<Administrator> administratori;
        private Korisnik ulogovaniKorisnik;
        private Administrator ulogovaniAdministrator;
        public KlijentHandler(Socket klijent, BindingList<Korisnik> korisnici, BindingList<Administrator> administratori)
        {
            this.klijent = klijent;
            this.korisnici = korisnici;
            this.administratori = administratori;
        }

        public void PokreniHandler()
        {
            try
            {
                NetworkStream tok = new NetworkStream(klijent);
                BinaryFormatter formater = new BinaryFormatter();
                while (true)
                {
                    Zahtev zahtev = (Zahtev)formater.Deserialize(tok);
                    Odgovor odgovor;
                    try
                    {
                        odgovor = ObradiZahteve(zahtev);
                    }
                    catch (Exception ex)
                    {
                        odgovor = new Odgovor();
                        odgovor.Uspesno = false;
                        odgovor.Greska = ex.Message;
                    }
                    formater.Serialize(tok, odgovor);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Došlo je do prekida veze");
                korisnici.Remove(ulogovaniKorisnik);
                if (administratori.Count == 1)
                {
                    administratori.Remove(ulogovaniAdministrator);
                }
            }
            catch (SerializationException)
            {
                Console.WriteLine("Došlo je do prekida veze");
                korisnici.Remove(ulogovaniKorisnik);
                if (administratori.Count == 1)
                {
                    administratori.Remove(ulogovaniAdministrator);
                }
            }
        }

        private Odgovor ObradiZahteve(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Uspesno = true;
            switch (zahtev.Operacija)
            {
                case Operacija.Login:
                    Korisnik k = Controller.Instance.Login((Korisnik)zahtev.ZahtevObjekat);
                    if (k != null)
                    {
                        k.Ulogovan = korisnici.Any(kor => kor.KorisnickoIme == k.KorisnickoIme);
                        ulogovaniKorisnik = k;
                        korisnici.Add(ulogovaniKorisnik);
                    }
                    odgovor.Rezultat = k;
                    break;
                case Operacija.LoginAdmin:
                    if(administratori.Count == 1)
                    {
                        throw new Exception("Samo jedan administrator može biti prijavljen u jednom trenutku!");
                    }
                    else
                    {
                        odgovor.Rezultat = Controller.Instance.LoginAdmin((Administrator)zahtev.ZahtevObjekat);
                        ulogovaniAdministrator = (Administrator)odgovor.Rezultat;
                        if (ulogovaniAdministrator != null)
                        {
                            administratori.Add(ulogovaniAdministrator);
                        }
                    }
                    break;
                case Operacija.KreirajKorisnickiNalog:
                    Controller.Instance.KreirajKorisnickiNalog((Korisnik)zahtev.ZahtevObjekat);
                    break;
                case Operacija.IzmeniKorisnickiNalog:
                    Controller.Instance.IzmeniKorisnickiNalog((Korisnik)zahtev.ZahtevObjekat);
                    break;
                case Operacija.UcitajKorisnike:
                    odgovor.Rezultat = Controller.Instance.UcitajKorisnike();
                    break;
                case Operacija.PretraziKorisnike:
                    odgovor.Rezultat = Controller.Instance.PretraziKorisnike((Korisnik)zahtev.ZahtevObjekat);
                    break;
                case Operacija.VratiGradove:
                    odgovor.Rezultat = Controller.Instance.VratiGradove();
                    break;
                case Operacija.VratiKlubove:
                    odgovor.Rezultat = Controller.Instance.VratiKlubove();
                    break;
                case Operacija.UnesiUtakmicu:
                    Controller.Instance.UnesiUtakmicu((Utakmica)zahtev.ZahtevObjekat);
                    break;
                case Operacija.UcitajUtakmice:
                    odgovor.Rezultat = Controller.Instance.UcitajUtakmice((Utakmica)zahtev.ZahtevObjekat);
                    break;
                case Operacija.KreirajTiket:
                    Controller.Instance.KreirajTiket((Tiket)zahtev.ZahtevObjekat);
                    break;
                case Operacija.UcitajSveTikete:
                    odgovor.Rezultat = Controller.Instance.UcitajSveTikete((Tiket)zahtev.ZahtevObjekat);
                    break;
                case Operacija.UcitajStavkeTiketa:
                    odgovor.Rezultat = Controller.Instance.UcitajStavkeTiketa((StavkaTiketa)zahtev.ZahtevObjekat);
                    break;
                case Operacija.PretraziTikete:
                    odgovor.Rezultat = Controller.Instance.PretraziTikete((Tiket)zahtev.ZahtevObjekat);
                    break;
                case Operacija.IzmeniUtakmicu:
                    Controller.Instance.IzmeniUtakmicu((Utakmica)zahtev.ZahtevObjekat);
                    break;
                case Operacija.SacuvajKomponentu:
                    Controller.Instance.SacuvajKomponentu((RacunarskaKomponenta)zahtev.ZahtevObjekat);
                    break;
                case Operacija.VratiKomponente:
                    odgovor.Rezultat = Controller.Instance.VratiKomponente();
                    break;

            }
            return odgovor;
        }

        internal void Zaustavi()
        {
            klijent.Close();
        }
    }
}
