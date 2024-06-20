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
    public class FacturaRepository : IFacturaRepository
    {
        IDbConnection connection;
        public FacturaRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(FacturaModel facturaModel)
        {
            try
            {
                connection.Execute("INSERT INTO Factura(id_factura, id_cliente, nro_factura, fecha_hora, total, total_iva5, total_iva10, total_iva, total_letras, id_sucursal) " +
                    $"Values(nextval('id_factura'), @id_cliente, @nro_factura, @fecha_hora, @total, @total_iva5, @total_iva10, @total_iva, @total_letras, @id_sucursal)", facturaModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<FacturaModel> GetAll()
        {
            return connection.Query<FacturaModel>("SELECT * FROM factura");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM factura WHERE id_factura = {id}");
            return true;
        }
        public bool update(FacturaModel facturaModel)
        {
            try
            {
                connection.Execute("UPDATE factura SET " +
                    " id_cliente=@id_cliente, " +
                    " nro_factura=@nro_factura, " +
                    " fecha_hora=@fecha_hora, " +
                    " total=@total, " +
                    " total_iva5=@total_iva5, " +
                    " total_iva10=@total_iva10, " +
                    " total_iva=@total_iva, " +
                    " total_letras=@total_letras, " +
                    " id_sucursal=@id_sucursal " +
                    $" WHERE  id_factura = @id_factura", facturaModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
