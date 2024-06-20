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
    public class ClienteRepository : IClienteRepository
    {
        IDbConnection connection;
        public ClienteRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(ClienteModel clienteModel)
        {
            try
            {
                connection.Execute("INSERT INTO cliente(id_cliente, id_banco, nombre, apellido, documento, direccion, mail, celular, estado) " +
                    $"Values(nextval('id_cliente'), @id_banco, @nombre, @apellido, @documento, @direccion, @mail, @celular, @estado)", clienteModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            return connection.Query<ClienteModel>("SELECT * FROM cliente");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM cliente WHERE id_cliente = {id}");
            return true;
        }
        public bool update(ClienteModel clienteModel)
        {
            try
            {
                connection.Execute("UPDATE cliente SET " +
                    " id_banco=@id_banco, " +
                    " nombre=@nombre, " +
                    " apellido=@apellido, " +
                    " documento=@documento, " +
                    " direccion=@direccion, " +
                    " mail=@mail, " +
                    " celular=@celular, " +
                    " estado=@estado " +
                    $" WHERE  id_cliente = @id_cliente", clienteModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
