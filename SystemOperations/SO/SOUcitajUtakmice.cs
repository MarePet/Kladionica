using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOUcitajUtakmice : SistemskeOperacijeGlavno
    {
        public List<Utakmica> listaUtakmica { get; private set; }

        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            listaUtakmica = repozitorijum.VratiSveUslov(objekat).Cast<Utakmica>().ToList();

        }
    }
}
