using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaDatos;
using System.Security.Cryptography;

namespace CapaNegocios
{
    public class cn_trabajador
    {
        m_trabajador mTrab = new m_trabajador();

        public DataTable ListarTrabajador()
        {
            return mTrab.ListarTrabajador();
        }
        public DataTable ListarTipoDocumento()
        {
            return mTrab.ListarTipoDocumento();
        }
        public DataTable ListarTipoUsuario()
        {
            return mTrab.ListarTipoUsuario();
        }

        public DataTable ListarEstado()
        {
            return mTrab.ListarEstado();
        }
        public DataTable CodigoTrabajador()
        {
            return mTrab.CodigoTrabajador();
        }
        public DataTable FiltrarTrabajador(String valor) 
        {
            return mTrab.FiltrarTrabajador(valor);
        }
        public void RegistrarTrabajador(Trabajador t)
        {
            mTrab.RegistrarTrabajador(t);
        }
        public void EditarTrabajador(Trabajador t)
        {
            mTrab.EditarTrabajador(t);
        }
        public void BorrarTrabajador(String id)
        {
            mTrab.BorrarTrabajador(id);
        }
    }
}
