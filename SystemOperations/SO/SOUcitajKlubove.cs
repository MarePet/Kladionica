using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOUcitajKlubove : SistemskeOperacijeGlavno
    {
        public List<Klub> listaKlubova { get; private set; }

        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            listaKlubova = repozitorijum.VratiSve(new Klub()).Cast<Klub>().ToList();

        }
    }
}
