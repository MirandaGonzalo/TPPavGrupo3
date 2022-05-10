namespace TPG3.Formularios.MedioPago
{
    partial class ListaMedioPago
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
            this.dgvMedioPago = new System.Windows.Forms.DataGridView();
            this.btnCargarMP = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(58, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 30);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Lista de Medios de Pago";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvMedioPago
            // 
            this.dgvMedioPago.AllowUserToDeleteRows = false;
            this.dgvMedioPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedioPago.Location = new System.Drawing.Point(58, 83);
            this.dgvMedioPago.Name = "dgvMedioPago";
            this.dgvMedioPago.RowTemplate.Height = 25;
            this.dgvMedioPago.Size = new System.Drawing.Size(547, 150);
            this.dgvMedioPago.TabIndex = 14;
            // 
            // btnCargarMP
            // 
            this.btnCargarMP.Location = new System.Drawing.Point(58, 252);
            this.btnCargarMP.Name = "btnCargarMP";
            this.btnCargarMP.Size = new System.Drawing.Size(113, 45);
            this.btnCargarMP.TabIndex = 15;
            this.btnCargarMP.Text = "Cargar Medio de Pago";
            this.btnCargarMP.UseVisualStyleBackColor = true;
            this.btnCargarMP.Click += new System.EventHandler(this.btnCargarMP_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(177, 252);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 45);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar Medio de Pago";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(296, 252);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 45);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar Medio de Pago";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListaMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCargarMP);
            this.Controls.Add(this.dgvMedioPago);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListaMedioPago";
            this.Text = "ListaMedioPago";
            this.Load += new System.EventHandler(this.ListaMedioPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvMedioPago;
        private Button btnCargarMP;
        private Button btnEditar;
        private Button btnEliminar;
    }
}