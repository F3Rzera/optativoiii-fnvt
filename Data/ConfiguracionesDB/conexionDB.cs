using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PRIMER_EXAMEN_OPTATIVOIII.Data.ConfiguracionesDB
{
    public class conexionDB
    {
        private NpgsqlConnection conn;
        private string cadenaConexion;
        public conexionDB()
        {
            cadenaConexion = "Server=localhost;Port=5432;User Id=postgres;Password=123456;Database=postgres";
            conn = new NpgsqlConnection(cadenaConexion);
        }
        public NpgsqlConnection abrirConexion()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Conexion abierta");
                return conn;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion: " + ex.Message);
                return null;
            }
        }
        public void cerrarConexion()
        {
            conn.Close();
        }
    }
}
