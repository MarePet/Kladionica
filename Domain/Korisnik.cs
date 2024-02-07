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
    public class Korisnik : IObjekat
    {
        [Browsable(false)]
        public int KorisnikID { get; set; }
        [Browsable(false)]
        public string Ime { get; set; }
        [Browsable(false)]
        public string Prezime { get; set; }
        [DisplayName("Ime i prezime")]
        public string ImePrezime => Ime + " " + Prezime;
        public int Godine { get; set; }
        [DisplayName("Korisničko ime")]
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        
        [Browsable(false)]
        public bool Ulogovan { get; set; }


        [Browsable(false)]
        public string TabelaNaziv => "Korisnik";
        [Browsable(false)]
        public string WhereUslov => $"KorisnikID = {KorisnikID}";
        [Browsable(false)]
        public string InsertVrednosti => $"'{Ime}','{Prezime}',{Godine},'{KorisnickoIme}','{Lozinka}'";
        [Browsable(false)]
        public string Id => "KorisnikID";
        [Browsable(false)]
        public string JoinUslov => "";
        [Browsable(false)]
        public string JoinTabela => "";
        [Browsable(false)]
        public string TabelaAlijas => "k";
        [Browsable(false)]
        public object SelectVrednosti => "*";
        [Browsable(false)]
        public string UpdateVrednosti => $"KorisnickoIme='{KorisnickoIme}', Lozinka = '{Lozinka}'";
        [Browsable(false)]
        public string uslov;
        [Browsable(false)]
        public string GlavniUslov => $"{uslov}";

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
                
        }
        public List<IObjekat> VratiObjekte(SqlDataReader reader)
        {
            List<IObjekat> rezultat = new List<IObjekat>();
            while (reader.Read())
            {
                rezultat.Add(new Korisnik
                {
                    KorisnikID = (int)reader[0],
                    Ime = (string)reader[1],
                    Prezime = (string)reader[2],
                    Godine = (int)reader[3],
                    KorisnickoIme = (string)reader[4],
                    Lozinka = (string)reader[5],
                });
            }
            return rezultat;
        }
    }
}
