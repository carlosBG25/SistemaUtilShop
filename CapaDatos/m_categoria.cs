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
    public class m_categoria
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR_Cat;
        DataTable dt_Cat = new DataTable();
        
        public void CreateCategoria(Categoria cat)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 40).Value = cat.descripcion;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {
            }
        }

        public DataTable ReadCategoria()
        {
            dt_Cat.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_Cat = comando.ExecuteReader();
            dt_Cat.Load(SDR_Cat);
            conn.CerrarConexion();
            return dt_Cat;
        }

        

        public void UpdateCategoria(Categoria cat)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id_categoria", SqlDbType.Int).Value = cat.id_categoria;
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 40).Value = cat.descripcion;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {
            }
        }

        public void DeleteCategoria(int id_cat)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_categoria", id_cat);

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
