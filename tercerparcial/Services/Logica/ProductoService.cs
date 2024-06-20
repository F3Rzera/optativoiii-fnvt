using Repository.Data.Interfaces;
using Repository.Data.Models;
using Repository.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ProductoService : IProductoRepository
    {
        private ProductoRepository productoRepository;
        public ProductoService(string connectionString)
        {
            productoRepository = new ProductoRepository(connectionString);
        }

        public bool add(ProductoModel producto)
        {
            return validarDatos(producto) ? productoRepository.add(producto) : throw new Exception("Error en la validación de datos, corroborar");
        }

        public IEnumerable<ProductoModel> GetAll()
        {
            return productoRepository.GetAll();
        }

        public bool delete(int id)
        {
            return id > 0 ? productoRepository.delete(id) : false;
        }

        public bool update(ProductoModel producto)
        {
            return validarDatos(producto) ? productoRepository.update(producto) : throw new Exception("Error en la validación de datos, corroborar");
        }
        private bool validarDatos(ProductoModel producto)
        {
            if(producto.cantidad_minima < 1 || producto.precio_compra < 1 || producto.precio_venta < 1)
                return false;
            if (string.IsNullOrEmpty(producto.descripcion) || string.IsNullOrEmpty(producto.categoria) || string.IsNullOrEmpty(producto.marca) || string.IsNullOrEmpty(producto.estado))
                return false;
            if (producto.cantidad_stock < 0)
                return false;

            return true;
        }
    }
}
