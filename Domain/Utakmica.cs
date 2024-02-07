using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Utakmica : IObjekat
    {
        [Browsable (false)]
        public int UtakmicaID { get; set; }
        [Browsable(false)]
        public string NazivDrzave { get; set; }
        [DisplayName("Datum i vreme")]
        public DateTime VremePocetka { get; set; }
        [Browsable(false)]
        public Klub Domacin { get; set; }
        [Browsable(false)]
        public Klub Gost { get; set; }
        [DisplayName("Utakmica")]
        public string DomacinVsGost { get { return Domacin.NazivKluba + "-" + Gost.NazivKluba; } }

        [Browsable(false)]
        public VrstaUtakmice VrstaUtakmice { get; set; }
        [Browsable(false)]
        public string RezultatUtakmice { get; set; }
        [DisplayName("Pobednik 1")]
        public double Kvota1 { get; set; }
        [DisplayName("Nerešeno")]
        public double KvotaX { get; set; }
        [DisplayName("Pobednik 2")]
        public double Kvota2 { get; set; }
        [Browsable(false)]
        public Grad Grad { get; set; }
        [Browsable(false)]
        public string TabelaNaziv => "Utakmica";
        [Browsable(false)]
        public string WhereUslov => $"UtakmicaID = {UtakmicaID}";
        [Browsable(false)]

        public string InsertVrednosti => $"'{NazivDrzave}','{VremePocetka.ToString("yyyy.MM.dd HH:mm")}','{VrstaUtakmice}','{RezultatUtakmice}',{Kvota1.ToString().Replace(',','.')},{KvotaX.ToString().Replace(',', '.')},{Kvota2.ToString().Replace(',', '.')},{Domacin.KlubID},{Gost.KlubID},{Grad.GradID}";
        [Browsable(false)]

        public string Id => "UtakmicaID";
        [Browsable(false)]

        public string JoinUslov => "ON(u.DomacinID=d.KlubID) JOIN Klub g ON(u.GostID=g.KlubID)";
        [Browsable(false)]

        public string JoinTabela => "JOIN Klub d";
        [Browsable(false)]

        public string TabelaAlijas => "u";
        [Browsable(false)]

        public object SelectVrednosti => "*";
        [Browsable(false)]

        public string UpdateVrednosti => $"RezultatUtakmice = '{RezultatUtakmice}'";
        [Browsable(false)]
        public string uslov;
        public string GlavniUslov => $"{uslov}";
        private int KonvertujEnumVrstaUtakmice(string vrsta)
        {
            if (vrsta == "Prijateljska")
            {
                return 0;
            }
            return 1;
        }
        public override string ToString()
        {
            return Domacin.NazivKluba + "-" + Gost.NazivKluba;
        }
        public List<IObjekat> VratiObjekte(SqlDataReader reader)
        {
            List<IObjekat> rezultat = new List<IObjekat>();
            while (reader.Read())
            {
                rezultat.Add(new Utakmica
                {
                    UtakmicaID = (int)reader[0],
                    NazivDrzave = (string)reader[1],
                    VremePocetka = Convert.ToDateTime(reader[2]),
                    VrstaUtakmice =  (VrstaUtakmice)KonvertujEnumVrstaUtakmice(reader[3].ToString()),
                    RezultatUtakmice = !reader.IsDBNull(4) ? (string)reader[4]:"",
                    Kvota1 = (double)reader[5],
                    KvotaX = (double)reader[6],
                    Kvota2 = (double)reader[7],
                    Domacin = new Klub
                    {
                        KlubID = (int)reader[8],
                        NazivKluba = (string)reader[12],
                        GodinaOsnivanja = (int)reader[13],
                        Grad = (string)reader[14]
                    },
                    Gost = new Klub
                    {
                        KlubID = (int)reader[9],
                        NazivKluba = (string)reader[16],
                        GodinaOsnivanja = (int)reader[17],
                        Grad = (string)reader[18]
                    },
                    Grad = new Grad
                    {
                        GradID = (int)reader[10]
                    }

                });
                //Utakmica u = new Utakmica();
                //u.UtakmicaID = (int)reader[0];
                //u.NazivDrzave = (string)reader[1];
                //u.VremePocetka = Convert.ToDateTime(reader[2]);
                ////u.VrstaUtakmice = (VrstaUtakmice)reader[3];
                //u.RezultatUtakmice = (string)reader[4];
                //u.Kvota1 = (double)reader[5];
                //u.KvotaX = (double)reader[6];
                //u.Kvota2 = (double)reader[7];
                //rezultat.Add(u);

            }
            return rezultat;
        }
    }
}
