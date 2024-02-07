using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IGenerickiRepozitorijum
    {
        void Sacuvaj(IObjekat objekat);
        void Izmeni(IObjekat objekat);
        List<IObjekat> VratiSve(IObjekat objekat);
        int VratiNoviId(IObjekat objekat);
        void Obrisi(IObjekat objekat);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
        List<IObjekat> VratiSveUslov(IObjekat objekat);
    }
}
