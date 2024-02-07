using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOKreirajTiket : SistemskeOperacijeGlavno
    {
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            Tiket t = (Tiket)objekat;

            repozitorijum.Sacuvaj(t);
            int TiketId = repozitorijum.VratiNoviId(new Tiket()) - 1;
            foreach (StavkaTiketa st in t.StavkeTiketa)
            {
                int id = repozitorijum.VratiNoviId(new StavkaTiketa());
                st.StavkaID = id;
                st.Tiket = t;
                st.Tiket.TiketID = TiketId;
                repozitorijum.Sacuvaj(st);
            }
        }
    }
}
