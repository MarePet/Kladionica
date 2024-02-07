using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class StavkaTiketa : IObjekat
    {
        [Browsable(false)]
        public int StavkaID { get; set; }
        public Utakmica Utakmica { get; set; }

       //[Browsable(false)]
        //public string DomacinVsGost { get; set; }
        public string Rezultat { get; set; }
        [DisplayName("Kvota")]
        public double IzabranaKvota { get; set; }

        public Status Status { get; set; }
        [Browsable(false)]
        public Tiket Tiket { get; set; }
        [Browsable(false)]
        public string TabelaNaziv => "StavkaTiketa";
        [Browsable(false)]
        public string WhereUslov => $"StavkaID = {StavkaID} AND UtakmicaID = {Utakmica.UtakmicaID}";
        [Browsable(false)]
        public string InsertVrednosti => $"{StavkaID},'{Rezultat}',{IzabranaKvota.ToString().Replace(',', '.')},'{Status}',{Utakmica.UtakmicaID},{Tiket.TiketID}";
        [Browsable(false)]
        public string Id => "StavkaID";
        [Browsable(false)]
        public string JoinUslov => "ON (st.TiketID=t.TiketID) JOIN Utakmica u ON (st.UtakmicaID=u.UtakmicaID) JOIN Klub d ON (u.DomacinID=d.KlubID) JOIN Klub g ON (u.GostID=g.KLubID)";
        [Browsable(false)]
        public string JoinTabela => "JOIN Tiket t";
        [Browsable(false)]
        public string TabelaAlijas => "st";
        [Browsable(false)]
        public object SelectVrednosti => "st.StavkaID,st.Rezultat,st.IzabranaKvota,st.Status,d.NazivKluba,g.NazivKluba,t.TiketID";
        [Browsable(false)]
        public string UpdateVrednosti => $"Status = '{Status}'";
        public string uslov;
        [Browsable(false)]
        public string GlavniUslov => $"{uslov}";
        private int KonvertujEnum(string status)
        {
            if (status == "Dodat")
            {
                return 0;
            }
            else if(status == "Dobitan")
            {
                return 1;
            }
            return 2;
        }
        public List<IObjekat> VratiObjekte(SqlDataReader reader)
        {
            List<IObjekat> rezultat = new List<IObjekat>();
            while (reader.Read())
            {
                rezultat.Add(new StavkaTiketa
                {
                    StavkaID = (int)reader[0],
                    Rezultat = (string)reader[1],
                    IzabranaKvota = (double)reader[2],
                    Status = (Status)KonvertujEnum(reader[3].ToString()),
                    Utakmica = new Utakmica
                    {
                        Domacin = new Klub
                        {
                            NazivKluba = reader[4].ToString(),
                        },
                        Gost = new Klub
                        {
                            NazivKluba = reader[5].ToString(),
                        }
                    },
                    Tiket = new Tiket()
                    {
                        TiketID = (int)reader[6],
                    }

                });
            }
            return rezultat;
        }
    }
}
