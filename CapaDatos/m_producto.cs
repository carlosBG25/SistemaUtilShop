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
    public class m_producto
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR;
        DataTable dt = new DataTable();


        public DataTable ListarProducto()
        {
            dt.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            SDR = comando.ExecuteReader();
            dt.Load(SDR);
            conn.CerrarConexion();
            return dt;
        }

        public DataTable ListarCategoria()
        {
            DataTable dt_Catcmb = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM TB_CATEGORIA";
            comando.CommandType = CommandType.Text;
            SDR = comando.ExecuteReader();
            dt_Catcmb.Load(SDR);
            conn.CerrarConexion();
            SDR.Close();
            return dt_Catcmb;
        }

        public DataTable ListarProveedor()
        {
            DataTable dt_prov = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM TB_PROVEEDOR";
            comando.CommandType = CommandType.Text;
            SDR = comando.ExecuteReader();
            dt_prov.Load(SDR);
            conn.CerrarConexion();
            SDR.Close();
            return dt_prov;
        }

        public DataTable CodigoProducto()
        {
            DataTable dt_cod = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_CODIGO_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            SDR = comando.ExecuteReader();
            dt_cod.Load(SDR);
            conn.CerrarConexion();
            SDR.Close();
            return dt_cod;
        }

        public DataTable FiltrarProducto(String valor)
        {
            dt.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_FILTRAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@valor", SqlDbType.VarChar, 40).Value = valor;

            try
            {
                SDR = comando.ExecuteReader();
                comando.Parameters.Clear();
                dt.Load(SDR);
                conn.CerrarConexion();
                
            }
            catch (Exception)
            {
                comando.Parameters.Clear();
            }
            return dt;
        }

        public void RegistrarProducto(Producto p)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_producto", SqlDbType.VarChar, 10).Value = p.Id_producto;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 300).Value = p.nombre;
            comando.Parameters.Add("@id_productoCateg", SqlDbType.Int).Value = p.id_productoCateg;
            comando.Parameters.Add("@id_productoProveedor", SqlDbType.Int).Value = p.id_productoProveedor;
            comando.Parameters.Add("@stock", SqlDbType.Int).Value = p.stock;
            comando.Parameters.Add("@precioUnitario", SqlDbType.Money).Value = p.precioUnitario;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }

        public void EditarProducto(Producto p)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_producto", SqlDbType.VarChar, 10).Value = p.Id_producto;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 300).Value = p.nombre;
            comando.Parameters.Add("@id_productoCateg", SqlDbType.Int).Value = p.id_productoCateg;
            comando.Parameters.Add("@id_productoProveedor", SqlDbType.Int).Value = p.id_productoProveedor;
            comando.Parameters.Add("@stock", SqlDbType.Int).Value = p.stock;
            comando.Parameters.Add("@precioUnitario", SqlDbType.Money).Value = p.precioUnitario;

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }

        }
        public void BorrarProducto(String p)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_producto", p);

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