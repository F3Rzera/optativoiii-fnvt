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

        public BigInteger id_factura { get; set; }
        public BigInteger id_cliente { get; set; }
        public string nro_factura { get; set; }
        public DateTime fecha_hora { get; set; }
        public BigInteger total;
        public BigInteger total_iva5;
        public BigInteger total_iva10;
        public BigInteger total_iva;
        public string total_letras;
        public string sucursal { get; set; }
   
        public BigInteger getTotal()
        {
            try
            {
                //Validamos que total no este vacio
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
        public void setTotal(BigInteger _total)
        {
            this.total = _total;
        }

        public BigInteger getTotal_iva5()
        {
            try
            {
                //Validamos que total_iva5 no este vacio
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
        public void setTotal_iva5(BigInteger _total_iva5)
        {
            this.total_iva5 = _total_iva5;
        }

        public BigInteger getTotal_iva10()
        {
            try
            {
                //Validamos que total_iva10 no este vacio
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
        public void setTotal_iva10(BigInteger _total_iva10)
        {
            this.total_iva10 = _total_iva10;
        }
        public BigInteger getTotal_iva()
        {
            try
            {
                //Validamos que total_iva no este vacio
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
        public void setTotal_iva(BigInteger _total_iva)
        {
            this.total_iva = _total_iva;
        }
        public string getTotal_letras()
        {
            try
            {
                //Validamos que total_letras no este vacio
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
