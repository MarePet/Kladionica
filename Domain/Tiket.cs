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
    public class Tiket : IObjekat
    {
        [Browsable(false)]
        public int TiketID { get; set; }
        public DateTime DatumUplate { get; set; }
        public double Uplata { get; set; }

        public double PotencijalnaIsplata { get; set; }
        public Status StatusT { get; set; }
        [Browsable(false)]
        public Korisnik Korisnik { get; set; }

        [Browsable(false)]
        public List<StavkaTiketa> StavkeTiketa { get; set; }
        [Browsable(false)]
        public string TabelaNaziv => "Tiket";
        [Browsable(false)]
        public string WhereUslov => $"TiketID = {TiketID}";
        [Browsable(false)]
        public string InsertVrednosti => $"{Uplata}, {PotencijalnaIsplata.ToString().Replace(',', '.')}, '{DatumUplate.ToString("yyyy.MM.dd HH:mm")}','{StatusT}',{Korisnik.KorisnikID}";
        [Browsable(false)]
        public string Id => "TiketID";
        [Browsable(false)]
        public string JoinUslov => "ON(t.KorisnikID=k.KorisnikID)";
        [Browsable(false)]
        public string JoinTabela => "JOIN Korisnik k";
        [Browsable(false)]
        public string TabelaAlijas => "t";
        [Browsable(false)]
        public object SelectVrednosti => "t.TiketID,t.DatumUplate,t.Uplata,t.PotencijalnaIsplata,t.StatusTiketa,k.Ime";
        [Browsable(false)]
        public string UpdateVrednosti => $"StatusTiketa = '{StatusT}'";
        public string uslov;
        [Browsable(false)]
        public string GlavniUslov => $"{uslov}";
        private int KonvertujEnum(string status)
        {
            if (status == "Dodat")
            {
                return 0;
            }
            else if (status == "Dobitan")
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
                rezultat.Add(new Tiket
                {
                    TiketID = (int)reader[0],
                    DatumUplate = Convert.ToDateTime(reader[1]),
                    Uplata = (double)reader[2],
                    PotencijalnaIsplata = (double)reader[3],
                    StatusT = (Status)KonvertujEnum(reader[4].ToString()),
                    Korisnik = new Korisnik
                    {
                        //KorisnikID = (int)reader[],
                        Ime = (string)reader[5],
                        //Prezime = (string)reader[8],
                        //Godine = (int)reader[9],
                        //KorisnickoIme = (string)reader[4],
                        //Lozinka = (string)reader[11]
                    },
                });
            }
            return rezultat;
        }
    }
}
