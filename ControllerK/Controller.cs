using Domain;
using Storage;
using Storage.Implementacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.SO;

namespace ControllerK
{
    public class Controller
    {
        private IGenerickiRepozitorijum repozitorijum;

        private static Controller instance;

        public Controller()
        {
            repozitorijum = new GenerickiRepozitorijum();
        }
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public Korisnik Login(Korisnik korisnik)
        {
            SOPrijaviKorisnika so=new SOPrijaviKorisnika();
            so.IzvrsiTemplate(korisnik);
            return so.Rezultat;
        }
        public Administrator LoginAdmin(Administrator administrator)
        {
            SOPrijaviAdministratora so = new SOPrijaviAdministratora();
            so.IzvrsiTemplate(administrator);
            return so.Rezultat;
        }

        public void KreirajKorisnickiNalog(Korisnik korisnik)
        {
            SOKreirajKorisnickiNalog so = new SOKreirajKorisnickiNalog();
            so.IzvrsiTemplate(korisnik);
        }

        public void IzmeniKorisnickiNalog(Korisnik korisnik)
        {
            SOIzmeniKorisnickiNalog so = new SOIzmeniKorisnickiNalog();
            so.IzvrsiTemplate(korisnik);
        }

        public List<Korisnik> UcitajKorisnike()
        {
            SOUcitajKorisnike so = new SOUcitajKorisnike();
            so.IzvrsiTemplate(new Korisnik());
            return so.listaKorisnika;
        }

        public object PretraziKorisnike(Korisnik k)
        {
            SOPretraziKorisnike so = new SOPretraziKorisnike();
            so.IzvrsiTemplate(k);
            return so.listaKorisnika;
        }

        public List<Grad> VratiGradove()
        {
            SOUcitajGradove so = new SOUcitajGradove();
            so.IzvrsiTemplate(new Grad());
            return so.listaGradova;
        }

        public List<Klub> VratiKlubove()
        {
            SOUcitajKlubove so = new SOUcitajKlubove();
            so.IzvrsiTemplate(new Klub());
            return so.listaKlubova;
        }

        public void UnesiUtakmicu(Utakmica utakmica)
        {
            SOKreirajUtakmicu so = new SOKreirajUtakmicu();
            so.IzvrsiTemplate(utakmica);
        }

        public List<Utakmica> UcitajUtakmice(Utakmica u)
        {
            SOUcitajUtakmice so = new SOUcitajUtakmice();
            so.IzvrsiTemplate(u);
            return so.listaUtakmica;
        }

        public void KreirajTiket(Tiket tiket)
        {
            SOKreirajTiket so = new SOKreirajTiket();
            so.IzvrsiTemplate(tiket);
        }

        public List<Tiket> UcitajSveTikete(Tiket t)
        {
            SOUcitajTikete so = new SOUcitajTikete();
            so.IzvrsiTemplate(t);
            return so.listaTiketa;
        }

        public object UcitajStavkeTiketa(StavkaTiketa st)
        {
            SOUcitajStavkeTiketa so = new SOUcitajStavkeTiketa();
            so.IzvrsiTemplate(st);
            return so.listaStavkiTiketa;
        }

        public object PretraziTikete(Tiket tiket)
        {
            SOPretraziTikete so = new SOPretraziTikete();
            so.IzvrsiTemplate(tiket);
            return so.listaTiketa;
        }

        public void IzmeniUtakmicu(Utakmica utakmica)
        {
            SOIzmeniUtakmicu so = new SOIzmeniUtakmicu();
            so.IzvrsiTemplate(utakmica);
        }

        public void SacuvajKomponentu(RacunarskaKomponenta rk)
        {
            SOSacuvajRacunarskuKomponentu so = new SOSacuvajRacunarskuKomponentu();
            so.IzvrsiTemplate(rk);
        }

        public object VratiKomponente()
        {
            SOVratiKomponente so = new SOVratiKomponente();
            so.IzvrsiTemplate(new RacunarskaKomponenta());
            return so.listaKomponenti;
        }
    }
}
