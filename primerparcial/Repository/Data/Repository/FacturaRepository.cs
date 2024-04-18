using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Repository.Data.ConfiguracionesDB;
using Repository.Data.Models;

namespace Repository.Data.Repository
{
    public class FacturaRepository
    {
        NpgsqlConnection connection;
        public FacturaRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(FacturaModel facturaModel)
        {
            try
            {
                //insercion de datos
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Factura(id_cliente, id_factura, nro_factura, fecha_hora, total, total_iva5, total_iva10, total_iva, total_letras, sucursal) " +
                    $"Values(" +
                    $"{facturaModel.id_cliente}, " +
                    $"nextval('seq_id_cliente'), " +
                    $"'{facturaModel.nro_factura}'," +
                    $"'{facturaModel.fecha_hora}'," +
                    $"{facturaModel.total}," +
                    $"{facturaModel.total_iva5}," +
                    $"{facturaModel.total_iva10}," +
                    $"{facturaModel.total_iva}," +
                    $"'{facturaModel.total_letras}'," +
                    $"'{facturaModel.sucursal}')";
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FacturaModel> list()
        {
            List<FacturaModel> facturas = new List<FacturaModel>();
            //consulta de datos
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id_factura, id_cliente, nro_factura, fecha_hora, total, total_iva5, total_iva10, total_iva, total_letras, sucursal FROM factura";
            var list = cmd.ExecuteReader();


            while (list.Read())
            {
                facturas.Add(new FacturaModel
                {
                    id_factura = list.GetInt64(0),
                    id_cliente = list.GetInt64(1),
                    nro_factura = list.GetString(2),
                    fecha_hora = DateTime.Parse(list.GetString(3)),
                    total = list.GetInt64(4),
                    total_iva5 = list.GetInt64(5),
                    total_iva10 = list.GetInt64(6),
                    total_iva = list.GetInt64(7),
                    total_letras = list.GetString(8),
                    sucursal = list.GetString(9)

                }); ;
            }
            
            return facturas;
        }
    }
}
