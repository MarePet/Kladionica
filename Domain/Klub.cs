using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Klub : IObjekat
    {
        public int KlubID { get; set; }
        public string NazivKluba { get; set; }
        public int GodinaOsnivanja { get; set; }
        public string Grad { get; set; }

        public string TabelaNaziv => "Klub";

        public string WhereUslov => "";

        public string InsertVrednosti => "";

        public string Id => "KlubID";

        public string JoinUslov => "";

        public string JoinTabela => "";

        public string TabelaAlijas => "k";

        public object SelectVrednosti => "*";

        public string UpdateVrednosti => "";

        public string GlavniUslov => "";

        public override string ToString()
        {
            return NazivKluba;
        }
        public List<IObjekat> VratiObjekte(SqlDataReader reader)
        {
            List<IObjekat> rezultat = new List<IObjekat>();
            while (reader.Read())
            {
                rezultat.Add(new Klub
                {
                    KlubID = (int)reader[0],
                    NazivKluba = (string)reader[1],
                    GodinaOsnivanja = (int)reader[2],
                    Grad = (string)reader[3],

                });
            }
            return rezultat;
        }

    }
}
