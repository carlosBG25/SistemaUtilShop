using System;
using System.Data;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class form_trabajador : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public form_trabajador()
        {
            InitializeComponent();
        }

        int valor = 0;
        DataTable dtcodigo = new DataTable();
        cn_trabajador ntra = new cn_trabajador();

        List<String> valDNI = new List<String>() {"12345678","11111111", "22222222", "33333333", "44444444", "55555555",
        "66666666","77777777","88888888","99999999","00000000","98765432"};

        private void frm_trabajador_Load(object sender, EventArgs e)
        {
            btngrabar.Enabled = false;
            btnborrar.Enabled = false;

            Listar();
            Cuenta();
            cmb_tipodoc.DataSource = ntra.ListarTipoDocumento();
            cmb_tipodoc.DisplayMember = "Tipo_Doc";
            cmb_tipodoc.ValueMember = "Id_doc";
            cmb_tipodoc.SelectedIndex = -1;


            cmb_tipouser.DataSource = ntra.ListarTipoUsuario();
            cmb_tipouser.DisplayMember= "nombre";
            cmb_tipouser.ValueMember = "Id_tipoUser";
            cmb_tipouser.SelectedIndex= -1;

            cmb_estado.DataSource = ntra.ListarEstado();
            cmb_estado.DisplayMember = "estado";
            cmb_estado.ValueMember = "Id_estado";
            cmb_estado.SelectedIndex = -1;
        }

        private void Cuenta() 
        {
            lblcuenta.Text = dgvtrabajador.RowCount.ToString();
        }
        private void Listar()
        {
            dtcodigo.Clear();
            dtcodigo = ntra.CodigoTrabajador();
            txtid.Text = dtcodigo.Rows[0]["codigo"].ToString();

            dgvtrabajador.DataSource = ntra.ListarTrabajador();
            dgvtrabajador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvtrabajador.Rows.Count > 0)
            {
                dgvtrabajador.Rows[0].Selected = false;
            }
        }

        private void Filtrar()
        {
            dgvtrabajador.DataSource = ntra.FiltrarTrabajador(txtfiltro.Text);

            dgvtrabajador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvtrabajador.Rows.Count > 0)
            {
                dgvtrabajador.Rows[0].Selected = false;
            }
        }

        private void Limpiar()
        {
            txtid.Clear();
            txtusuario.Clear();
            txtpsw.Clear();
            txtnombres.Clear();
            txtapaterno.Clear();
            txtamaterno.Clear();
            cmb_tipodoc.SelectedIndex = -1;
            num_doc.Clear();
            cmb_tipouser.SelectedIndex = -1;
            cmb_estado.SelectedIndex = -1;
            txtfiltro.Clear();

            txtnombres.Focus();
        }

        private void TxtON()
        {
            txtnombres.Enabled = true;
            txtapaterno.Enabled = true;
            txtamaterno.Enabled = true;
            cmb_tipodoc.Enabled = true;
            num_doc.Enabled = true;
            cmb_tipouser.Enabled = true;
            txtusuario.Enabled = true;
            txtpsw.Enabled = true;
            cmb_estado.Enabled = true;

        }
        private void TxtOFF()
        {
            txtnombres.Enabled = false;
            txtapaterno.Enabled = false;
            txtamaterno.Enabled = false;
            cmb_tipodoc.Enabled = false;
            num_doc.Enabled = false;
            cmb_tipouser.Enabled = false;
            txtusuario.Enabled = false;
            txtpsw.Enabled = false;
            cmb_estado.Enabled = false;

        }

        private void dgvtrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtrabajador.Rows.Count > 0)
            {
                dgvtrabajador.CurrentRow.Selected = true;

                txtid.Text = dgvtrabajador.CurrentRow.Cells[0].Value.ToString();
                txtusuario.Text = dgvtrabajador.CurrentRow.Cells[1].Value.ToString();
                txtpsw.Text = dgvtrabajador.CurrentRow.Cells[2].Value.ToString();
                txtnombres.Text = dgvtrabajador.CurrentRow.Cells[3].Value.ToString();
                txtapaterno.Text = dgvtrabajador.CurrentRow.Cells[4].Value.ToString();
                txtamaterno.Text = dgvtrabajador.CurrentRow.Cells[5].Value.ToString();
                cmb_tipodoc.Text = dgvtrabajador.CurrentRow.Cells[6].Value.ToString();
                num_doc.Text = dgvtrabajador.CurrentRow.Cells[7].Value.ToString();
                cmb_tipouser.Text = dgvtrabajador.CurrentRow.Cells[8].Value.ToString();
                cmb_estado.Text = dgvtrabajador.CurrentRow.Cells[9].Value.ToString();

                valor = 1; // editar
                btnborrar.Enabled = true;
                btngrabar.Enabled = true;
                TxtON();
            }
        }

        private void Validar()
        {
            if (txtid.TextLength > 0 && txtusuario.TextLength > 0 && txtpsw.TextLength > 0 && num_doc.TextLength > 7
                && cmb_tipodoc.SelectedItem != null && cmb_tipouser.SelectedItem != null && cmb_estado.SelectedItem != null)
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
            valor = 0;
            TxtON();
            Limpiar();
            Listar();
            btnborrar.Enabled = false;
        }

        private bool ValidarDNI()
        {
            for (int i = 0; i < valDNI.Count; i++)
            {
                //Busca si el textbox dni contiene alguno de los numeros no permitidos.
                if (valDNI[i].Contains(num_doc.Text))
                {
                    return true;
                }
            }
            return false;
        }
        private void btngrabar_Click(object sender, EventArgs e)
        {
            

            if (ValidarDNI())
            {
                MessageBox.Show("Numero de DNI Inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num_doc.Clear();
            }
            else
            {
                Trabajador t = new Trabajador();
                t.Id_trabajador = txtid.Text;
                t.login_Trabajador = txtusuario.Text;
                t.password = txtpsw.Text;
                t.nombres = txtnombres.Text;
                t.Ap_Paterno = txtapaterno.Text;
                t.Ap_Materno = txtamaterno.Text;
                t.Id_doc_trabajador = cmb_tipodoc.SelectedValue.ToString();
                t.numero_documento = num_doc.Text;
                t.id_trabajadorTipoUser = int.Parse(cmb_tipouser.SelectedValue.ToString());
                t.id_trabajadorEstado = int.Parse(cmb_estado.SelectedValue.ToString());

                if (valor == 0)
                {
                    ntra.RegistrarTrabajador(t);
                }
                else if (valor == 1)
                {
                    ntra.EditarTrabajador(t);
                }
                Limpiar();
                Listar();
                Cuenta();
                TxtOFF();

                btnborrar.Enabled = false;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult dc = MessageBox.Show("¿Seguro que desea eliminar el registro?", "ÙTILSHOP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dc == DialogResult.Yes)
            {
                ntra.BorrarTrabajador(txtid.Text);
                valor = 0;
                Limpiar();
                Listar();
                TxtOFF();
                btnborrar.Enabled = false;
            }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
            //txtfiltro.Clear();
            //txtfiltro.Focus();
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


        private void txtid_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtpsw_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void num_doc_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void cmb_tipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmb_tipouser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
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

        private void EsNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
            if (cmb_tipodoc.Text != "DNI")
            {
                e.Handled = false;
            }
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Esletra(sender,e);
        }

        private void txtapaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Esletra(sender, e);
        }

        private void txtamaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Esletra(sender, e);
        }

        private void num_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsNumero(sender, e);
        }

        private void BloquearCMB(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = true;
           
        }

        private void cmb_tipodoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearCMB(sender,e);
        }

        private void cmb_tipouser_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearCMB(sender, e);
        }
        

        private void cmb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearCMB(sender, e);
        }

        private void cmb_tipodoc_TextChanged(object sender, EventArgs e)
        {
            if (cmb_tipodoc.Text == "DNI")
            {
                num_doc.MaxLength = 8;
            }
            else
            {
                num_doc.MaxLength = 15;
            }
        }

    }
}
