using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocios;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();

        }

        cn_Login login = new cn_Login();
        // codigo para mover el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "USUARIO")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.LightGray;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "USUARIO";
                txtId.ForeColor = Color.DimGray;
            }
        }

        private void txtpsw_Enter(object sender, EventArgs e)
        {
            if (txtpsw.Text == "CONTRASEÑA")
            {
                txtpsw.Text = "";
                txtpsw.ForeColor = Color.LightGray;
                txtpsw.UseSystemPasswordChar = true; // --> Esconder caracteres
            }
        }

        private void txtpsw_Leave(object sender, EventArgs e)
        {
            if (txtpsw.Text == "")
            {
                txtpsw.Text = "CONTRASEÑA";
                txtpsw.ForeColor = Color.DimGray;
                txtpsw.UseSystemPasswordChar = false; 
            }
        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void from_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            // validar si los campos txt tienen valor

            if (txtId.Text != "USUARIO")
            {
                if (txtpsw.Text != "CONTRASEÑA")
                {
                    Login l = new Login();
                    l.usuario = txtId.Text;
                    l.password = txtpsw.Text;
                    var validarLogin = login.LoginAdmin(l);

                    // verificar si existe usuario y contraseña
                    if (validarLogin == true)
                    {
                        form_MenuAdmin MenuPrincipal = new form_MenuAdmin();
                        MenuPrincipal.Show();
                        // ejecutar metodo CerrarSesion cuando se cierre el formulario
                        // se sobrecarga el evento FormClosed con el metodo CerrarSesion
                        MenuPrincipal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MsgError("Usuario o Contraseña incorrectos. \nPor favor, intente nuevamente");
                        txtpsw.Text = "CONTRASEÑA";
                        txtId.Text = "USUARIO";
                        txtId.Focus();
                    }
                }
                else
                {
                    lb_ErrorMessagge.Text = "Por favor, Ingrese su Contraseña";
                }

            }
            else
            {
                lb_ErrorMessagge.Text = "Por favor, Ingrese su Usuario";
            }


        }

        private void MsgError(string msg)
        {
            lb_ErrorMessagge.Text = "╳ " + msg;
            lb_ErrorMessagge.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtpsw.Text = "CONTRASEÑA";
            txtpsw.UseSystemPasswordChar = false;
            txtId.Text = "USUARIO";
            lb_ErrorMessagge.Visible = false;
            this.Show();
            txtId.Focus();
            
 
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea volver al menú?", "Alerta",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
