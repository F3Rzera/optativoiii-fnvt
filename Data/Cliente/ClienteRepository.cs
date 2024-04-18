using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PRIMER_EXAMEN_OPTATIVOIII.Data.ConfiguracionesDB;

namespace PRIMER_EXAMEN_OPTATIVOIII.Data.Cliente
{
    public class ClienteRepository
    {
        public bool InsertarCliente(ClienteModel cliente)
        {
            conexionDB conexion = new conexionDB();
            NpgsqlConnection conn = conexion.abrirConexion();
            try
            {
                string sql = "INSERT INTO cliente (id_banco, nombre, apellido, documento, direccion, telefono, correo, estado) " +
                    "VALUES (@id_banco, @nombre, @apellido, @documento, @direccion, @telefono, @correo, @estado)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_banco", cliente.Id_banco);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@documento", cliente.documento);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@correo", cliente.Correo);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el cliente: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
