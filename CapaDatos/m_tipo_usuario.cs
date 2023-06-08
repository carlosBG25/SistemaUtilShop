using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class m_tipo_usuario
    {

        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR_tipoUser;
        DataTable dt_tipoUser = new DataTable();
        public DataTable Readtipo_Usuario()
        {
            dt_tipoUser.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_TIPO_USUARIO";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_tipoUser = comando.ExecuteReader();
            dt_tipoUser.Load(SDR_tipoUser);
            conn.CerrarConexion();
            return dt_tipoUser;
        }

        

        public void Createtipo_Usuario(TipoUsuario tipo_usuario)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_TIPO_USUARIO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@tipouser", SqlDbType.VarChar, 50).Value = tipo_usuario.nombre;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }
        }

        public void Updatetipo_Usuario(TipoUsuario tipo_usuario)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_TIPO_USUARIO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@idtipoUser", SqlDbType.Int).Value = tipo_usuario.id_tipoUser;
            comando.Parameters.Add("@tipouser", SqlDbType.VarChar, 50).Value = tipo_usuario.nombre;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }
        }

        public void Deletetipo_Usuario(int id)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_TIPO_USUARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idtipoUser", id);

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                comando.Parameters.Clear();
                MessageBox.Show("No se puede eliminar el registro. \u25BC\n \n"
                    + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
