using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Models
{
    public class DetalleFacturaModel
    {

        public int id_det_factura { get; set; }
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public int cantidad_producto { get; set; }
        public int subtotal { get; set; }
    }
}
