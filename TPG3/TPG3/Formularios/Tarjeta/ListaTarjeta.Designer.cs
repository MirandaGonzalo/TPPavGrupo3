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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltaTarjeta
            // 
            this.lblAltaTarjeta.AutoSize = true;
            this.lblAltaTarjeta.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltaTarjeta.ForeColor = System.Drawing.Color.White;
            this.lblAltaTarjeta.Location = new System.Drawing.Point(412, 39);
            this.lblAltaTarjeta.Name = "lblAltaTarjeta";
            this.lblAltaTarjeta.Size = new System.Drawing.Size(199, 28);
            this.lblAltaTarjeta.TabIndex = 0;
            this.lblAltaTarjeta.Text = "Listado de Tarjetas";
            // 
            // btnRegistrarTarjeta
            // 
            this.btnRegistrarTarjeta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarTarjeta.Location = new System.Drawing.Point(23, 27);
            this.btnRegistrarTarjeta.Name = "btnRegistrarTarjeta";
            this.btnRegistrarTarjeta.Size = new System.Drawing.Size(196, 60);
            this.btnRegistrarTarjeta.TabIndex = 10;
            this.btnRegistrarTarjeta.Text = "Registrar Tarjeta";
            this.btnRegistrarTarjeta.UseVisualStyleBackColor = false;
            this.btnRegistrarTarjeta.Click += new System.EventHandler(this.btnRegistrarTarjeta_Click);
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Location = new System.Drawing.Point(19, 100);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.RowTemplate.Height = 25;
            this.dgvTarjetas.Size = new System.Drawing.Size(592, 254);
            this.dgvTarjetas.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(484, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(196, 60);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar Tarjeta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(240, 27);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(196, 60);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar Tarjeta";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.dgvTarjetas);
            this.panel1.Controls.Add(this.lblAltaTarjeta);
            this.panel1.Location = new System.Drawing.Point(23, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 379);
            this.panel1.TabIndex = 30;
            // 
            // ListaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(721, 502);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrarTarjeta);
            this.Controls.Add(this.panel1);
            this.Name = "ListaTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de nueva tarjeta";
            this.Load += new System.EventHandler(this.ListaTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAltaTarjeta;
        private Button btnRegistrarTarjeta;
        private DataGridView dgvTarjetas;
        private Button btnEliminar;
        private Button btnModificar;
        private Panel panel1;
    }
}