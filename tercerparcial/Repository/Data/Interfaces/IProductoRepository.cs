using Repository.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Interfaces
{
    public interface IProductoRepository
    {
        bool add(ProductoModel productoModel);
        bool update(ProductoModel productoModel);
        bool delete(int id);
        IEnumerable<ProductoModel> GetAll();
    }
}
