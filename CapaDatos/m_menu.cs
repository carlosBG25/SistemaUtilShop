using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class m_menu
    {
        private Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();

        public DataTable tb_Boleta = new DataTable(); // DATATABLE PARA ALMACENAR LOS CALCULOS DEL TRABAJADOR
        DataTable tb_rxc = new DataTable();


        SqlDataReader SDR_Tra;

        public DataTable ListarDetalleFacturas()
        {
            tb_rxc.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_LISTAR_FACTURA";
            comando.CommandType = CommandType.StoredProcedure;
            SDR_Tra = comando.ExecuteReader();
            tb_rxc.Load(SDR_Tra);
            conn.CerrarConexion();
            return tb_rxc;
        }

        public DataTable FiltrarFacturas(String valor)
        {
            tb_rxc.Clear();
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SP_FILTRAR_FACTURAS";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@valor", SqlDbType.VarChar, 15).Value = valor;
            SDR_Tra = comando.ExecuteReader();
            comando.Parameters.Clear();
            tb_rxc.Load(SDR_Tra);
            conn.CerrarConexion();
            return tb_rxc;
        }

    }
}
