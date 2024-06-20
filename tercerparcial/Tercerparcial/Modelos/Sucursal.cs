using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Primerparcial.Modelos
{
    public class Sucursal
    {

        public int id_sucursal { get; set; }
        public string descripcion;
        public string direccion;
        public string telefono;
        public string whatsapp { get; set; }
        public string mail;
        public string estado;

        public string getDescripcion()
        {
            try
            {
                if (string.IsNullOrEmpty(descripcion))
                    throw new Exception("La descripcion no puede dejar vacìo");
                else
                    return descripcion;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setDescripcion(string _descripcion)
        {
            this.descripcion = _descripcion;
        }

        public string getDireccion()
        {
            try
            {
                if (string.IsNullOrEmpty(direccion))
                    throw new Exception("La direccion no puede dejar vacìo");
                else
                    return direccion;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setDireccion(string _direccion)
        {
            this.direccion = _direccion;
        }

        public string getTelefono()
        {
            try
            {
                if (string.IsNullOrEmpty(telefono))
                    throw new Exception("La telefono no puede dejar vacìo");
                else
                    return telefono;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setTelefono(string _telefono)
        {
            this.telefono = _telefono;
        }

        public string getMail()
        {
            try
            {
                if (string.IsNullOrEmpty(mail))
                    throw new Exception("El mail no puede dejar vacìo");
                else
                    return mail;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setMail(string _mail)
        {
            this.mail = _mail;
        }

        public string getEstado()
        {
            try
            {
                if (string.IsNullOrEmpty(estado))
                    throw new Exception("El estado no puede dejar vacìo");
                else
                    return estado;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setEstado(string _estado)
        {
            this.estado = _estado;
        }

    }
}
