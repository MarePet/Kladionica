using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOPrijaviAdministratora : SistemskeOperacijeGlavno
    {
        public Administrator Rezultat { get; private set; }
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            Administrator a = (Administrator)objekat;

            foreach (Administrator admin in repozitorijum.VratiSve(new Administrator()))
            {
                if(admin.KorisnickoIme==a.KorisnickoIme && admin.Lozinka == a.Lozinka)
                {
                    Rezultat = a;
                }
            }
        }
    }
}
