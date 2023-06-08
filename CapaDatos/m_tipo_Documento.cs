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
    public class m_tipo_Documento
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR_tipoDoc;
        DataTable dt_tipoDoc = new DataTable();

        public DataTable CodigoDNI()
        {
            DataTable dt_cod = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_CODIGO_DNI";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_tipoDoc = comando.ExecuteReader();
            dt_cod.Load(SDR_tipoDoc);
            conn.CerrarConexion();
            SDR_tipoDoc.Close();
            return dt_cod;
        }

        public DataTable ListarTipoDocumento()
        {
            dt_tipoDoc.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_TIPO_DOCUMENTO";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_tipoDoc = comando.ExecuteReader();
            dt_tipoDoc.Load(SDR_tipoDoc);
            conn.CerrarConexion();
            return dt_tipoDoc;
        }

        public void RegistrarTipoDocumento(TipoDocumento d)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_TIPO_DOCUMENTO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_doc", SqlDbType.VarChar, 7).Value = d.id_doc;
            comando.Parameters.Add("@tipo_doc", SqlDbType.VarChar, 4).Value = d.tipo_Doc;
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 35).Value = d.descripcion;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }

        public void EditarTipoDocumento(TipoDocumento d)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_TIPO_DOCUMENTO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_doc", SqlDbType.VarChar, 7).Value = d.id_doc;
            comando.Parameters.Add("@tipo_doc", SqlDbType.VarChar, 4).Value = d.tipo_Doc;
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 35).Value = d.descripcion;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }
        }

        public void BorrarTipoDocumento(String cod)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_TIPO_DOCUMENTO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_doc", SqlDbType.VarChar, 7).Value = cod;

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
