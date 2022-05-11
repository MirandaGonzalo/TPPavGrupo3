namespace TPG3.Formularios.Tarjeta
{
    partial class ListaTarjeta
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
            this.lblAltaTarjeta = new System.Windows.Forms.Label();
            this.btnRegistrarTarjeta = new System.Windows.Forms.Button();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltaTarjeta
            // 
            this.lblAltaTarjeta.AutoSize = true;
            this.lblAltaTarjeta.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAltaTarjeta.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAltaTarjeta.Location = new System.Drawing.Point(36, 39);
            this.lblAltaTarjeta.Name = "lblAltaTarjeta";
            this.lblAltaTarjeta.Size = new System.Drawing.Size(226, 32);
            this.lblAltaTarjeta.TabIndex = 0;
            this.lblAltaTarjeta.Text = "Listado de Tarjetas";
            // 
            // btnRegistrarTarjeta
            // 
            this.btnRegistrarTarjeta.Location = new System.Drawing.Point(36, 383);
            this.btnRegistrarTarjeta.Name = "btnRegistrarTarjeta";
            this.btnRegistrarTarjeta.Size = new System.Drawing.Size(122, 23);
            this.btnRegistrarTarjeta.TabIndex = 10;
            this.btnRegistrarTarjeta.Text = "Registrar Tarjeta";
            this.btnRegistrarTarjeta.UseVisualStyleBackColor = true;
            this.btnRegistrarTarjeta.Click += new System.EventHandler(this.btnRegistrarTarjeta_Click);
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Location = new System.Drawing.Point(36, 96);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.RowTemplate.Height = 25;
            this.dgvTarjetas.Size = new System.Drawing.Size(592, 254);
            this.dgvTarjetas.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(292, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar Tarjeta";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(164, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar Tarjeta";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ListaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.btnRegistrarTarjeta);
            this.Controls.Add(this.lblAltaTarjeta);
            this.Name = "ListaTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de nueva tarjeta";
            this.Load += new System.EventHandler(this.ListaTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAltaTarjeta;
        private Button btnRegistrarTarjeta;
        private DataGridView dgvTarjetas;
        private Button btnEliminar;
        private Button btnModificar;
    }
}