using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_bienvenida());
        }
    }
}
