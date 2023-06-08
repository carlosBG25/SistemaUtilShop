using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CapaPresentacion
{
    public partial class form_bienvenida : Form
    {
        // codigo para mover el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public form_bienvenida()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btntrabajador_Click(object sender, EventArgs e)
        {
            form_ventas venta = new form_ventas();
            venta.Show();
            this.Hide();
            venta.FormClosed += CerrarSesion;
            this.Hide();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {

            form_Login login = new form_Login();
            login.Show();
            this.Hide();
            login.FormClosed += CerrarSesion;
            this.Hide();

        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void form_bienvenida_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void form_bienvenida_Load(object sender, EventArgs e)
        {
            
        }
    }
}
