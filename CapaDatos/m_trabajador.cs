using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class m_trabajador
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR_Tra;
        DataTable dt_Tra = new DataTable();

        public DataTable ListarTrabajador()
        {
            dt_Tra.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_TRABAJADOR";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_Tra = comando.ExecuteReader();
            dt_Tra.Load(SDR_Tra);
            conn.CerrarConexion();
            return dt_Tra;
        }

        public DataTable ListarTipoDocumento()
        {
            DataTable tb_distrito = new DataTable();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT  * FROM TB_TIPO_DOCUMENTO";
            comando.CommandType = CommandType.Text;
            SDR_Tra = comando.ExecuteReader();
            tb_distrito.Load(SDR_Tra);
            SDR_Tra.Close();
            conn.CerrarConexion();
            return tb_distrito;
        }

        public DataTable ListarTipoUsuario()
        {
            DataTable tb_tuser = new DataTable();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT  * FROM TB_TIPO_USUARIO";
            comando.CommandType = CommandType.Text;
            SDR_Tra = comando.ExecuteReader();
            tb_tuser.Load(SDR_Tra);
            SDR_Tra.Close();
            conn.CerrarConexion();
            return tb_tuser;
        }

        public DataTable ListarEstado()
        {
            DataTable tb_estado = new DataTable();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT  * FROM TB_ESTADO";
            comando.CommandType = CommandType.Text;
            SDR_Tra = comando.ExecuteReader();
            tb_estado.Load(SDR_Tra);
            SDR_Tra.Close();
            conn.CerrarConexion();
            return tb_estado;
        }

        public DataTable CodigoTrabajador()
        {
            DataTable dt_cod = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_CODIGO_TRABAJADOR";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_Tra = comando.ExecuteReader();
            dt_cod.Load(SDR_Tra);
            conn.CerrarConexion();
            SDR_Tra.Close();
            return dt_cod;
        }

        public DataTable FiltrarTrabajador(String valor)
        {
            dt_Tra.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_FILTRAR_TRABAJADOR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@valor", SqlDbType.VarChar, 20 ).Value = valor;
            SDR_Tra = comando.ExecuteReader();
            comando.Parameters.Clear();
            dt_Tra.Load(SDR_Tra);
            conn.CerrarConexion();
            return dt_Tra;
        }

        public void RegistrarTrabajador(Trabajador t)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_TRABAJADOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_trabajador", SqlDbType.VarChar, 6).Value = t.Id_trabajador;
            comando.Parameters.Add("@login_trabajador", SqlDbType.VarChar, 10).Value = t.login_Trabajador;
            comando.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = t.password;
            comando.Parameters.Add("@nombres", SqlDbType.VarChar, 30).Value = t.nombres;
            comando.Parameters.Add("@ap_paterno", SqlDbType.VarChar, 20).Value = t.Ap_Paterno;
            comando.Parameters.Add("@ap_materno", SqlDbType.VarChar, 20).Value = t.Ap_Materno;
            comando.Parameters.Add("@id_trabajadorDoc", SqlDbType.VarChar, 7).Value = t.Id_doc_trabajador;
            comando.Parameters.Add("@num_doc", SqlDbType.VarChar, 15).Value = t.numero_documento;
            comando.Parameters.Add("@id_trabajadorTipoUser", SqlDbType.Int).Value = t.id_trabajadorTipoUser;
            comando.Parameters.Add("@id_trabajadorEstado", SqlDbType.Int).Value = t.id_trabajadorEstado;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }
        public void EditarTrabajador(Trabajador t)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_TRABAJADOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_trabajador", SqlDbType.VarChar, 6).Value = t.Id_trabajador;
            comando.Parameters.Add("@login_trabajador", SqlDbType.VarChar, 10).Value = t.login_Trabajador;
            comando.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = t.password;
            comando.Parameters.Add("@nombres", SqlDbType.VarChar, 30).Value = t.nombres;
            comando.Parameters.Add("@ap_paterno", SqlDbType.VarChar, 20).Value = t.Ap_Paterno;
            comando.Parameters.Add("@ap_materno", SqlDbType.VarChar, 20).Value = t.Ap_Materno;
            comando.Parameters.Add("@id_trabajadorDoc", SqlDbType.VarChar, 7).Value = t.Id_doc_trabajador;
            comando.Parameters.Add("@num_doc", SqlDbType.VarChar, 15).Value = t.numero_documento;
            comando.Parameters.Add("@id_trabajadorTipoUser", SqlDbType.Int).Value = t.id_trabajadorTipoUser;
            comando.Parameters.Add("@id_trabajadorEstado", SqlDbType.Int).Value = t.id_trabajadorEstado;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }
        public void BorrarTrabajador(String id)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_TRABAJADOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_trabajador", SqlDbType.VarChar, 6).Value = id;

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
