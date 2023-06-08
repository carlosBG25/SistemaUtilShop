using System;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidad;
using System.Runtime.InteropServices;


namespace CapaPresentacion
{
    public partial class form_tipo_usuario : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public form_tipo_usuario()
        {
            InitializeComponent();

        }

        cn_tipo_usuario n_tUser = new cn_tipo_usuario();
        int valor = 0; // nuevo
        int id;

        private void frm_tipo_desempenio_Load(object sender, EventArgs e)
        {
            Listar();
            btngrabar.Enabled = false;
            btnborrar.Enabled = false;
        }

        private void Listar() 
        {
            dgvtipo_desempenio.DataSource = n_tUser.Readtipo_Usuario();
            dgvtipo_desempenio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvtipo_desempenio.Rows.Count > 0)
            { 
                dgvtipo_desempenio.Rows[0].Selected = false; 
            }
 
        }

        private void dgvtipo_desempenio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtipo_desempenio.Rows.Count > 0)
            {
                dgvtipo_desempenio.CurrentRow.Selected = true;

                id = int.Parse(dgvtipo_desempenio.CurrentRow.Cells[0].Value.ToString());
                txtnombre.Text = dgvtipo_desempenio.CurrentRow.Cells[1].Value.ToString();

                valor = 1; // editar

                btnborrar.Enabled = true;
                txtnombre.Enabled = true;
            }
        }

        private void Validar() 
        {
            if (txtnombre.TextLength > 0)
            { 
                btngrabar.Enabled = true;
            }
            else
            { 
                btngrabar.Enabled = false; 
            }
        }

        private void txtdesempenio_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            valor = 0;
            Limpiar();

        }

        private void Limpiar() 
        {
            id = 0;
            txtnombre.Clear();
            txtnombre.Focus();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            TipoUsuario tuser = new TipoUsuario();
            tuser.id_tipoUser = id;
            tuser.nombre = txtnombre.Text;

            if (valor == 0)
            {
                n_tUser.Createtipo_Usuario(tuser); 
            }
            else if (valor == 1)
            {
                n_tUser.Updatetipo_Usuario(tuser); 
            }

            Listar();
            Limpiar();
            btnborrar.Enabled = false;
            txtnombre.Enabled = false;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro de borrar?", "SENATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) 
            {
                n_tUser.Deletetipo_Usuario(id);

                Listar();
                txtnombre.Clear();
                txtnombre.Enabled = false;
                btnborrar.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }
    }
}
