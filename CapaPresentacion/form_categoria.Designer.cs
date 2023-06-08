
namespace CapaPresentacion
{
    partial class form_categoria
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.tbn_delete = new System.Windows.Forms.Button();
            this.dgvEstadoR = new System.Windows.Forms.DataGridView();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.panelCabezera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoR)).BeginInit();
            this.panelVertical.SuspendLayout();
            this.panelCabezera.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(115, 46);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(199, 88);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.Color.Silver;
            this.lb_nombre.Location = new System.Drawing.Point(25, 48);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(84, 15);
            this.lb_nombre.TabIndex = 6;
            this.lb_nombre.Text = "DESCRIPCION";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(29, 164);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(89, 33);
            this.btn_create.TabIndex = 9;
            this.btn_create.Text = "Nuevo";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btngrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrabar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btngrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrabar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabar.ForeColor = System.Drawing.Color.White;
            this.btngrabar.Location = new System.Drawing.Point(128, 164);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(89, 33);
            this.btngrabar.TabIndex = 10;
            this.btngrabar.Text = "Agregar";
            this.btngrabar.UseVisualStyleBackColor = false;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // tbn_delete
            // 
            this.tbn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.tbn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.tbn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_delete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_delete.ForeColor = System.Drawing.Color.White;
            this.tbn_delete.Location = new System.Drawing.Point(223, 164);
            this.tbn_delete.Name = "tbn_delete";
            this.tbn_delete.Size = new System.Drawing.Size(96, 33);
            this.tbn_delete.TabIndex = 11;
            this.tbn_delete.Text = "Eliminar";
            this.tbn_delete.UseVisualStyleBackColor = false;
            this.tbn_delete.Click += new System.EventHandler(this.tbn_delete_Click);
            // 
            // dgvEstadoR
            // 
            this.dgvEstadoR.AllowUserToAddRows = false;
            this.dgvEstadoR.AllowUserToDeleteRows = false;
            this.dgvEstadoR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstadoR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstadoR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvEstadoR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadoR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstadoR.ColumnHeadersHeight = 30;
            this.dgvEstadoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstadoR.EnableHeadersVisualStyles = false;
            this.dgvEstadoR.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEstadoR.Location = new System.Drawing.Point(352, 44);
            this.dgvEstadoR.Name = "dgvEstadoR";
            this.dgvEstadoR.ReadOnly = true;
            this.dgvEstadoR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoR.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstadoR.RowHeadersVisible = false;
            this.dgvEstadoR.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstadoR.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadoR.Size = new System.Drawing.Size(279, 197);
            this.dgvEstadoR.TabIndex = 12;
            this.dgvEstadoR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadoR_CellClick);
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelVertical.Controls.Add(this.btngrabar);
            this.panelVertical.Controls.Add(this.btn_create);
            this.panelVertical.Controls.Add(this.txtnombre);
            this.panelVertical.Controls.Add(this.lb_nombre);
            this.panelVertical.Controls.Add(this.tbn_delete);
            this.panelVertical.Location = new System.Drawing.Point(0, 31);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(346, 227);
            this.panelVertical.TabIndex = 13;
            // 
            // panelCabezera
            // 
            this.panelCabezera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.panelCabezera.Controls.Add(this.label1);
            this.panelCabezera.Controls.Add(this.btnminimizar);
            this.panelCabezera.Controls.Add(this.btnCerrar);
            this.panelCabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabezera.Location = new System.Drawing.Point(0, 0);
            this.panelCabezera.Name = "panelCabezera";
            this.panelCabezera.Size = new System.Drawing.Size(643, 38);
            this.panelCabezera.TabIndex = 14;
            this.panelCabezera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabezera_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label1.Image = global::CapaPresentacion.Properties.Resources.icons8_clasificación_de_respuestas_241;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "   CATEGORIA";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.Icono_Minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(560, 2);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(39, 33);
            this.btnminimizar.TabIndex = 3;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrar.Location = new System.Drawing.Point(605, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 33);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // form_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(643, 253);
            this.Controls.Add(this.panelCabezera);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.dgvEstadoR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_categoria";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria de Productos";
            this.Load += new System.EventHandler(this.form_categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoR)).EndInit();
            this.panelVertical.ResumeLayout(false);
            this.panelVertical.PerformLayout();
            this.panelCabezera.ResumeLayout(false);
            this.panelCabezera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button tbn_delete;
        private System.Windows.Forms.DataGridView dgvEstadoR;
        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Panel panelCabezera;
    }
}