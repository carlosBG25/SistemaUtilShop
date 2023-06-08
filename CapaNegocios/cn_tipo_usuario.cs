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
    public class cn_tipo_usuario
    {
        m_tipo_usuario m_Tuser = new m_tipo_usuario();

        public DataTable Readtipo_Usuario()
        {
            return m_Tuser.Readtipo_Usuario();
        }
        public void Createtipo_Usuario(TipoUsuario tipo_usuario)
        {
            m_Tuser.Createtipo_Usuario(tipo_usuario);
        }

        public void Updatetipo_Usuario(TipoUsuario tipo_usuario)
        {
            m_Tuser.Updatetipo_Usuario(tipo_usuario);
        }

        public void Deletetipo_Usuario(int id)
        {
            m_Tuser.Deletetipo_Usuario(id);
        }
    }
}
