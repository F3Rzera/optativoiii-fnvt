using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Primerparcial.Modelos
{
    public class Factura
    {

        public int id_factura { get; set; }
        public int id_cliente { get; set; }
        public string nro_factura { get; set; }
        public DateTime fecha_hora { get; set; }
        public int total;
        public int total_iva5;
        public int total_iva10;
        public int total_iva;
        public string total_letras;
        public int id_sucursal { get; set; }
   
        public int getTotal()
        {
            try
            {
                if (total == null)
                    throw new Exception("El total no puede dejar vacìo");
                else
                    return total;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setTotal(int _total)
        {
            this.total = _total;
        }

        public int getTotal_iva5()
        {
            try
            {
                if (total_iva5 == null)
                    throw new Exception("El total_iva5 no puede dejar vacìo");
                else
                    return total_iva5;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setTotal_iva5(int _total_iva5)
        {
            this.total_iva5 = _total_iva5;
        }

        public int getTotal_iva10()
        {
            try
            {
                if (total_iva10 == null)
                    throw new Exception("El total_iva10 no puede dejar vacìo");
                else
                    return total_iva10;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setTotal_iva10(int _total_iva10)
        {
            this.total_iva10 = _total_iva10;
        }
        public int getTotal_iva()
        {
            try
            {
                if (total_iva == null)
                    throw new Exception("El total_iva no puede dejar vacìo");
                else
                    return total_iva;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setTotal_iva(int _total_iva)
        {
            this.total_iva = _total_iva;
        }
        public string getTotal_letras()
        {
            try
            {
                if (string.IsNullOrEmpty(total_letras))
                    throw new Exception("El total_letras no puede dejar vacìo");
                else
                    return total_letras;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setTotal_letras(string _total_letras)
        {
            this.total_letras = _total_letras;
        }
    }
}
