using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Primerparcial.Modelos
{
    public class Producto
    {

        public int id_producto { get; set; }
        public string descripcion;
        public int cantidad_minima;
        public int cantidad_stock { get; set; }
        public int precio_compra;
        public int precio_venta;
        public string categoria;
        public string marca;
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

        public int getCantidadMinima()
        {
            try
            {
                if (cantidad_minima < 1)
                    throw new Exception("La cantidad minima debe ser mayor a 1");
                else
                    return cantidad_minima;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setCantidadMinima(int _cantidad_minima)
        {
            this.cantidad_minima = _cantidad_minima;
        }

        public int getPrecioCompra()
        {
            try
            {
                if (precio_compra <= 0)
                    throw new Exception("El precio de compra debe ser positivo");
                else
                    return precio_compra;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setPrecioCompra(int _precio_compra)
        {
            this.precio_compra = _precio_compra;
        }

        public int getPrecioVenta()
        {
            try
            {
                if (precio_venta <= 0)
                    throw new Exception("El precio de venta debe ser positivo");
                else
                    return precio_venta;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setPrecioVenta(int _precio_venta)
        {
            this.precio_venta = _precio_venta;
        }

        public string getCategoria()
        {
            try
            {
                if (string.IsNullOrEmpty(categoria))
                    throw new Exception("La categoria no puede dejar vacìo");
                else
                    return categoria;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setCategoria(string _categoria)
        {
            this.categoria = _categoria;
        }

        public string getMarca()
        {
            try
            {
                if (string.IsNullOrEmpty(marca))
                    throw new Exception("La marca no puede dejar vacìo");
                else
                    return marca;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setMarca(string _marca)
        {
            this.marca = _marca;
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
