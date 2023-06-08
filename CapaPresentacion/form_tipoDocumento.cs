using CapaEntidad;
using CapaNegocios;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class form_tipoDocumento : Form
    {
        cn_menu menu = new cn_menu();
        // codigo para mover el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        cn_tipo_Documento ndoc = new cn_tipo_Documento();
        int valor = 0;
        DataTable dtcodigo = new DataTable();


        public form_tipoDocumento()
        {
            InitializeComponent();
        }

        

        private void form_tipoDocumento_Load(object sender, EventArgs e)
        {
            Listar();
            btngrabar.Enabled = false;
            btnborrar.Enabled = false;
        }


        private void Listar() 
        {
            dtcodigo.Clear();
            dtcodigo = ndoc.CodigoDNI();
            txtcodigo.Text = dtcodigo.Rows[0]["codigo"].ToString();
            dgvdocumento.DataSource = ndoc.ListarDocumento();
            dgvdocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvdocumento.Rows.Count > 0) 
            {
                dgvdocumento.Rows[0].Selected = false;
            }
        }

        
        private void dgvdocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdocumento.Rows.Count > 0)
            {
                dgvdocumento.CurrentRow.Selected = true;

                txtcodigo.Text = dgvdocumento.CurrentRow.Cells[0].Value.ToString();
                txtdocumento.Text = dgvdocumento.CurrentRow.Cells[1].Value.ToString();
                txtdescripcion.Text = dgvdocumento.CurrentRow.Cells[2].Value.ToString();

                valor = 1; // editar

                btnborrar.Enabled = true;

                txtdocumento.Enabled = true;
                txtdescripcion.Enabled = true;

                txtdocumento.Focus();
            }
        }


        private void Validar()
        {
            if (txtcodigo.TextLength > 0 && txtdocumento.TextLength > 0 && txtdescripcion.TextLength > 0)
            {
                btngrabar.Enabled = true;
            }
            else
            {
                btngrabar.Enabled = false;
            }
        }


        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }


        private void Limpiar()
        {
            txtcodigo.Clear();
            txtdocumento.Clear();
            txtdescripcion.Clear();
            txtdocumento.Focus();
        }


        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtdocumento.Enabled = true;
            txtdescripcion.Enabled = true;
            valor = 0;
            Limpiar();
            Listar();
            btnborrar.Enabled = false;
            
        }


        private void btngrabar_Click(object sender, EventArgs e)
        {
            TipoDocumento doc = new TipoDocumento();

            doc.id_doc = txtcodigo.Text;
            doc.tipo_Doc = txtdocumento.Text;
            doc.descripcion= txtdescripcion.Text;

            if (valor == 0)
            {
                ndoc.RegistrarDocumento(doc);
            }
            else if (valor == 1)
            {
                ndoc.EditarDocumento(doc);
            }
            

            Limpiar();
            Listar();

            btnborrar.Enabled = false;
            txtdocumento.Enabled = false;
            txtdescripcion.Enabled = false;
        }

        

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult dc = MessageBox.Show("Confirmar la operación Borrar", "DELOSI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dc == DialogResult.Yes)
            {
                ndoc.BorrarDocumento(txtcodigo.Text);

                valor = 0;
                Limpiar();
                Listar();
                btnborrar.Enabled = false;
                txtdocumento.Enabled = false;
                txtdescripcion.Enabled = false;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
