
namespace CapaPresentacion
{
    partial class form_MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHorario = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_contrato = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnRenovacion = new System.Windows.Forms.Button();
            this.btn_familiar = new System.Windows.Forms.Button();
            this.btnContrato = new System.Windows.Forms.Button();
            this.btn_horario = new System.Windows.Forms.Button();
            this.btnFamiliar = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cgvrxc = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgvrxc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.header.Controls.Add(this.btnRestaurar);
            this.header.Controls.Add(this.btnMaximizar);
            this.header.Controls.Add(this.btnMinimizar);
            this.header.Controls.Add(this.btnCerrar);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1167, 44);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::CapaPresentacion.Properties.Resources.Icono_Restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(1094, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(34, 32);
            this.btnRestaurar.TabIndex = 8;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::CapaPresentacion.Properties.Resources.Icono_Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(1094, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 32);
            this.btnMaximizar.TabIndex = 7;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.Icono_Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1056, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(41, 31);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrar.Location = new System.Drawing.Point(1130, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 32);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnHorario);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btn_contrato);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.btnCerrarSesion);
            this.MenuVertical.Controls.Add(this.btnRenovacion);
            this.MenuVertical.Controls.Add(this.btn_familiar);
            this.MenuVertical.Controls.Add(this.btnContrato);
            this.MenuVertical.Controls.Add(this.btn_horario);
            this.MenuVertical.Controls.Add(this.btnFamiliar);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 44);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(252, 628);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.utilshop;
            this.pictureBox1.Location = new System.Drawing.Point(30, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHorario
            // 
            this.btnHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.Image = global::CapaPresentacion.Properties.Resources.icons8_antecedentes_grupo_seleccionado_24;
            this.btnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorario.Location = new System.Drawing.Point(12, 113);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(227, 29);
            this.btnHorario.TabIndex = 6;
            this.btnHorario.Text = "ACCESOS LOGIN";
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(252, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(915, 40);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(252, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 43);
            this.panel3.TabIndex = 12;
            // 
            // btn_contrato
            // 
            this.btn_contrato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_contrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contrato.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contrato.ForeColor = System.Drawing.Color.White;
            this.btn_contrato.Image = global::CapaPresentacion.Properties.Resources.icons8_acuerdo_24;
            this.btn_contrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contrato.Location = new System.Drawing.Point(12, 377);
            this.btn_contrato.Name = "btn_contrato";
            this.btn_contrato.Size = new System.Drawing.Size(227, 29);
            this.btn_contrato.TabIndex = 10;
            this.btn_contrato.Text = "TIPOS DE DOCUMENTO";
            this.btn_contrato.UseVisualStyleBackColor = true;
            this.btn_contrato.Click += new System.EventHandler(this.btn_contrato_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.icons8_salida_24;
            this.pictureBox2.Location = new System.Drawing.Point(13, 578);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(75, 578);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(113, 38);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnRenovacion
            // 
            this.btnRenovacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnRenovacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnRenovacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovacion.ForeColor = System.Drawing.Color.White;
            this.btnRenovacion.Image = global::CapaPresentacion.Properties.Resources.icons8_hombre_menú_de_usuario_24;
            this.btnRenovacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovacion.Location = new System.Drawing.Point(12, 497);
            this.btnRenovacion.Name = "btnRenovacion";
            this.btnRenovacion.Size = new System.Drawing.Size(227, 29);
            this.btnRenovacion.TabIndex = 5;
            this.btnRenovacion.Text = "TIPOS DE USUARIO";
            this.btnRenovacion.UseVisualStyleBackColor = true;
            this.btnRenovacion.Click += new System.EventHandler(this.btnRenovacion_Click);
            // 
            // btn_familiar
            // 
            this.btn_familiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_familiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_familiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_familiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_familiar.ForeColor = System.Drawing.Color.White;
            this.btn_familiar.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_regular_24;
            this.btn_familiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_familiar.Location = new System.Drawing.Point(12, 178);
            this.btn_familiar.Name = "btn_familiar";
            this.btn_familiar.Size = new System.Drawing.Size(227, 29);
            this.btn_familiar.TabIndex = 2;
            this.btn_familiar.Text = "PRODUCTOS";
            this.btn_familiar.UseVisualStyleBackColor = true;
            this.btn_familiar.Click += new System.EventHandler(this.btn_familiar_Click);
            // 
            // btnContrato
            // 
            this.btnContrato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnContrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrato.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrato.ForeColor = System.Drawing.Color.White;
            this.btnContrato.Image = global::CapaPresentacion.Properties.Resources.icons8_desbloquear_24;
            this.btnContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContrato.Location = new System.Drawing.Point(12, 313);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(227, 29);
            this.btnContrato.TabIndex = 4;
            this.btnContrato.Text = "ESTADO DE CUENTAS";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // btn_horario
            // 
            this.btn_horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_horario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_horario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_horario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_horario.ForeColor = System.Drawing.Color.White;
            this.btn_horario.Image = global::CapaPresentacion.Properties.Resources.icons8_clasificación_de_respuestas_241;
            this.btn_horario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_horario.Location = new System.Drawing.Point(12, 438);
            this.btn_horario.Name = "btn_horario";
            this.btn_horario.Size = new System.Drawing.Size(227, 29);
            this.btn_horario.TabIndex = 1;
            this.btn_horario.Text = "CATEGORIAS";
            this.btn_horario.UseVisualStyleBackColor = false;
            this.btn_horario.Click += new System.EventHandler(this.btn_horario_Click);
            // 
            // btnFamiliar
            // 
            this.btnFamiliar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnFamiliar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnFamiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamiliar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamiliar.ForeColor = System.Drawing.Color.White;
            this.btnFamiliar.Image = global::CapaPresentacion.Properties.Resources.icons8_petición_24;
            this.btnFamiliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamiliar.Location = new System.Drawing.Point(12, 245);
            this.btnFamiliar.Name = "btnFamiliar";
            this.btnFamiliar.Size = new System.Drawing.Size(227, 29);
            this.btnFamiliar.TabIndex = 3;
            this.btnFamiliar.Text = "PROVEEDORES";
            this.btnFamiliar.UseVisualStyleBackColor = true;
            this.btnFamiliar.Click += new System.EventHandler(this.btnFamiliar_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Controls.Add(this.label14);
            this.PanelContenedor.Controls.Add(this.lblcuenta);
            this.PanelContenedor.Controls.Add(this.label4);
            this.PanelContenedor.Controls.Add(this.txtfiltro);
            this.PanelContenedor.Controls.Add(this.btnactualizar);
            this.PanelContenedor.Controls.Add(this.label2);
            this.PanelContenedor.Controls.Add(this.cgvrxc);
            this.PanelContenedor.Controls.Add(this.pictureBox3);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelContenedor.Location = new System.Drawing.Point(252, 44);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(915, 628);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelContenedor_MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(645, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 19);
            this.label14.TabIndex = 35;
            this.label14.Text = "TOTAL DE REGISTROS";
            // 
            // lblcuenta
            // 
            this.lblcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuenta.Location = new System.Drawing.Point(836, 572);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(67, 30);
            this.lblcuenta.TabIndex = 29;
            this.lblcuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(488, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filtrar por Cliente: ";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(702, 28);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(201, 26);
            this.txtfiltro.TabIndex = 10;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtsueldo_TextChanged);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnactualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnactualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnactualizar.Location = new System.Drawing.Point(14, 572);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(219, 44);
            this.btnactualizar.TabIndex = 8;
            this.btnactualizar.Text = "Refrescar Tabla";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "DETALLE DE VENTAS";
            // 
            // cgvrxc
            // 
            this.cgvrxc.AllowUserToAddRows = false;
            this.cgvrxc.AllowUserToDeleteRows = false;
            this.cgvrxc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cgvrxc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cgvrxc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cgvrxc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cgvrxc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cgvrxc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cgvrxc.ColumnHeadersHeight = 30;
            this.cgvrxc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cgvrxc.EnableHeadersVisualStyles = false;
            this.cgvrxc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cgvrxc.Location = new System.Drawing.Point(14, 76);
            this.cgvrxc.Margin = new System.Windows.Forms.Padding(2);
            this.cgvrxc.Name = "cgvrxc";
            this.cgvrxc.ReadOnly = true;
            this.cgvrxc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cgvrxc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cgvrxc.RowHeadersVisible = false;
            this.cgvrxc.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.cgvrxc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cgvrxc.RowTemplate.Height = 24;
            this.cgvrxc.Size = new System.Drawing.Size(890, 477);
            this.cgvrxc.TabIndex = 0;
            this.cgvrxc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cgvrxc_CellClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.utiles;
            this.pictureBox3.Location = new System.Drawing.Point(89, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(633, 415);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // form_MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 672);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_MenuAdmin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrador";
            this.Load += new System.EventHandler(this.form_MenuAdmin_Load);
            this.header.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgvrxc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Button btnRenovacion;
        private System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.Button btnFamiliar;
        private System.Windows.Forms.Button btn_familiar;
        private System.Windows.Forms.Button btn_horario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_contrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView cgvrxc;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}