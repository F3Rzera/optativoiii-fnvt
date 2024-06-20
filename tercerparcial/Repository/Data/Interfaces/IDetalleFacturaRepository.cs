using Repository.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Interfaces
{
    public interface IDetalleFacturaRepository
    {
        bool add(DetalleFacturaModel detalleFacturaModel);
        bool update(DetalleFacturaModel detalleFacturaModel);
        bool delete(int id);
        IEnumerable<DetalleFacturaModel> GetAll();
    }
}
