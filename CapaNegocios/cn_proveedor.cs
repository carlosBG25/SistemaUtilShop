using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class cn_proveedor
    {
        m_proveedor mProv = new m_proveedor();

        public DataTable ListarProveedor()
        {
            return mProv.ListarProveedor();
        }

        public void RegistrarProveedor(Proveedor p)
        {
            mProv.RegistrarProveedor(p);
        }

        public void EditarProveedor(Proveedor p)
        {
            mProv.EditarProveedor(p);
        }

        public void BorrarProveedor(int id)
        {
            mProv.BorrarProveedor(id);
        }
    }
}
