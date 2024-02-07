using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Grad : IObjekat
    {
        public int GradID { get; set; }
        public string NazivGrada { get; set; }
        public int PTT { get; set; }


        public string TabelaNaziv => "Grad";

        public string WhereUslov => "";

        public string InsertVrednosti => $"'{NazivGrada}',{PTT}";

        public string Id => "GradID";

        public string JoinUslov => "";

        public string JoinTabela => "";

        public string TabelaAlijas => "g";

        public object SelectVrednosti => "*";

        public string UpdateVrednosti => "";

        public string GlavniUslov => "";

        public override string ToString()
        {
            return NazivGrada;
        }
        public List<IObjekat> VratiObjekte(SqlDataReader reader)
        {
            List<IObjekat> rezultat = new List<IObjekat>();
            while (reader.Read())
            {
                rezultat.Add(new Grad
                {
                    GradID = (int)reader[0],
                    NazivGrada = (string)reader[1],
                    PTT = (int)reader[2],
                });
            }
            return rezultat;

        }
    }
}
