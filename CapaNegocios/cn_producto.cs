using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class cn_producto
    {
        m_producto mproducto = new m_producto();
        

        public DataTable ListarProducto()
        {
            return mproducto.ListarProducto();
        }

        public DataTable ListarCategoria()
        {
            return mproducto.ListarCategoria();
        }

        public DataTable ListarProveedor()
        {
            return mproducto.ListarProveedor();
        }

        public DataTable CodigoProducto()
        {
            return mproducto.CodigoProducto();
        }

        public DataTable FiltrarProducto(String valor)
        {
            return mproducto.FiltrarProducto(valor);
        }
        public void RegistrarProducto(Producto p)
        {
            mproducto.RegistrarProducto(p);
        }
        public void EditarProducto(Producto p)
        {
            mproducto.EditarProducto(p);
        }
        public void BorrarProducto(String p)
        {
            mproducto.BorrarProducto(p);
        }
    }
}
