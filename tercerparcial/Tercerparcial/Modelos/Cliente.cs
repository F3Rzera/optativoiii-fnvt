using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Primerparcial.Modelos
{
    public class Cliente
    {

        public int id_cliente { get; set; }
        public int id_banco { get; set; }
        private string nombre;
        private string apellido;
        public string documento;
        public string direccion { get; set; }
        public string mail { get; set; }
        public int celular { get; set; }
        public string estado { get; set; }

        public string getNombre()
        {
            try
            {
                if (string.IsNullOrEmpty(nombre))
                    throw new Exception("El nombre no puede dejar vacìo");
                else
                    return nombre;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
        }

        public string getApellido()
        {
            try
            {
                if (string.IsNullOrEmpty(apellido))
                    throw new Exception("El apellido no puede dejar vacìo");
                else
                    return apellido;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setApellido(string _apellido)
        {
            this.apellido = _apellido;
        }

        public string getDocumento()
        {
            try
            {
                if (string.IsNullOrEmpty(documento))
                    throw new Exception("El documento no puede dejar vacìo");
                else
                    return documento;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setDocumento(string _documento)
        {
            this.documento = _documento;
        }
    }
}
