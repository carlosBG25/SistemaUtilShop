using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace CapaDatos
{
    public class Conexion
    {
        // Instanciar la conexion
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
        public SqlConnection AbrirConexion()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
                Console.WriteLine("Conexión Abierta");
            return conn;
        }

        public SqlConnection CerrarConexion()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
                Console.WriteLine("Conexión Cerrada");
            return conn;
        }
    }
}
