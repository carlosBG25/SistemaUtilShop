using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public string Id_producto { get; set; }
        public string nombre { get; set; }
        public int id_productoCateg { get; set; }
        public int id_productoProveedor { get; set; }
        public int stock { get; set; }
        public float precioUnitario { get; set; }

    }
}
