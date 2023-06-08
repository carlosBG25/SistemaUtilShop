using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public String empresa { get; set; }
        public String persona { get; set; }
        public int celular { get; set; }
        public String correo { get; set; }
    }
}
