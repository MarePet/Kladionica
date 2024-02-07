using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOIzmeniKorisnickiNalog : SistemskeOperacijeGlavno
    {
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            repozitorijum.Izmeni(objekat);
        }
    }
}
