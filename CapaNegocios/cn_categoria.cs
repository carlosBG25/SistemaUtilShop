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
    public class cn_categoria
    {
        m_categoria m_cat = new m_categoria();

        public void CreateCategoria(Categoria cat)
        {
            m_cat.CreateCategoria(cat);
        }

        public DataTable ReadCategoria()
        {
            return m_cat.ReadCategoria();
        }


        public void UpdateCategoria(Categoria cat)
        {
            m_cat.UpdateCategoria(cat);
        }

        public void DeleteCategoria(int cat)
        {
            m_cat.DeleteCategoria(cat);
        }
    }
}
