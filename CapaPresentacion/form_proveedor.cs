using CapaEntidad;
using CapaNegocios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class form_proveedor : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public form_proveedor()
        {
            InitializeComponent();
        }

        cn_proveedor nProv = new cn_proveedor();
        int valor = 0;
        int id;

        private void Listar()
        {
            dgvrenovacion.DataSource = nProv.ListarProveedor();
            dgvrenovacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvrenovacion.Rows.Count > 0)
            {
                dgvrenovacion.Rows[0].Selected = false;
            }
        }

        private void frm_renovacion_contrato_Load(object sender, EventArgs e)
        {
            Listar();
            btngrabar.Enabled = false;
            btnborrar.Enabled = false;

        }

        private void dgvrenovacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvrenovacion.Rows.Count > 0)
            {
                dgvrenovacion.CurrentRow.Selected = true;

                id = int.Parse(dgvrenovacion.CurrentRow.Cells[0].Value.ToString());
                txtempresa.Text = dgvrenovacion.CurrentRow.Cells[1].Value.ToString();
                txtpersona.Text = dgvrenovacion.CurrentRow.Cells[2].Value.ToString();
                txtcelular.Text = dgvrenovacion.CurrentRow.Cells[3].Value.ToString();
                txtcorreo.Text = dgvrenovacion.CurrentRow.Cells[4].Value.ToString();

                valor = 1; // editar
                btnborrar.Enabled = true;
                TxtON();
            }
        }

        private void Limpiar()
        {
            id = 0;
            txtempresa.Clear();
            txtpersona.Clear();
            txtcelular.Clear();
            txtcorreo.Clear();

            txtpersona.Focus();
        }

        private void TxtOFF()
        {
            txtempresa.Enabled = false;
            txtpersona.Enabled = false;
            txtcelular.Enabled = false;
            txtcorreo.Enabled = false;
        }

        private void TxtON()
        {
            txtempresa.Enabled = true;
            txtpersona.Enabled = true;
            txtcelular.Enabled = true;
            txtcorreo.Enabled = true;
        }
        private void Validar()
        {
            if (txtpersona.TextLength > 0 && txtcorreo.TextLength > 0
                && txtempresa.TextLength > 0 && txtcelular.TextLength > 0)
            {
                btngrabar.Enabled = true;
            }
            else
            {
                btngrabar.Enabled = false;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            TxtON();
            valor = 0;
            Limpiar();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            ValidacionCorreo();

            if (ValidacionCorreo() == true)
            {
                if(txtcelular.TextLength == 9)
                {
                    Proveedor p = new Proveedor();

                    p.id_proveedor = id;
                    p.empresa = txtempresa.Text;
                    p.persona = txtpersona.Text;
                    p.celular = int.Parse(txtcelular.Text);
                    p.correo = txtcorreo.Text;

                    if (valor == 0)
                    {
                        nProv.RegistrarProveedor(p);
                    }
                    else if (valor == 1)
                    {
                        nProv.EditarProveedor(p);
                    }

                    Limpiar();
                    Listar();
                    btnborrar.Enabled = false;
                    TxtOFF();
                }
               else
                {
                    MessageBox.Show("El N° de celular debe contener 9 dígitos", "Alerta");
                }

            }
            else
            {
                MessageBox.Show("El correo es inválido. Debe contener el carácter '@'.", "Alerta");
            }
            
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult dc = MessageBox.Show("Confirmar la operación Borrar", "UTILSHOP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dc == DialogResult.Yes)
            {
                nProv.BorrarProveedor(id);

                Limpiar();
                TxtOFF();
                Listar();
                btnborrar.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frm_renovacion_contrato_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtpersona_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtempresa_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        /*
            VALIDACION DE CAMPOS TEXTBOX
         */

        private void Esletra(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }

        private bool ValidacionCorreo()
        {
            string correo = txtcorreo.Text;

            if (correo.Contains("@"))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtpersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            Esletra(sender, e);

        }

        private void txtempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Esletra(sender, e);
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true; // Si no es Numero cancela el evento KeyPress
            }
        }
    }
}
