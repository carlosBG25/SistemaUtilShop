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
    public class m_proveedor
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR_Proveedor;
        public DataTable ListarProveedor()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_PROVEEDOR";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_Proveedor = comando.ExecuteReader();
            tabla.Load(SDR_Proveedor);
            SDR_Proveedor.Close();
            conn.CerrarConexion();
            return tabla;
        }

        public void RegistrarProveedor(Proveedor p)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_PROVEEDOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = p.empresa;
            comando.Parameters.Add("@persona", SqlDbType.VarChar).Value = p.persona;
            comando.Parameters.Add("@celular", SqlDbType.Int).Value = p.celular;
            comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = p.correo;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }
        public void EditarProveedor(Proveedor p)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_PROVEEDOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = p.id_proveedor;
            comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = p.empresa;
            comando.Parameters.Add("@persona", SqlDbType.VarChar).Value = p.persona;
            comando.Parameters.Add("@celular", SqlDbType.Int).Value = p.celular;
            comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = p.correo;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }

        public void BorrarProveedor(int id)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_PROVEEDOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = id;

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
