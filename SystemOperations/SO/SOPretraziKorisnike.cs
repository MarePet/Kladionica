using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOPretraziKorisnike : SistemskeOperacijeGlavno
    {
        public List<Korisnik> listaKorisnika { get; private set; }
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            listaKorisnika = repozitorijum.VratiSveUslov(objekat).Cast<Korisnik>().ToList();
        }
    }
}
