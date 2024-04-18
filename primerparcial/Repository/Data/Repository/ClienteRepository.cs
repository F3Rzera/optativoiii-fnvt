using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Repository.Data.ConfiguracionesDB;
using Repository.Data.Models;

namespace Repository.Data.Repository
{
    public class ClienteRepository
    {
        NpgsqlConnection connection;
        public ClienteRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(ClienteModel clienteModel)
        {
            try
            {
                //insercion de datos
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO cliente(id_cliente, id_banco, nombre, apellido, documento, direccion, mail, celular, estado) " +
                    $"Values(" +
                    "nextval('seq_id_cliente'), " +
                    $"'{clienteModel.id_banco}', " +
                    $"'{clienteModel.nombre}', " +
                    $"'{clienteModel.apellido}'," +
                    $"'{clienteModel.documento}'," +
                    $"'{clienteModel.direccion}'," +
                    $"'{clienteModel.mail}'," +
                    $"'{clienteModel.celular}'," +
                    $"'{clienteModel.estado}')";


                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClienteModel> list()
        {
            List<ClienteModel> clientes = new List<ClienteModel>();
            //consulta de datos
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id_cliente, id_banco, nombre, apellido, documento, direccion, mail, celular, estado FROM cliente";
            var list = cmd.ExecuteReader();


            while (list.Read())
            {
                clientes.Add(new ClienteModel {
                    id_cliente = list.GetInt64(0),
                    id_banco = list.GetInt64(1),
                    nombre = list.GetString(2),
                    apellido = list.GetString(3),
                    documento = list.GetString(4),
                    direccion = list.GetString(5),
                    mail  = list.GetString (6),
                    celular = list.GetInt64(7),
                    estado = list.GetString(8)
                });
            }
            
            return clientes;
        }
    }
}
