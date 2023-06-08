using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class m_login
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();
        

        public bool Login(Login l)
        {
            SqlDataReader SDR;
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM V_CREDENCIALES_ADMINISTRADOR " +
                "WHERE login_trabajador = @login AND [PASSWORD] = @password and Id_trabTipoUser = 2 and Id_trabajadorEstado = 1";
            comando.Parameters.AddWithValue("@login", l.usuario) ;
            comando.Parameters.AddWithValue("@password", l.password) ;
            comando.CommandType = CommandType.Text;
            SDR = comando.ExecuteReader();
            comando.Parameters.Clear();
            // si el lector contiene filas es verdadero
            using (SDR)
            {
                if (SDR.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
