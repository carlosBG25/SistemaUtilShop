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
    public class m_ventas
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        SqlDataReader SDR_ventas;
        DataTable dt_ventas = new DataTable();

        public DataTable LeerProductos()
        {
            dt_ventas.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM V_PRODUCTOS";
            comando.CommandType = CommandType.Text;
            SDR_ventas = comando.ExecuteReader();
            dt_ventas.Load(SDR_ventas);
            conn.CerrarConexion();
            return dt_ventas;
        }

        public DataTable LeerTipoDocumento()
        {
            DataTable dt_documento = new DataTable();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_TIPO_DOCUMENTO";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_ventas = comando.ExecuteReader();
            dt_documento.Load(SDR_ventas);
            conn.CerrarConexion();
            return dt_documento;
        }
        public DataTable ListarCategoria()
        {
            DataTable dt_Catcmb = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_ventas = comando.ExecuteReader();
            dt_Catcmb.Load(SDR_ventas);
            conn.CerrarConexion();
            SDR_ventas.Close();
            return dt_Catcmb;
        }

        public DataTable FiltrarProductoVentas(String valor)
        {
            dt_ventas.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_FILTRAR_PRODUCTO_VENTAS";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@valor", SqlDbType.VarChar, 40).Value = valor;
            SDR_ventas = comando.ExecuteReader();
            comando.Parameters.Clear();
            dt_ventas.Load(SDR_ventas);
            conn.CerrarConexion();
            return dt_ventas;
        }

        public DataTable ListarTrabajador()
        {
            DataTable dt_trab = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM V_LISTAR_REGISTRADORES";
            comando.CommandType = CommandType.Text;
            SDR_ventas = comando.ExecuteReader();
            dt_trab.Load(SDR_ventas);
            conn.CerrarConexion();
            SDR_ventas.Close();
            return dt_trab;
        }

        public DataTable CodigosVentas()
        {
            DataTable dt_cod = new DataTable();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_CODIGO_FACTURA";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_ventas = comando.ExecuteReader();
            dt_cod.Load(SDR_ventas);
            conn.CerrarConexion();
            SDR_ventas.Close();
            return dt_cod;
        }

        public void CreateVenta(Venta v)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_INSERTAR_FACTURA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id_factura_Doc", SqlDbType.VarChar, 7).Value = v.Id_factura_Doc;
            comando.Parameters.Add("@dni_cliente", SqlDbType.VarChar,15).Value = v.dni_Cliente;
            comando.Parameters.Add("@id_factura_Trabajador", SqlDbType.VarChar, 6).Value = v.Id_factura_Trabajador;
            comando.Parameters.Add("@id_factura_Producto", SqlDbType.VarChar, 10).Value = v.Id_factura_Producto;
            comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = v.cantidad;
            comando.Parameters.Add("@precioUnitario", SqlDbType.Float).Value = v.precioUnitario;
            comando.Parameters.Add("@numerofactura", SqlDbType.Int).Value = v.numerofactura;


            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {
            }
        }

        public void DeleteVenta(Venta v)
        {
            comando.Connection = conn.AbrirConexion();

            comando.CommandText = "SET LANGUAGE Spanish;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.CommandText = "SP_ELIMINAR_FACTURA";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add("@id_factura_Producto", SqlDbType.VarChar, 10).Value = v.Id_factura_Producto;
            comando.Parameters.Add("@dni_cliente", SqlDbType.Int).Value = v.dni_Cliente;
            comando.Parameters.Add("@numerofactura", SqlDbType.Int).Value = v.numerofactura;

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
