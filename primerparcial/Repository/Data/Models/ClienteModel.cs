using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Models
{
    public class ClienteModel
    {

        public BigInteger id_cliente { get; set; }
        public BigInteger id_banco { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string direccion { get; set; }
        public string mail { get; set; }
        public BigInteger celular { get; set; }
        public string estado { get; set; }
    }
}
