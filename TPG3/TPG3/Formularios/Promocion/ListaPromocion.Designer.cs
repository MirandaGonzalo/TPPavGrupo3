namespace TPG3.Formularios.Promocion
{
    partial class ListaPromocion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.btnCargarPromo = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(52, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 30);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Lista de Promociones";
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.AllowUserToAddRows = false;
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Valor,
            this.FechaInicio,
            this.FechaFin});
            this.dgvPromocion.Location = new System.Drawing.Point(52, 140);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowTemplate.Height = 25;
            this.dgvPromocion.Size = new System.Drawing.Size(635, 206);
            this.dgvPromocion.TabIndex = 13;
            // 
            // btnCargarPromo
            // 
            this.btnCargarPromo.Location = new System.Drawing.Point(52, 96);
            this.btnCargarPromo.Name = "btnCargarPromo";
            this.btnCargarPromo.Size = new System.Drawing.Size(143, 23);
            this.btnCargarPromo.TabIndex = 14;
            this.btnCargarPromo.Text = "Cargar Promo";
            this.btnCargarPromo.UseVisualStyleBackColor = true;
            this.btnCargarPromo.Click += new System.EventHandler(this.btnCargarPromo_Click);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 150;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "fechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 120;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "fechaFin";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 120;
            // 
            // ListaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarPromo);
            this.Controls.Add(this.dgvPromocion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListaPromocion";
            this.Text = "ListaPromocion";
            this.Load += new System.EventHandler(this.ListaPromocion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvPromocion;
        private Button btnCargarPromo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
    }
}