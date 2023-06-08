using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public string Id_factura_Producto { get; set; }
        public string Id_factura_Doc { get; set; }
        public string dni_Cliente { get; set; }
        public string Id_factura_Trabajador { get; set; }
        public int cantidad { get; set; }
        public float precioUnitario { get; set; }
        public int numerofactura { get; set; }

    }
}
