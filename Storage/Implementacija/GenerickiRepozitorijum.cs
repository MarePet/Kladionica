using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementacija
{
    public class GenerickiRepozitorijum : IGenerickiRepozitorijum
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Izmeni(IObjekat objekat)
        {
            broker.Izmeni(objekat);
        }

        public void Obrisi(IObjekat objekat)
        {
            broker.Obrisi(objekat);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Sacuvaj(IObjekat objekat)
        {
            broker.Sacuvaj(objekat);
        }

        public int VratiNoviId(IObjekat objekat)
        {
            return broker.VratiNoviId(objekat);
        }

        public List<IObjekat> VratiSve(IObjekat objekat)
        {
            return broker.VratiSve(objekat);
        }

        public List<IObjekat> VratiSveUslov(IObjekat objekat)
        {
            return broker.VratiSveUslov(objekat);
        }
    }
}
