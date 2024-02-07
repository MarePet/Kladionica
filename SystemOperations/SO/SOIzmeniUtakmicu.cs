using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SO
{
    public class SOIzmeniUtakmicu : SistemskeOperacijeGlavno
    {
        protected override void IzvrsiOperaciju(IObjekat objekat)
        {
            Utakmica utakmica = (Utakmica)objekat;
            repozitorijum.Izmeni(utakmica);

            StavkaTiketa st = new StavkaTiketa();
            st.uslov = $"st.UtakmicaID = {utakmica.UtakmicaID}";

            //vrati sve stavke koje sadrze promenjenu utakmicu
            List<StavkaTiketa> listaStavkiSaPromenjenomUtakmicom = repozitorijum.VratiSveUslov(st).Cast<StavkaTiketa>().ToList();
            
            
            List<Tiket> listaSvihTiketa = repozitorijum.VratiSve(new Tiket()).Cast<Tiket>().ToList();

            //promeni status na stavci i tiketu
            foreach (var s in listaStavkiSaPromenjenomUtakmicom)
            {
                s.Utakmica = new Utakmica();
                s.Utakmica.UtakmicaID = utakmica.UtakmicaID;
                if(s.Rezultat == utakmica.RezultatUtakmice)
                    s.Status = Status.Dobitan;
                else
                    s.Status = Status.Gubitan;

                repozitorijum.Izmeni(s);
                Tiket tiket = listaSvihTiketa.FirstOrDefault(tt => tt.TiketID == s.Tiket.TiketID);
                ObradiStatusTiketa(tiket);
                repozitorijum.Izmeni(tiket);
            }


        }

        private void ObradiStatusTiketa(Tiket t)
        {
            StavkaTiketa st = new StavkaTiketa();
            List<StavkaTiketa> listaSvihStavki = repozitorijum.VratiSve(st).Cast<StavkaTiketa>().ToList();

            List<StavkaTiketa> listaPojedinacnogTiketa = new List<StavkaTiketa>();
            foreach (var stavka in listaSvihStavki)
            {
                if(stavka.Tiket.TiketID == t.TiketID)
                {
                    listaPojedinacnogTiketa.Add(stavka);
                }
            }

            if (listaPojedinacnogTiketa.Any(s => s.Status == Status.Gubitan))
                t.StatusT = Status.Gubitan;
            else if (listaPojedinacnogTiketa.All(s => s.Status == Status.Dobitan))
                t.StatusT = Status.Dobitan;
            else
                t.StatusT = Status.Dodat;

        }
    }
}
