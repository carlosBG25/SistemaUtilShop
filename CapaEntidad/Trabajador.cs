using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Trabajador
    {
        public string Id_trabajador { get; set; }
        public string login_Trabajador { get; set; }
        public string password { get; set; }
        public string nombres { get; set; }
        public string Ap_Paterno { get; set; }
        public string Ap_Materno { get; set; }
        public string Id_doc_trabajador { get; set; }
        public string numero_documento { get; set; }
        public int id_trabajadorTipoUser { get; set; }
        public int id_trabajadorEstado { get; set; }
    }
}
