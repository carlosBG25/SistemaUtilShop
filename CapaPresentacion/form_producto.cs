using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;
using System.Runtime.InteropServices;
using System.Data;

namespace CapaPresentacion
{
    public partial class form_producto : Form
    {
        // codigo para mover el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        cn_producto nproducto = new cn_producto();
        Producto p = new Producto();


        int valor = 0; // CAMBIO DE ESTADOS - CREAR - ACTUALIZAR - ELIMINAR
        DataTable dtcodigo = new DataTable();

        public form_producto()
        {
            InitializeComponent();
        }

        private void frm_familiar_Load(object sender, EventArgs e)
        {

            Listar();
            Cuenta();

            btngrabar.Enabled = false;
            btnborrar.Enabled = false;

            cmbcategoria.DataSource = nproducto.ListarCategoria();
            cmbcategoria.DisplayMember = "descripcion";
            cmbcategoria.ValueMember = "Id_categoria";
            cmbcategoria.SelectedIndex = -1;


            cmbproveedor.DataSource = nproducto.ListarProveedor();
            cmbproveedor.DisplayMember = "empresa";
            cmbproveedor.ValueMember = "Id_proveedor";
            cmbproveedor.SelectedIndex = -1;

            cmbfiltro.DataSource = nproducto.ListarCategoria();
            cmbfiltro.DisplayMember = "descripcion";
            cmbfiltro.ValueMember = "Id_categoria";
            cmbfiltro.SelectedIndex = -1;
            
        }

        private void Cuenta()
        {
            lblcuenta.Text = dgvfamiliar.RowCount.ToString();
        }

        private void Listar()
        {
            dtcodigo.Clear();
            dtcodigo = nproducto.CodigoProducto();
            txtid.Text = dtcodigo.Rows[0]["codigo"].ToString();
            dgvfamiliar.DataSource = nproducto.ListarProducto();
            dgvfamiliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvfamiliar.Rows.Count > 0)
            {
                dgvfamiliar.Rows[0].Selected = false;
            }
        }

        private void Filtrar()
        {

            dgvfamiliar.DataSource = nproducto.FiltrarProducto(cmbfiltro.Text);

            dgvfamiliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvfamiliar.Rows.Count > 0)
            {
                dgvfamiliar.Rows[0].Selected = false;
            }
        }

        private void Limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
            cmbcategoria.SelectedIndex = -1;
            cmbproveedor.SelectedIndex = -1;
            txtstock.Value = txtstock.Minimum;
            txtpreciounitario.Clear();
            cmbfiltro.SelectedIndex = -1;
            txtnombre.Focus();
        }

        private void Validar()
        {
            if (txtid.TextLength > 0 && txtnombre.TextLength > 0 && txtpreciounitario.TextLength > 0
                && cmbcategoria.SelectedItem != null && cmbproveedor.SelectedItem != null)
            {
                btngrabar.Enabled = true;
            }
            else
            {
                btngrabar.Enabled = false;
            }
        }

        private void dgvfamiliar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvfamiliar.Rows.Count > 0)
            {
                dgvfamiliar.CurrentRow.Selected = true;
                txtid.Text = dgvfamiliar.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = dgvfamiliar.CurrentRow.Cells[1].Value.ToString();
                cmbcategoria.Text = dgvfamiliar.CurrentRow.Cells[2].Value.ToString();
                cmbproveedor.Text = dgvfamiliar.CurrentRow.Cells[3].Value.ToString();
                txtstock.Value = decimal.Parse(dgvfamiliar.CurrentRow.Cells[4].Value.ToString());
                txtpreciounitario.Text = dgvfamiliar.CurrentRow.Cells[5].Value.ToString();


                valor = 1; // editar
                btnborrar.Enabled = true;
                btngrabar.Enabled = true;

            }

            
        }



        private void btnnuevo_Click(object sender, EventArgs e)
        {
            valor = 0;
            Limpiar();
            Listar();
            btnborrar.Enabled = false;
            btngrabar.Enabled = false;
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            btnborrar.Enabled = false;

            p.Id_producto = txtid.Text;
            p.nombre = txtnombre.Text;
            p.id_productoCateg = int.Parse(cmbcategoria.SelectedValue.ToString());
            p.id_productoProveedor = int.Parse(cmbproveedor.SelectedValue.ToString());
            p.stock = int.Parse(txtstock.Value.ToString());
            p.precioUnitario = float.Parse(txtpreciounitario.Text);

            if (valor == 0)
            {
                nproducto.RegistrarProducto(p);
            }
            else if (valor == 1)
            {
                nproducto.EditarProducto(p);
            }
            Limpiar();
            Listar();
            Cuenta();
            
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabezera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmbfiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
            Cuenta();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

            DialogResult dc = MessageBox.Show("¿Seguro que desea eliminar el registro?", "ÙTILSHOP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dc == DialogResult.Yes)
            {
                nproducto.BorrarProducto(txtid.Text);
                Limpiar();
                Listar();
                Cuenta();
                valor = 0;
                btnborrar.Enabled = false;
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtpreciounitario_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmbproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtpreciounitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Si no es Numero cancela el evento KeyPress
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true; // Cancela el evento KeyPress si ya hay un punto presente
            }
        }

        private void BloquearCMB(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }

        private void cmbcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearCMB(sender, e);
        }

        private void cmbproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearCMB(sender, e);
        }

        private void cmbfiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearCMB(sender, e);
        }

        
    }
}
