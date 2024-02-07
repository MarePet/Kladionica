using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IObjekat
    {
        string TabelaNaziv { get; }
        string WhereUslov { get; }
        string InsertVrednosti { get; }
        string Id { get; }
        string JoinUslov { get; }
        string JoinTabela { get; }
        string TabelaAlijas { get; }
        object SelectVrednosti { get; }
        string UpdateVrednosti { get; }
        string GlavniUslov { get; }

        List<IObjekat> VratiObjekte(SqlDataReader reader);
    }
}
