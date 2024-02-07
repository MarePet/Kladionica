using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOPrijaviKorisnika : SistemskeOperacijeGlavno
    {
        public Korisnik Rezultat { get; private set; }
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            Korisnik k = (Korisnik)objekat;
            foreach (Korisnik korisnik in repozitorijum.VratiSve(new Korisnik()))
            {
                if(korisnik.KorisnickoIme == k.KorisnickoIme && korisnik.Lozinka == k.Lozinka)
                {
                    Rezultat = korisnik;
                }
            }
        }
    }
}
