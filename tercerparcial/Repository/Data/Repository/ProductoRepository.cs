using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;
using Repository.Data.ConfiguracionesDB;
using Repository.Data.Interfaces;
using Repository.Data.Models;

namespace Repository.Data.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        IDbConnection connection;
        public ProductoRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(ProductoModel productoModel)
        {
            try
            {
                connection.Execute("INSERT INTO productos(id_producto, descripcion, cantidad_minima, cantidad_stock, precio_compra, precio_venta, categoria, marca, estado) " +
                    $"Values(nextval('id_producto'), @descripcion, @cantidad_minima, @cantidad_stock, @precio_compra, @precio_venta, @categoria, @marca, @estado)", productoModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<ProductoModel> GetAll()
        {
            return connection.Query<ProductoModel>("SELECT * FROM productos");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM productos WHERE id_producto = {id}");
            return true;
        }
        public bool update(ProductoModel productoModel)
        {
            try
            {
                connection.Execute("UPDATE productos SET " +
                    " descripcion=@descripcion, " +
                    " cantidad_minima=@cantidad_minima, " +
                    " cantidad_stock=@cantidad_stock, " +
                    " precio_compra=@precio_compra, " +
                    " precio_venta=@precio_venta, " +
                    " categoria=@categoria, " +
                    " marca=@marca, " +
                    " estado=@estado " +
                    $" WHERE  id_producto = @id_producto", productoModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        IEnumerable<ProductoModel> IProductoRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
