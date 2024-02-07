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
    public class Administrator : IObjekat
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        [Browsable (false)]
        public string TabelaNaziv => "Administrator";
        [Browsable(false)]
        public string WhereUslov => "";
        [Browsable(false)]
        public string InsertVrednosti => $"'{KorisnickoIme}','{Lozinka}'";
        [Browsable(false)]
        public string Id => "Id";
        [Browsable(false)]
        public string JoinUslov => "";
        [Browsable(false)]
        public string JoinTabela => "";
        [Browsable(false)]
        public string TabelaAlijas => "a";
        [Browsable(false)]
        public object SelectVrednosti => "*";
        [Browsable(false)]
        public string UpdateVrednosti => "*";
        [Browsable(false)]
        public string GlavniUslov => throw new NotImplementedException();

        public List<IObjekat> VratiObjekte(SqlDataReader reader)
        {
            List<IObjekat > rezultat = new List<IObjekat>();
            while (reader.Read())
            {
                rezultat.Add(new Administrator
                {
                    KorisnickoIme = (string)reader[1],
                    Lozinka = (string)reader[2],
                });
            }
            return rezultat;
        }
    }
}
