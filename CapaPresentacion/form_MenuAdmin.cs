using System;
using System.Windows.Forms;
// libreria para mover el formulario sin bordes 
using System.Runtime.InteropServices;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class form_MenuAdmin : Form
    {

        cn_menu menu = new cn_menu();

        // codigo para mover el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public form_MenuAdmin()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            cgvrxc.DataSource = menu.RDetalleFacturas();
            cgvrxc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void Filtrar()
        {
            cgvrxc.DataSource = menu.FiltrarFacturas(txtfiltro.Text);

            cgvrxc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (cgvrxc.Rows.Count > 0)
            {
                cgvrxc.Rows[0].Selected = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnRenovacion_Click(object sender, EventArgs e)
        {
            // CRUD DE TIPOS DE USUARIO
            form_tipo_usuario tipo_usuario = new form_tipo_usuario();
            tipo_usuario.ShowDialog();
        }


        private void btnFamiliar_Click(object sender, EventArgs e)
        {
            // CRUD DE PROVEEDORES
            form_proveedor proveedor = new form_proveedor();
            proveedor.ShowDialog();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            // CRUD DE ESTADO DE CUENTAS
            form_estado estado = new form_estado();
            estado.ShowDialog();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            // CRUD DE LOGIN DE TRABAJADORES
            form_trabajador trabajador = new form_trabajador();
            trabajador.ShowDialog();
        }

        private void btn_contrato_Click(object sender, EventArgs e)
        {
            // CRUD DE TIPOS DE DOCUMENTO
            form_tipoDocumento tipo_documento = new form_tipoDocumento();
            tipo_documento.ShowDialog();
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cgvrxc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cgvrxc.Rows.Count > 0)
            {
                cgvrxc.CurrentRow.Selected = true;
                txtfiltro.Text = cgvrxc.CurrentRow.Cells[1].Value.ToString();
            }
        }



        private void form_MenuAdmin_Load(object sender, EventArgs e)
        {
            Cuenta();
            Listar();

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Listar();
            Cuenta();

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere Cerrar Sesión?", "Alerta",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }


        private void btn_horario_Click(object sender, EventArgs e)
        {
            // CRUD DE CATEGORIAS
            form_categoria categoria = new form_categoria();
            categoria.ShowDialog();
        }

        private void btn_familiar_Click(object sender, EventArgs e)
        {
            // CRUD DE PRODUCTOS
            form_producto producto = new form_producto();
            producto.ShowDialog();
        }

        private void txtsueldo_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
            Cuenta();
        }

        private void Cuenta()
        {
            lblcuenta.Text = cgvrxc.RowCount.ToString();
        }
    }
}
