using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Primerparcial.Modelos
{
    public class DetalleFactura
    {
        public int id_det_factura { get; set; }
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public int cantidad_producto ;
        public int subtotal;

        public int getCantidadProducto()
        {
            try
            {
                if (cantidad_producto < 1)
                    throw new Exception("La cantidad de producto debe ser mayor a cero");
                else
                    return cantidad_producto;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setCantidadProducto(int _cantidad_producto)
        {
            this.cantidad_producto = _cantidad_producto;
        }

        public int getSubtotal()
        {
            try
            {
                if (subtotal < 1)
                    throw new Exception("El subtotal debe ser mayor a cero");
                else
                    return subtotal;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setSubtotal(int _subtotal)
        {
            this.subtotal = _subtotal;
        }

    }
}
