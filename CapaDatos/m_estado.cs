using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Windows.Forms;


namespace CapaDatos
{
    public class m_estado
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR_estado;
        DataTable dt_estado= new DataTable();
        public DataTable ListarEstado()
        {
            dt_estado.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_ESTADO";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_estado = comando.ExecuteReader();
            dt_estado.Load(SDR_estado);
            conn.CerrarConexion();
            return dt_estado;
        }

        public void RegistrarEstado(Estado e)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_ESTADO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = e.estado;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }

        public void EditarEstado(Estado e)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_ESTADO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@idestado", SqlDbType.Int).Value = e.Id_estado;
            comando.Parameters.Add("@estado", SqlDbType.VarChar, 45).Value = e.estado;
            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }
        }

        public void BorrarEstado(int id)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_ESTADO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@idestado", SqlDbType.Int).Value = id;

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
