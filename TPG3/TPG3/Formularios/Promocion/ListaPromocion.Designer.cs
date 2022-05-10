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
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarPromo = new System.Windows.Forms.Button();
            this.btnEditarPromo = new System.Windows.Forms.Button();
            this.btnEliminarPromo = new System.Windows.Forms.Button();
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.panelBackAltaPromocion.SuspendLayout();
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
            this.dgvPromocion.Location = new System.Drawing.Point(52, 205);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowTemplate.Height = 25;
            this.dgvPromocion.Size = new System.Drawing.Size(694, 273);
            this.dgvPromocion.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
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
            // btnEditarPromo
            // 
            this.btnEditarPromo.Location = new System.Drawing.Point(201, 96);
            this.btnEditarPromo.Name = "btnEditarPromo";
            this.btnEditarPromo.Size = new System.Drawing.Size(143, 23);
            this.btnEditarPromo.TabIndex = 15;
            this.btnEditarPromo.Text = "Editar Promo";
            this.btnEditarPromo.UseVisualStyleBackColor = true;
            this.btnEditarPromo.Click += new System.EventHandler(this.btnEditarPromo_Click);
            // 
            // btnEliminarPromo
            // 
            this.btnEliminarPromo.Location = new System.Drawing.Point(350, 96);
            this.btnEliminarPromo.Name = "btnEliminarPromo";
            this.btnEliminarPromo.Size = new System.Drawing.Size(145, 23);
            this.btnEliminarPromo.TabIndex = 16;
            this.btnEliminarPromo.Text = "Eliminar Promo";
            this.btnEliminarPromo.UseVisualStyleBackColor = true;
            this.btnEliminarPromo.Click += new System.EventHandler(this.btnEliminarPromo_Click);
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscar);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(52, 142);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(292, 46);
            this.panelBackAltaPromocion.TabIndex = 20;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(120, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 23);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // ListaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 591);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Controls.Add(this.btnEliminarPromo);
            this.Controls.Add(this.btnEditarPromo);
            this.Controls.Add(this.btnCargarPromo);
            this.Controls.Add(this.dgvPromocion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListaPromocion";
            this.Text = "ListaPromocion";
            this.Load += new System.EventHandler(this.ListaPromocion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvPromocion;
        private Button btnCargarPromo;
        private Button btnEditarPromo;
        private Button btnEliminarPromo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private Panel panelBackAltaPromocion;
        private TextBox txtBuscar;
        private Label label1;
    }
}