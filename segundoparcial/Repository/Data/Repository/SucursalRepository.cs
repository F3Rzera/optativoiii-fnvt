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
    public class SucursalRepository : ISucursalRepository
    {
        //fverdun
        IDbConnection connection;
        public SucursalRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(SucursalModel sucursalModel)
        {
            try
            {
                connection.Execute("INSERT INTO sucursal(id_sucursal, descripcion, direccion, telefono, whatsapp, mail, estado) " +
                    $"Values(nextval('id_sucursal'), @descripcion, @direccion, @telefono, @whatsapp, @mail, @estado)", sucursalModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<SucursalModel> GetAll()
        {
            return connection.Query<SucursalModel>("SELECT * FROM sucursal");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM sucursal WHERE id_sucursal = {id}");
            return true;
        }
        public bool update(SucursalModel sucursalModel)
        {
            try
            {
                connection.Execute("UPDATE sucursal SET " +
                    " descripcion=@descripcion, " +
                    " direccion=@direccion, " +
                    " telefono=@telefono, " +
                    " whatsapp=@whatsapp, " +
                    " mail=@mail, " +
                    " estado=@estado " +
                    $" WHERE  id_sucursal = @id_sucursal", sucursalModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
