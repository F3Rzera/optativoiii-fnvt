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
    public class DetalleFacturaRepository : IDetalleFacturaRepository
    {
        IDbConnection connection;
        public DetalleFacturaRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(DetalleFacturaModel detalleFacturaModel)
        {
            try
            {
                connection.Execute("INSERT INTO detalle_factura(id_det_factura, id_factura, id_producto, cantidad_producto, subtotal) " +
                    $"Values(nextval('id_det_factura'), @id_factura, @id_producto, @cantidad_producto, @subtotal)", detalleFacturaModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<DetalleFacturaModel> GetAll()
        {
            return connection.Query<DetalleFacturaModel>("SELECT * FROM detalle_factura");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM detalle_factura WHERE id_det_factura = {id}");
            return true;
        }
        public bool update(DetalleFacturaModel detalleFacturaModel)
        {
            try
            {
                connection.Execute("UPDATE detalle_factura SET " +
                    " id_factura=@id_factura, " +
                    " id_producto=@id_producto, " +
                    " cantidad_producto=@cantidad_producto, " +
                    " presubtotalcio_compra=@subtotal " +
                    $" WHERE  id_det_factura = @id_det_factura", detalleFacturaModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
