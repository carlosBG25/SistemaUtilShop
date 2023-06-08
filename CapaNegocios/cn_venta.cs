using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;


namespace CapaNegocios
{
    public class cn_venta
    {
        m_ventas ventas = new m_ventas();

        public DataTable LeerProducto()
        {
            return ventas.LeerProductos();
        }
        public DataTable LeerTipoDocumento()
        {
            return ventas.LeerTipoDocumento();
        }

        public DataTable ListarCategoria()
        {
            return ventas.ListarCategoria();
        }
        public DataTable ListarTrabajador()
        {
            return ventas.ListarTrabajador();
        }
        public DataTable CodigosVentas()
        {
            return ventas.CodigosVentas();
        }
        public DataTable FiltrarProductoVentas(String valor)
        {
            return ventas.FiltrarProductoVentas(valor);
        }
        

        public void InsertarVenta(Venta v)
        {
            ventas.CreateVenta(v);
        }

        public void BorrarVenta(Venta v)
        {
            ventas.DeleteVenta(v);
        }
    }
}
