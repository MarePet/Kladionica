using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOUcitajGradove : SistemskeOperacijeGlavno
    {
        public List<Grad> listaGradova { get; private set; }

        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            listaGradova = repozitorijum.VratiSve(new Grad()).Cast<Grad>().ToList();
        }
    }
}
