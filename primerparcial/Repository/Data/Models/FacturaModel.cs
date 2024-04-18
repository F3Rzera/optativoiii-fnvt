using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Models
{
    public class FacturaModel
    {

        public BigInteger id_factura { get; set; }
        public BigInteger id_cliente { get; set; }
        public string nro_factura { get; set; }
        public DateTime fecha_hora { get; set; }
        public BigInteger total { get; set; }
        public BigInteger total_iva5 { get; set; }
        public BigInteger total_iva10 { get; set; }
        public BigInteger total_iva { get; set; }
        public string total_letras { get; set; }
        public string sucursal { get; set; }
   
    }
}
