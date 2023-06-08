using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class form_ventas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public form_ventas()
        {
            InitializeComponent();
        }

        cn_venta venta = new cn_venta();
        Venta v = new Venta();

        int stock;
        int resta;
        String cod_producto = "";
        string nom_producto;
        float p_unitario;

        List<String> valDNI = new List<String>() {"12345678","11111111", "22222222", "33333333", "44444444", "55555555",
        "66666666","77777777","88888888","99999999","00000000","98765432"};

        DataTable dtcodigos = new DataTable();

        private void frm_trabajador_Load(object sender, EventArgs e)
        {
            dtcodigos = venta.CodigosVentas();
            lblfactura.Text = dtcodigos.Rows[0]["codigo"].ToString(); // Nuevo codigo de factura

            lblfecha.Text = DateTime.Today.Date.ToString("d"); // captura la fecha actual
            Listar();

            cmbtrabajador.DataSource = venta.ListarTrabajador();
            cmbtrabajador.DisplayMember = "nombres";
            cmbtrabajador.ValueMember = "Id_trabajador";
            cmbtrabajador.SelectedIndex = -1;

            cmbfiltro.DataSource = venta.ListarCategoria();
            cmbfiltro.DisplayMember = "descripcion";
            cmbfiltro.ValueMember = "Id_categoria";
            cmbfiltro.SelectedIndex = -1;

            cmbtipodoc.DataSource = venta.LeerTipoDocumento();
            cmbtipodoc.DisplayMember = "Descripcion";
            cmbtipodoc.ValueMember = "Id_doc";
            cmbtipodoc.SelectedIndex = -1;

            btn_registrar.Enabled = false;
            btn_eliminar.Enabled = false;

        }


        private void Listar()
        {
            dgvproductos.DataSource = venta.LeerProducto();
            dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvproductos.Rows.Count > 0)
            {
                dgvproductos.Rows[0].Selected = false;
            }
        }

        private void Filtrar()
        {
            dgvproductos.DataSource = venta.FiltrarProductoVentas(cmbfiltro.Text);

            dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvproductos.Rows.Count > 0)
            {
                dgvproductos.Rows[0].Selected = false;
            }
        }

        private void Validar()
        {
            if (txtdni.TextLength > 7 && cmbtipodoc.SelectedItem != null && cmbtrabajador.SelectedItem != null)
            {
                btn_registrar.Enabled = true;
            }
            else
            {
                btn_registrar.Enabled = false;
            }
        }



        private void Limpiar()
        {
            nom_producto = "";
            txtcantidad.Value = 0;
            p_unitario = 0;
            cmbfiltro.SelectedIndex = -1;
            txtdni.Focus();
        }

        private bool ValidarDNI()
        {
            for (int i = 0; i < valDNI.Count; i++)
            {
                //Busca si el textbox dni contiene alguno de los numeros no permitidos.
                if (valDNI[i].Contains(txtdni.Text))
                {
                    return true;
                }
            }
            return false;
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

        private void GenerarBoleta()
        {
            SaveFileDialog imprimir = new SaveFileDialog();
            imprimir.FileName = ("Factura_UtilShop_") + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
            imprimir.DefaultExt = ".pdf";
            imprimir.Filter = "Archivos PDF (*.pdf)|*.pdf";

            string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DNI", lbldni.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@REGISTRADOR", lblregistrador.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", lblfecha.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMFACTURA", lblfactura.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvFactura.Rows)
            {

                filas += "<tr>";
                filas += "<td>" + row.Cells["codproducto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["nombrep"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["punitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["ptotal"].Value.ToString() + "</td>";
                filas += "</tr>";

            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", lblsubtotal.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IGV", lbligv.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", lblptotal.Text);


            if (imprimir.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(imprimir.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.iccono, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {

                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();

                    stream.Close();
                }

            }
        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvproductos.CurrentRow.Selected = true;

            cod_producto = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            nom_producto = dgvproductos.CurrentRow.Cells[1].Value.ToString();
            p_unitario = float.Parse(dgvproductos.CurrentRow.Cells[5].Value.ToString());
            stock = int.Parse(dgvproductos.CurrentRow.Cells[4].Value.ToString());

        }

        private void cmbfiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea volver al menú?", "Alerta",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }


        private void txtid_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmbtrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void cmbtipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            if (ValidarDNI())
            {
                MessageBox.Show("Numero de DNI Inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdni.Clear();
            }
            else 
            {
                v.Id_factura_Doc = cmbtipodoc.SelectedValue.ToString();
                v.dni_Cliente = txtdni.Text;
                v.Id_factura_Trabajador = cmbtrabajador.SelectedValue.ToString(); ;
                v.Id_factura_Producto = cod_producto;
                v.cantidad = int.Parse(txtcantidad.Value.ToString());
                v.precioUnitario = p_unitario;
                v.numerofactura = int.Parse(lblfactura.Text);

                resta = stock - v.cantidad;

                if (v.cantidad == 0)
                {
                    MessageBox.Show("La cantidad no puede ser 0", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (resta < 0)
                    {
                        MessageBox.Show("Stock Insuficiente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dgvFactura.Rows.Add(cod_producto, nom_producto, txtcantidad.Value, p_unitario,
                            float.Parse(txtcantidad.Value.ToString()) * p_unitario);

                        CalcularFactura();
                        venta.InsertarVenta(v);
                        Limpiar();
                        Listar();

                        lblregistrador.Text = cmbtrabajador.Text;
                        lbldni.Text = txtdni.Text;

                        txtdni.Enabled = false;
                        cmbtrabajador.Enabled = false;
                        cmbtipodoc.Enabled = false;

                    }
                }
            }




        }

        private void CalcularFactura()
        {
            // CALCULAMOS LOS IMPORTES A CADA INSERSION A DATAGRIVIEW CON LINQ
            int columnaPtotal = 4;

            float ptotal = dgvFactura.Rows.Cast<DataGridViewRow>()
                              .Sum(row => Convert.ToSingle(row.Cells[columnaPtotal].Value));

            lblsubtotal.Text = ptotal.ToString();
            lbligv.Text = (ptotal * 0.18).ToString();
            lblptotal.Text = (ptotal + (ptotal * 0.18)).ToString();
        }

        private void LimpiarCalculos()
        {
            lblsubtotal.Text = "00.00";
            lbligv.Text = "00.00";
            lblptotal.Text = "00.00";
            lbldni.Text = "";
            lblregistrador.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dc = MessageBox.Show("¿Seguro que desea eliminar el registro?", "UTILSHOP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dc == DialogResult.Yes)
                {
                    
                    dgvFactura.Rows.Remove(dgvFactura.CurrentRow);

                    // eliminar el producto en la base de datos
                    venta.BorrarVenta(v);
                    btn_eliminar.Enabled = false;

                    // calcular pagos
                    CalcularFactura();
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactura.Rows.Count > 0)
            {
                btn_eliminar.Enabled = true;
                dgvFactura.CurrentRow.Selected = true;
                v.Id_factura_Producto = dgvFactura.CurrentRow.Cells[0].Value.ToString();
                v.dni_Cliente = lbldni.Text;
                v.numerofactura = int.Parse(lblfactura.Text);
            }

        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validacion de campo numerico

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
            if (cmbtipodoc.Text != "Documento Nacional de Identidad")
            {
                e.Handled = false;
            }

        }

        private void btnboleta_Click(object sender, EventArgs e)
        {
            if (dgvFactura.RowCount >= 1)
            {
                btn_eliminar.Enabled = false;
                txtdni.Enabled = true;
                cmbtrabajador.Enabled = true;
                cmbtipodoc.Enabled = true;

                // Limpiamos la tabla de codigo y los campos
                dtcodigos.Clear();
                txtdni.Clear();
                cmbtrabajador.SelectedIndex = -1;
                cmbtipodoc.SelectedIndex = -1;

                dtcodigos = venta.CodigosVentas();

                // Ejecutamos en metodo para generar el PDF
                GenerarBoleta();
                // Se autocompleta el numero de factura con el ultimo codigo registrado + 1
                lblfactura.Text = dtcodigos.Rows[0]["codigo"].ToString();
                // LIMPIAMOS LA FACTURA
                dgvFactura.Rows.Clear();
                LimpiarCalculos();
            }
            else
            {
                MessageBox.Show("No existen datos en la factura", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void cmbtrabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = true;
        }

        private void cmbfiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbtipodoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbtipodoc_TextChanged(object sender, EventArgs e)
        {
            if (cmbtipodoc.Text != "Documento Nacional de Identidad")
            {
                txtdni.MaxLength = 15;
            }
            else
            {
                txtdni.MaxLength = 8;
            }
        }

        
    }
}
