using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOUcitajStavkeTiketa : SistemskeOperacijeGlavno
    {
        public List<StavkaTiketa> listaStavkiTiketa { get; private set; }

        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            listaStavkiTiketa = repozitorijum.VratiSveUslov(objekat).Cast<StavkaTiketa>().ToList();

        }
    }
}
