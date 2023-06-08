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
    public class cn_estado
    {
        m_estado mestado = new m_estado();

        public DataTable REstado()
        {
            return mestado.ListarEstado();
        }

        public void CEstado(Estado e)
        {
            mestado.RegistrarEstado(e);
        }

        public void UEstado(Estado e)
        {
            mestado.EditarEstado(e);
        }

        public void DEstado(int id)
        {
            mestado.BorrarEstado(id);
        }
    }
}
