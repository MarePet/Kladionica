using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.SO
{
    public class SOSacuvajRacunarskuKomponentu : SistemskeOperacijeGlavno
    {
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            repozitorijum.Sacuvaj(objekat);
        }
    }
}
