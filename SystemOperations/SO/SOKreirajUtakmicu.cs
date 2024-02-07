using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOKreirajUtakmicu : SistemskeOperacijeGlavno
    {
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            repozitorijum.Sacuvaj(objekat);
        }
    }
}
