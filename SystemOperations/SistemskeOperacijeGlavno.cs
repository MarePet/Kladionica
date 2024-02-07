using Domain;
using Storage;
using Storage.Implementacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SistemskeOperacijeGlavno
    {
        protected IGenerickiRepozitorijum repozitorijum;

        public SistemskeOperacijeGlavno()
        {
            repozitorijum = new GenerickiRepozitorijum();
        }

        public void IzvrsiTemplate(IObjekat objekat)
        {
            try
            {
                repozitorijum.OpenConnection();
                repozitorijum.BeginTransaction();
                IzvrsiOperaciju(objekat);
                repozitorijum.Commit();

            }
            catch (Exception)
            {
                repozitorijum.Rollback();
                throw;
            }
            finally
            {
                repozitorijum.CloseConnection();
            }
        }

        protected abstract void IzvrsiOperaciju(IObjekat objekat);

    }
}
