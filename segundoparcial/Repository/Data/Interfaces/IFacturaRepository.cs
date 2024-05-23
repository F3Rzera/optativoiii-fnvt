using Repository.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Interfaces
{
    public interface IFacturaRepository
    {
        bool add(FacturaModel facturaModel);
        bool update(FacturaModel facturaModel);
        bool delete(int id);
        IEnumerable<FacturaModel> GetAll();
    }
}
