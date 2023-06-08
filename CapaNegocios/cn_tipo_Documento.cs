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
    public class cn_tipo_Documento
    {

        m_tipo_Documento mdoc = new m_tipo_Documento();

        public DataTable CodigoDNI()
        {
            return mdoc.CodigoDNI();
        }
        public DataTable ListarDocumento()
        {
            return mdoc.ListarTipoDocumento();
        }

        public void RegistrarDocumento(TipoDocumento d)
        {
            mdoc.RegistrarTipoDocumento(d);
        }

        public void EditarDocumento(TipoDocumento d)
        {
            mdoc.EditarTipoDocumento(d);
        }

        public void BorrarDocumento(String cod)
        {
            mdoc.BorrarTipoDocumento(cod);
        }
    }
}
