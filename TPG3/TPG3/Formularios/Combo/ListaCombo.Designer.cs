namespace TPG3.Formularios.Combo
{
    partial class ListaCombo
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
            this.lblListaCombo = new System.Windows.Forms.Label();
            this.pnlListadoProducto = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscarCombo = new System.Windows.Forms.Button();
            this.cmbCombo = new System.Windows.Forms.ComboBox();
            this.lblBuscadorCombo = new System.Windows.Forms.Label();
            this.btnRegistrarCombo = new System.Windows.Forms.Button();
            this.gdrConsultarProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlListadoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaCombo
            // 
            this.lblListaCombo.AutoSize = true;
            this.lblListaCombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaCombo.Location = new System.Drawing.Point(571, 65);
            this.lblListaCombo.Name = "lblListaCombo";
            this.lblListaCombo.Size = new System.Drawing.Size(196, 28);
            this.lblListaCombo.TabIndex = 15;
            this.lblListaCombo.Text = "Listado de  Combos";
            // 
            // pnlListadoProducto
            // 
            this.pnlListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListadoProducto.Controls.Add(this.gdrConsultarProd);
            this.pnlListadoProducto.Controls.Add(this.flowLayoutPanel1);
            this.pnlListadoProducto.Controls.Add(this.btnBuscarCombo);
            this.pnlListadoProducto.Controls.Add(this.cmbCombo);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorCombo);
            this.pnlListadoProducto.Location = new System.Drawing.Point(33, 96);
            this.pnlListadoProducto.Name = "pnlListadoProducto";
            this.pnlListadoProducto.Size = new System.Drawing.Size(734, 332);
            this.pnlListadoProducto.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnBuscarCombo
            // 
            this.btnBuscarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCombo.FlatAppearance.BorderSize = 0;
            this.btnBuscarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCombo.Location = new System.Drawing.Point(572, 24);
            this.btnBuscarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCombo.Name = "btnBuscarCombo";
            this.btnBuscarCombo.Size = new System.Drawing.Size(146, 58);
            this.btnBuscarCombo.TabIndex = 13;
            this.btnBuscarCombo.Text = "BUSCAR";
            this.btnBuscarCombo.UseVisualStyleBackColor = false;
            // 
            // cmbCombo
            // 
            this.cmbCombo.FormattingEnabled = true;
            this.cmbCombo.Location = new System.Drawing.Point(18, 59);
            this.cmbCombo.Name = "cmbCombo";
            this.cmbCombo.Size = new System.Drawing.Size(225, 23);
            this.cmbCombo.TabIndex = 10;
            // 
            // lblBuscadorCombo
            // 
            this.lblBuscadorCombo.AutoSize = true;
            this.lblBuscadorCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorCombo.Location = new System.Drawing.Point(18, 24);
            this.lblBuscadorCombo.Name = "lblBuscadorCombo";
            this.lblBuscadorCombo.Size = new System.Drawing.Size(124, 19);
            this.lblBuscadorCombo.TabIndex = 8;
            this.lblBuscadorCombo.Text = "Buscador Combo";
            // 
            // btnRegistrarCombo
            // 
            this.btnRegistrarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCombo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarCombo.Location = new System.Drawing.Point(33, 22);
            this.btnRegistrarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarCombo.Name = "btnRegistrarCombo";
            this.btnRegistrarCombo.Size = new System.Drawing.Size(308, 47);
            this.btnRegistrarCombo.TabIndex = 13;
            this.btnRegistrarCombo.Text = "Registrar / Actualizar Combo";
            this.btnRegistrarCombo.UseVisualStyleBackColor = false;
            this.btnRegistrarCombo.Click += new System.EventHandler(this.btnRegistrarCombo_Click);
            // 
            // gdrConsultarProd
            // 
            this.gdrConsultarProd.AllowUserToAddRows = false;
            this.gdrConsultarProd.AllowUserToDeleteRows = false;
            this.gdrConsultarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrConsultarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProducto,
            this.Descripcion,
            this.TipoProducto,
            this.Precio});
            this.gdrConsultarProd.Location = new System.Drawing.Point(18, 99);
            this.gdrConsultarProd.Name = "gdrConsultarProd";
            this.gdrConsultarProd.ReadOnly = true;
            this.gdrConsultarProd.RowTemplate.Height = 25;
            this.gdrConsultarProd.Size = new System.Drawing.Size(700, 214);
            this.gdrConsultarProd.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "idProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "tipoProducto";
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // ListaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListaCombo);
            this.Controls.Add(this.pnlListadoProducto);
            this.Controls.Add(this.btnRegistrarCombo);
            this.Name = "ListaCombo";
            this.Text = "ListaCombo";
            this.Load += new System.EventHandler(this.ListaCombo_Load);
            this.pnlListadoProducto.ResumeLayout(false);
            this.pnlListadoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultarProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblListaCombo;
        private Panel pnlListadoProducto;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBuscarCombo;
        private ComboBox cmbCombo;
        private Label lblBuscadorCombo;
        private Button btnRegistrarCombo;
        private DataGridView gdrConsultarProd;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn Precio;
    }
}