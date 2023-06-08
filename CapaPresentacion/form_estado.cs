using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class form_estado : Form
    {
        // codigo para mover el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        cn_estado nestado = new cn_estado();
        int valor = 0;
        int id;
        public form_estado()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            dgvpais.DataSource = nestado.REstado();
            dgvpais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvpais.Rows.Count > 0)
            {
                dgvpais.Rows[0].Selected = false;
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

        private void Limpiar()
        {
            id = 0;
            txtnombre.Clear();
            txtnombre.Focus();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            valor = 0;
            Limpiar();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();

            estado.Id_estado = id;
            estado.estado = txtnombre.Text;

            if (valor == 0)
            {
                nestado.CEstado(estado);
            }
            else if (valor == 1)
            {
                nestado.UEstado(estado);
            }


            Listar();
            Limpiar();

            btnborrar.Enabled = false;
            txtnombre.Enabled = false;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult dc = MessageBox.Show("Confirmar la operación Borrar", "DELOSI",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dc == DialogResult.Yes)
            {
                nestado.DEstado(id);

                txtnombre.Clear();
                txtnombre.Enabled = false;
                Listar();
                btnborrar.Enabled = false;
            }
        }

        private void dgvpais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpais.Rows.Count > 0)
            {
                dgvpais.CurrentRow.Selected = true;

                id = int.Parse(dgvpais.CurrentRow.Cells[0].Value.ToString());
                txtnombre.Text = dgvpais.CurrentRow.Cells[1].Value.ToString();

                valor = 1; // editar

                btnborrar.Enabled = true;
                txtnombre.Enabled = true;
            }
        }

        private void form_Pais_Load(object sender, EventArgs e)
        {
            Listar();
            btngrabar.Enabled = false;
            btnborrar.Enabled = false;
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
