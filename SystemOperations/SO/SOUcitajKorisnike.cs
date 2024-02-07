using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOUcitajKorisnike : SistemskeOperacijeGlavno
    {
        public List<Korisnik> listaKorisnika { get; private set; }
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            listaKorisnika = repozitorijum.VratiSve(new Korisnik()).Cast<Korisnik>().ToList();
        }
    }
}
