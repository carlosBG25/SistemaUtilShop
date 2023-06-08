using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class cn_Login
    {
        m_login login = new m_login();
        public bool LoginAdmin(Login l)
        {
            return login.Login(l);
        }
    }
}
