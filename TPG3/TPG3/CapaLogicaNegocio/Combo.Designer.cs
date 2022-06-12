namespace TPG3.CapaLogicaNegocio
{
    partial class Combo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Combo));
            this.panelFondoCombo = new System.Windows.Forms.Panel();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantComb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargarCombo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetalleCombo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFrenteCombo = new System.Windows.Forms.Panel();
            this.btnProductoNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListaCombosSel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListaCombos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFondoCombo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCombo)).BeginInit();
            this.panelFrenteCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCombosSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondoCombo
            // 
            this.panelFondoCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelFondoCombo.Controls.Add(this.panel1);
            this.panelFondoCombo.Controls.Add(this.label1);
            this.panelFondoCombo.Controls.Add(this.panelFrenteCombo);
            this.panelFondoCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondoCombo.Location = new System.Drawing.Point(0, 0);
            this.panelFondoCombo.Name = "panelFondoCombo";
            this.panelFondoCombo.Size = new System.Drawing.Size(1071, 729);
            this.panelFondoCombo.TabIndex = 0;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTotal.ForeColor = System.Drawing.Color.White;
            this.lblPrecioTotal.Location = new System.Drawing.Point(378, 205);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(19, 21);
            this.lblPrecioTotal.TabIndex = 3;
            this.lblPrecioTotal.Text = "0";
            this.lblPrecioTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(247, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Precio Total:";
            // 
            // lblCantComb
            // 
            this.lblCantComb.AutoSize = true;
            this.lblCantComb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantComb.ForeColor = System.Drawing.Color.White;
            this.lblCantComb.Location = new System.Drawing.Point(193, 205);
            this.lblCantComb.Name = "lblCantComb";
            this.lblCantComb.Size = new System.Drawing.Size(19, 21);
            this.lblCantComb.TabIndex = 1;
            this.lblCantComb.Text = "0";
            this.lblCantComb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad Combos:";
            // 
            // btnCargarCombo
            // 
            this.btnCargarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarCombo.FlatAppearance.BorderSize = 0;
            this.btnCargarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarCombo.ForeColor = System.Drawing.Color.White;
            this.btnCargarCombo.Location = new System.Drawing.Point(721, 200);
            this.btnCargarCombo.Name = "btnCargarCombo";
            this.btnCargarCombo.Size = new System.Drawing.Size(111, 37);
            this.btnCargarCombo.TabIndex = 25;
            this.btnCargarCombo.Text = "Continuar";
            this.btnCargarCombo.UseVisualStyleBackColor = false;
            this.btnCargarCombo.Click += new System.EventHandler(this.btnCargarCombo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btnCargarCombo);
            this.panel1.Controls.Add(this.lblPrecioTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvDetalleCombo);
            this.panel1.Controls.Add(this.lblCantComb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(53, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 249);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detalle de Combo";
            // 
            // dgvDetalleCombo
            // 
            this.dgvDetalleCombo.AllowUserToAddRows = false;
            this.dgvDetalleCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.total});
            this.dgvDetalleCombo.Location = new System.Drawing.Point(23, 39);
            this.dgvDetalleCombo.Name = "dgvDetalleCombo";
            this.dgvDetalleCombo.RowTemplate.Height = 25;
            this.dgvDetalleCombo.Size = new System.Drawing.Size(809, 150);
            this.dgvDetalleCombo.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Combo";
            // 
            // panelFrenteCombo
            // 
            this.panelFrenteCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelFrenteCombo.Controls.Add(this.btnProductoNuevo);
            this.panelFrenteCombo.Controls.Add(this.btnAgregar);
            this.panelFrenteCombo.Controls.Add(this.label3);
            this.panelFrenteCombo.Controls.Add(this.label2);
            this.panelFrenteCombo.Controls.Add(this.dgvListaCombosSel);
            this.panelFrenteCombo.Controls.Add(this.dgvListaCombos);
            this.panelFrenteCombo.Location = new System.Drawing.Point(53, 33);
            this.panelFrenteCombo.Name = "panelFrenteCombo";
            this.panelFrenteCombo.Size = new System.Drawing.Size(932, 201);
            this.panelFrenteCombo.TabIndex = 0;
            // 
            // btnProductoNuevo
            // 
            this.btnProductoNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProductoNuevo.FlatAppearance.BorderSize = 0;
            this.btnProductoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoNuevo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductoNuevo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductoNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnProductoNuevo.Image")));
            this.btnProductoNuevo.Location = new System.Drawing.Point(864, 80);
            this.btnProductoNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductoNuevo.Name = "btnProductoNuevo";
            this.btnProductoNuevo.Size = new System.Drawing.Size(43, 44);
            this.btnProductoNuevo.TabIndex = 43;
            this.btnProductoNuevo.UseVisualStyleBackColor = false;
            this.btnProductoNuevo.Click += new System.EventHandler(this.btnProductoNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(369, 80);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(42, 44);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(462, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Combos Seleccionados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Listado de Combos";
            // 
            // dgvListaCombosSel
            // 
            this.dgvListaCombosSel.AllowUserToAddRows = false;
            this.dgvListaCombosSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCombosSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cantidad});
            this.dgvListaCombosSel.Location = new System.Drawing.Point(462, 36);
            this.dgvListaCombosSel.Name = "dgvListaCombosSel";
            this.dgvListaCombosSel.RowTemplate.Height = 25;
            this.dgvListaCombosSel.Size = new System.Drawing.Size(370, 150);
            this.dgvListaCombosSel.TabIndex = 1;
            this.dgvListaCombosSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCombosSel_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // dgvListaCombos
            // 
            this.dgvListaCombos.AllowUserToAddRows = false;
            this.dgvListaCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCombos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.idProducto,
            this.precio});
            this.dgvListaCombos.Location = new System.Drawing.Point(23, 36);
            this.dgvListaCombos.Name = "dgvListaCombos";
            this.dgvListaCombos.RowTemplate.Height = 25;
            this.dgvListaCombos.Size = new System.Drawing.Size(319, 150);
            this.dgvListaCombos.TabIndex = 0;
            this.dgvListaCombos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCombos_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.Visible = false;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 729);
            this.Controls.Add(this.panelFondoCombo);
            this.Name = "Combo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.Combo_Load);
            this.panelFondoCombo.ResumeLayout(false);
            this.panelFondoCombo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCombo)).EndInit();
            this.panelFrenteCombo.ResumeLayout(false);
            this.panelFrenteCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCombosSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCombos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFondoCombo;
        private Panel panel1;
        private DataGridView dgvDetalleCombo;
        private Label label1;
        private Panel panelFrenteCombo;
        private Label label3;
        private Label label2;
        private DataGridView dgvListaCombosSel;
        private DataGridView dgvListaCombos;
        private Button btnAgregar;
        private Label label4;
        private Button btnProductoNuevo;
        private Button btnCargarCombo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn cantidad;
        private Label lblPrecioTotal;
        private Label label7;
        private Label lblCantComb;
        private Label label5;
    }
}