namespace TPG3.Formularios.Producto
{
    partial class ListaProducto
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
            this.lblListaProducto = new System.Windows.Forms.Label();
            this.pnlListadoProducto = new System.Windows.Forms.Panel();
            this.txtBuscadorTipoProd = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblBuscadorProducto = new System.Windows.Forms.Label();
            this.lblBuscadorTipoProducto = new System.Windows.Forms.Label();
            this.gdrConsultarProd = new System.Windows.Forms.DataGridView();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlListadoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaProducto
            // 
            this.lblListaProducto.AutoSize = true;
            this.lblListaProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaProducto.ForeColor = System.Drawing.Color.White;
            this.lblListaProducto.Location = new System.Drawing.Point(551, 15);
            this.lblListaProducto.Name = "lblListaProducto";
            this.lblListaProducto.Size = new System.Drawing.Size(216, 28);
            this.lblListaProducto.TabIndex = 18;
            this.lblListaProducto.Text = "Listado de  Productos";
            // 
            // pnlListadoProducto
            // 
            this.pnlListadoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.pnlListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListadoProducto.Controls.Add(this.lblListaProducto);
            this.pnlListadoProducto.Controls.Add(this.txtBuscadorTipoProd);
            this.pnlListadoProducto.Controls.Add(this.txtNombreProducto);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorProducto);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorTipoProducto);
            this.pnlListadoProducto.Controls.Add(this.gdrConsultarProd);
            this.pnlListadoProducto.Location = new System.Drawing.Point(33, 96);
            this.pnlListadoProducto.Name = "pnlListadoProducto";
            this.pnlListadoProducto.Size = new System.Drawing.Size(826, 332);
            this.pnlListadoProducto.TabIndex = 17;
            // 
            // txtBuscadorTipoProd
            // 
            this.txtBuscadorTipoProd.Location = new System.Drawing.Point(18, 59);
            this.txtBuscadorTipoProd.Name = "txtBuscadorTipoProd";
            this.txtBuscadorTipoProd.Size = new System.Drawing.Size(225, 23);
            this.txtBuscadorTipoProd.TabIndex = 15;
            this.txtBuscadorTipoProd.TextChanged += new System.EventHandler(this.txtBuscadorTipoProd_TextChanged);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(300, 59);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(225, 23);
            this.txtNombreProducto.TabIndex = 11;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // lblBuscadorProducto
            // 
            this.lblBuscadorProducto.AutoSize = true;
            this.lblBuscadorProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorProducto.ForeColor = System.Drawing.Color.White;
            this.lblBuscadorProducto.Location = new System.Drawing.Point(300, 24);
            this.lblBuscadorProducto.Name = "lblBuscadorProducto";
            this.lblBuscadorProducto.Size = new System.Drawing.Size(65, 19);
            this.lblBuscadorProducto.TabIndex = 9;
            this.lblBuscadorProducto.Text = "Nombre";
            // 
            // lblBuscadorTipoProducto
            // 
            this.lblBuscadorTipoProducto.AutoSize = true;
            this.lblBuscadorTipoProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorTipoProducto.ForeColor = System.Drawing.Color.White;
            this.lblBuscadorTipoProducto.Location = new System.Drawing.Point(18, 24);
            this.lblBuscadorTipoProducto.Name = "lblBuscadorTipoProducto";
            this.lblBuscadorTipoProducto.Size = new System.Drawing.Size(105, 19);
            this.lblBuscadorTipoProducto.TabIndex = 8;
            this.lblBuscadorTipoProducto.Text = "Tipo Producto";
            // 
            // gdrConsultarProd
            // 
            this.gdrConsultarProd.AllowUserToAddRows = false;
            this.gdrConsultarProd.AllowUserToDeleteRows = false;
            this.gdrConsultarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrConsultarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoProducto,
            this.dataGridViewTextBoxColumn1,
            this.IdProducto,
            this.Descripcion,
            this.Precio});
            this.gdrConsultarProd.Location = new System.Drawing.Point(18, 101);
            this.gdrConsultarProd.Name = "gdrConsultarProd";
            this.gdrConsultarProd.ReadOnly = true;
            this.gdrConsultarProd.RowTemplate.Height = 25;
            this.gdrConsultarProd.Size = new System.Drawing.Size(749, 214);
            this.gdrConsultarProd.TabIndex = 1;
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "nombreTipoProd";
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.Width = 200;
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
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(33, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Registrar / Actualizar Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(995, 546);
            this.Controls.Add(this.pnlListadoProducto);
            this.Controls.Add(this.button1);
            this.Name = "ListaProducto";
            this.Text = "ListaProducto";
            this.Load += new System.EventHandler(this.ListaProducto_Load);
            this.pnlListadoProducto.ResumeLayout(false);
            this.pnlListadoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultarProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblListaProducto;
        private Panel pnlListadoProducto;
        private Label lblBuscadorTipoProducto;
        private DataGridView gdrConsultarProd;
        private Button button1;
        private TextBox txtBuscadorTipoProd;
        private TextBox txtNombreProducto;
        private Label lblBuscadorProducto;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
    }
}