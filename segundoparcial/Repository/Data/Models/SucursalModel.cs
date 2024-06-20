using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Models
{
    public class SucursalModel
    {

        public int id_sucursal { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string whatsapp { get; set; }
        public string mail { get; set; }
        public string estado { get; set; }
    }
}
