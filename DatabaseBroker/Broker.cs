using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection konekcija;
        private SqlTransaction transakcija;

        public Broker()
        {
            konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Kladionica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public void OpenConnection()
        {
            konekcija.Open();
        }
        public void CloseConnection()
        {
            konekcija.Close();
        }
        public void BeginTransaction()
        {
            transakcija = konekcija.BeginTransaction();
        }
        public void Commit()
        {
            transakcija?.Commit();
        }
        public void Rollback()
        {
            transakcija?.Rollback();
        }
        public List<IObjekat> VratiSve(IObjekat objekat)
        {
            List<IObjekat> result;
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"SELECT {objekat.SelectVrednosti} FROM {objekat.TabelaNaziv} {objekat.TabelaAlijas} {objekat.JoinTabela} {objekat.JoinUslov}";
            SqlDataReader reader = command.ExecuteReader();
            result = objekat.VratiObjekte(reader);
            reader.Close();
            return result;
        }
        public List<IObjekat> VratiSveUslov(IObjekat objekat)
        {
            List<IObjekat> result;
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"SELECT {objekat.SelectVrednosti} FROM {objekat.TabelaNaziv} {objekat.TabelaAlijas} {objekat.JoinTabela} {objekat.JoinUslov} WHERE {objekat.GlavniUslov}";
            SqlDataReader reader = command.ExecuteReader();
            result = objekat.VratiObjekte(reader);
            reader.Close();
            return result;
        }
        public void Sacuvaj(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"INSERT INTO {objekat.TabelaNaziv} VALUES ({objekat.InsertVrednosti})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greška sa bazom!");
            }
        }
        public void Izmeni(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"UPDATE {objekat.TabelaNaziv} SET {objekat.UpdateVrednosti} WHERE {objekat.WhereUslov}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greška sa bazom!");
            };
        }
        public void Obrisi(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"DELETE FROM {objekat.TabelaNaziv} WHERE {objekat.WhereUslov}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greška sa bazom!");
            }
        }
        public int VratiNoviId(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"SELECT MAX({objekat.Id}) FROM {objekat.TabelaNaziv} ";
            object id = command.ExecuteScalar();
            if (id is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)id + 1;
            }
        }
        
    }
}
