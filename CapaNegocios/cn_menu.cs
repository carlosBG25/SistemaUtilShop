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
    public class cn_menu
    {
        m_menu menu = new m_menu();

        public DataTable RDetalleFacturas()
        {
            return menu.ListarDetalleFacturas();
        }

        public DataTable FiltrarFacturas(String valor)
        {
            return menu.FiltrarFacturas(valor);
        }

    }
}
