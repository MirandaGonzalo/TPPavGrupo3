namespace TPG3.Formularios.Combo
{
    partial class AltaCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCombo));
            this.pnlListadoProducto = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdrActualizarProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProdCombo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblListadoProductos = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarCombo = new System.Windows.Forms.Button();
            this.btnAgregarCombo = new System.Windows.Forms.Button();
            this.txtPrecioCombo = new System.Windows.Forms.TextBox();
            this.txtDescripcionCombo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecioCombo = new System.Windows.Forms.Label();
            this.txtNombreCombro = new System.Windows.Forms.TextBox();
            this.lblNombreCombo = new System.Windows.Forms.Label();
            this.lblRegistrarCombo = new System.Windows.Forms.Label();
            this.pnlListadoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListadoProducto
            // 
            this.pnlListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListadoProducto.Controls.Add(this.dataGridView1);
            this.pnlListadoProducto.Controls.Add(this.gdrActualizarProd);
            this.pnlListadoProducto.Controls.Add(this.txtCantidad);
            this.pnlListadoProducto.Controls.Add(this.lblCantidad);
            this.pnlListadoProducto.Controls.Add(this.button1);
            this.pnlListadoProducto.Controls.Add(this.lblProdCombo);
            this.pnlListadoProducto.Controls.Add(this.btnAgregar);
            this.pnlListadoProducto.Controls.Add(this.lblListadoProductos);
            this.pnlListadoProducto.Controls.Add(this.btnLimpiarCampos);
            this.pnlListadoProducto.Controls.Add(this.btnActualizarCombo);
            this.pnlListadoProducto.Controls.Add(this.btnAgregarCombo);
            this.pnlListadoProducto.Controls.Add(this.txtPrecioCombo);
            this.pnlListadoProducto.Controls.Add(this.txtDescripcionCombo);
            this.pnlListadoProducto.Controls.Add(this.label1);
            this.pnlListadoProducto.Controls.Add(this.lblPrecioCombo);
            this.pnlListadoProducto.Controls.Add(this.txtNombreCombro);
            this.pnlListadoProducto.Controls.Add(this.lblNombreCombo);
            this.pnlListadoProducto.Location = new System.Drawing.Point(25, 35);
            this.pnlListadoProducto.Name = "pnlListadoProducto";
            this.pnlListadoProducto.Size = new System.Drawing.Size(750, 411);
            this.pnlListadoProducto.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Cantidad,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(443, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(289, 236);
            this.dataGridView1.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdProducto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 10;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipoProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "TipoProducto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // gdrActualizarProd
            // 
            this.gdrActualizarProd.AllowUserToAddRows = false;
            this.gdrActualizarProd.AllowUserToDeleteRows = false;
            this.gdrActualizarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrActualizarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProducto,
            this.Descripcion,
            this.TipoProducto,
            this.Precio});
            this.gdrActualizarProd.Location = new System.Drawing.Point(28, 158);
            this.gdrActualizarProd.Name = "gdrActualizarProd";
            this.gdrActualizarProd.ReadOnly = true;
            this.gdrActualizarProd.RowTemplate.Height = 25;
            this.gdrActualizarProd.Size = new System.Drawing.Size(289, 236);
            this.gdrActualizarProd.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "idProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 10;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "tipoProducto";
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(118, 85);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(86, 23);
            this.txtCantidad.TabIndex = 31;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(28, 89);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 19);
            this.lblCantidad.TabIndex = 32;
            this.lblCantidad.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(349, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 49);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblProdCombo
            // 
            this.lblProdCombo.AutoSize = true;
            this.lblProdCombo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdCombo.Location = new System.Drawing.Point(443, 127);
            this.lblProdCombo.Name = "lblProdCombo";
            this.lblProdCombo.Size = new System.Drawing.Size(194, 25);
            this.lblProdCombo.TabIndex = 28;
            this.lblProdCombo.Text = "Productos del Combo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(349, 179);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 49);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblListadoProductos
            // 
            this.lblListadoProductos.AutoSize = true;
            this.lblListadoProductos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListadoProductos.Location = new System.Drawing.Point(28, 127);
            this.lblListadoProductos.Name = "lblListadoProductos";
            this.lblListadoProductos.Size = new System.Drawing.Size(164, 25);
            this.lblListadoProductos.TabIndex = 15;
            this.lblListadoProductos.Text = "Listado Productos";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(329, 80);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(150, 28);
            this.btnLimpiarCampos.TabIndex = 19;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarCombo
            // 
            this.btnActualizarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizarCombo.FlatAppearance.BorderSize = 0;
            this.btnActualizarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarCombo.Location = new System.Drawing.Point(636, 80);
            this.btnActualizarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizarCombo.Name = "btnActualizarCombo";
            this.btnActualizarCombo.Size = new System.Drawing.Size(93, 28);
            this.btnActualizarCombo.TabIndex = 20;
            this.btnActualizarCombo.Text = "Actualizar";
            this.btnActualizarCombo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCombo
            // 
            this.btnAgregarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarCombo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCombo.Location = new System.Drawing.Point(511, 80);
            this.btnAgregarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarCombo.Name = "btnAgregarCombo";
            this.btnAgregarCombo.Size = new System.Drawing.Size(93, 28);
            this.btnAgregarCombo.TabIndex = 21;
            this.btnAgregarCombo.Text = "Agregar";
            this.btnAgregarCombo.UseVisualStyleBackColor = false;
            this.btnAgregarCombo.Click += new System.EventHandler(this.btnAgregarCombo_Click);
            // 
            // txtPrecioCombo
            // 
            this.txtPrecioCombo.Location = new System.Drawing.Point(228, 41);
            this.txtPrecioCombo.Name = "txtPrecioCombo";
            this.txtPrecioCombo.Size = new System.Drawing.Size(86, 23);
            this.txtPrecioCombo.TabIndex = 17;
            // 
            // txtDescripcionCombo
            // 
            this.txtDescripcionCombo.Location = new System.Drawing.Point(429, 19);
            this.txtDescripcionCombo.Name = "txtDescripcionCombo";
            this.txtDescripcionCombo.Size = new System.Drawing.Size(300, 45);
            this.txtDescripcionCombo.TabIndex = 18;
            this.txtDescripcionCombo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Descripcion";
            // 
            // lblPrecioCombo
            // 
            this.lblPrecioCombo.AutoSize = true;
            this.lblPrecioCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioCombo.Location = new System.Drawing.Point(228, 19);
            this.lblPrecioCombo.Name = "lblPrecioCombo";
            this.lblPrecioCombo.Size = new System.Drawing.Size(52, 19);
            this.lblPrecioCombo.TabIndex = 24;
            this.lblPrecioCombo.Text = "Precio";
            // 
            // txtNombreCombro
            // 
            this.txtNombreCombro.Location = new System.Drawing.Point(28, 41);
            this.txtNombreCombro.Name = "txtNombreCombro";
            this.txtNombreCombro.Size = new System.Drawing.Size(176, 23);
            this.txtNombreCombro.TabIndex = 16;
            // 
            // lblNombreCombo
            // 
            this.lblNombreCombo.AutoSize = true;
            this.lblNombreCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCombo.Location = new System.Drawing.Point(28, 19);
            this.lblNombreCombo.Name = "lblNombreCombo";
            this.lblNombreCombo.Size = new System.Drawing.Size(118, 19);
            this.lblNombreCombo.TabIndex = 23;
            this.lblNombreCombo.Text = "Nombre Combo";
            // 
            // lblRegistrarCombo
            // 
            this.lblRegistrarCombo.AutoSize = true;
            this.lblRegistrarCombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistrarCombo.Location = new System.Drawing.Point(605, 4);
            this.lblRegistrarCombo.Name = "lblRegistrarCombo";
            this.lblRegistrarCombo.Size = new System.Drawing.Size(170, 28);
            this.lblRegistrarCombo.TabIndex = 15;
            this.lblRegistrarCombo.Text = "Registrar Combo";
            // 
            // AltaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlListadoProducto);
            this.Controls.Add(this.lblRegistrarCombo);
            this.Name = "AltaCombo";
            this.Text = "AltaCombo";
            this.Load += new System.EventHandler(this.AltaCombo_Load);
            this.pnlListadoProducto.ResumeLayout(false);
            this.pnlListadoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlListadoProducto;
        private Button button1;
        private Label lblProdCombo;
        private Button btnAgregar;
        private Label lblListadoProductos;
        private Button btnLimpiarCampos;
        private Button btnActualizarCombo;
        private Button btnAgregarCombo;
        private TextBox txtPrecioCombo;
        private RichTextBox txtDescripcionCombo;
        private Label label1;
        private Label lblPrecioCombo;
        private TextBox txtNombreCombro;
        private Label lblNombreCombo;
        private Label lblRegistrarCombo;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private DataGridView gdrActualizarProd;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}