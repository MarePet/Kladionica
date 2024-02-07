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
    public class RacunarskaKomponenta : IObjekat
    {
        [Browsable(false)]
        public int KomponentaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Tip { get; set; }

        [Browsable(false)]

        public string TabelaNaziv => "RacunarskaKomponenta";

        [Browsable(false)]
        public string WhereUslov => "";

        [Browsable(false)]
        public string InsertVrednosti => $"'{Naziv}','{Opis}','{Tip}'";

        [Browsable(false)]
        public string Id => $"Id = {KomponentaId}";

        [Browsable(false)]
        public string JoinUslov => "";

        [Browsable(false)]
        public string JoinTabela => "";

        [Browsable(false)]
        public string TabelaAlijas => "";

        [Browsable(false)]
        public object SelectVrednosti => "*";

        [Browsable(false)]
        public string UpdateVrednosti => "";

        [Browsable(false)]
        public string GlavniUslov => "";

        [Browsable(false)]
        public List<IObjekat> VratiObjekte(SqlDataReader reader)
        {
            List<IObjekat> rezultat = new List<IObjekat>();
            while (reader.Read())
            {
                rezultat.Add(new RacunarskaKomponenta
                {
                    KomponentaId = (int)reader[0],
                    Naziv = (string)reader[1],
                    Opis = (string)reader[2],
                    Tip = (string)reader[3],
                });
            }
            return rezultat;
        }
    }
}
