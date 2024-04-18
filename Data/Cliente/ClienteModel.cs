using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_EXAMEN_OPTATIVOIII.Data.Cliente
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public int Id_banco { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string estado { get; set; }

    }
}
