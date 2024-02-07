using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOUcitajTikete : SistemskeOperacijeGlavno
    {
        public List<Tiket> listaTiketa { get; private set; }
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {

            listaTiketa = repozitorijum.VratiSveUslov(objekat).Cast<Tiket>().ToList();
        }
    }
}
