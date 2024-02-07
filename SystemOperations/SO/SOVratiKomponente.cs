using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.SO
{
    public class SOVratiKomponente : SistemskeOperacijeGlavno
    {
        public List<RacunarskaKomponenta> listaKomponenti { get; private set; }

        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            listaKomponenti = repozitorijum.VratiSve(new RacunarskaKomponenta()).Cast<RacunarskaKomponenta>().ToList();

        }
    }
}
