using System;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidad;
using System.Runtime.InteropServices;


namespace CapaPresentacion
{
    public partial class form_categoria : Form
    {
        // codigo para mover el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        cn_categoria cn_cat = new cn_categoria();
        int valor = 0; // nuevo
        int id;
        public form_categoria()
        {
            InitializeComponent();
            
        }

        private void form_categoria_Load(object sender, EventArgs e)
        {
            Listar();
            btngrabar.Enabled = false;
            tbn_delete.Enabled = false;
        }


        private void Listar()
        {
            dgvEstadoR.DataSource = cn_cat.ReadCategoria();
            dgvEstadoR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvEstadoR.Rows.Count > 0)
                dgvEstadoR.Rows[0].Selected = false;

        }

        private void dgvEstadoR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstadoR.Rows.Count > 0)
            {

                dgvEstadoR.CurrentRow.Selected = true;

                id = int.Parse(dgvEstadoR.CurrentRow.Cells[0].Value.ToString());
                txtnombre.Text = dgvEstadoR.CurrentRow.Cells[1].Value.ToString();
                valor = 1; // editar
                tbn_delete.Enabled = true;
                txtnombre.Enabled = true;
            }

        }

        private void Validar()
        {
            if (txtnombre.TextLength > 0 )
            {
                btngrabar.Enabled = true;
            }
            else
            {
                btngrabar.Enabled = false;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void Limpiar()
        {
            id = 0;
            txtnombre.Clear();
            txtnombre.Focus();
        }

        private void tbn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirmar la operación Borrar","SENATI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                cn_cat.DeleteCategoria(id);

                valor = 0;
                Limpiar();
                txtnombre.Enabled = false;
                Listar();
                tbn_delete.Enabled = false;

            }
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.id_categoria = id;
            cat.descripcion = txtnombre.Text;

            if (valor == 0)
            {
                cn_cat.CreateCategoria(cat);
            }
            else if (valor == 1)
            {
                cn_cat.UpdateCategoria(cat);

            }

            Limpiar();
            Listar();
            tbn_delete.Enabled = false;
            txtnombre.Enabled = false;

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;

            valor = 0;
            Limpiar();
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

        
    }
}
