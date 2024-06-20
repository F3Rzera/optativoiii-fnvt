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

        public int id_cliente { get; set; }
        public int id_banco { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string direccion { get; set; }
        public string mail { get; set; }
        public int celular { get; set; }
        public string estado { get; set; }
    }
}
