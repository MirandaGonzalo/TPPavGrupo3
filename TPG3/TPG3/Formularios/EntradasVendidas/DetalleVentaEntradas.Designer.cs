namespace TPG3.Formularios.EntradasVendidas
{
    partial class DetalleVentaEntradas
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblSala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListaCombo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListaTickets = new System.Windows.Forms.Button();
            this.panelFondo.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelFondo.Controls.Add(this.panelDetalle);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(800, 450);
            this.panelFondo.TabIndex = 0;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelDetalle.Controls.Add(this.btnListaTickets);
            this.panelDetalle.Controls.Add(this.lblSala);
            this.panelDetalle.Controls.Add(this.label1);
            this.panelDetalle.Controls.Add(this.lblListaCombo);
            this.panelDetalle.Controls.Add(this.dataGridView1);
            this.panelDetalle.Location = new System.Drawing.Point(45, 12);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(685, 394);
            this.panelDetalle.TabIndex = 0;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSala.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSala.Location = new System.Drawing.Point(102, 95);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(19, 21);
            this.lblSala.TabIndex = 18;
            this.lblSala.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sala:";
            // 
            // lblListaCombo
            // 
            this.lblListaCombo.AutoSize = true;
            this.lblListaCombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaCombo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListaCombo.Location = new System.Drawing.Point(37, 36);
            this.lblListaCombo.Name = "lblListaCombo";
            this.lblListaCombo.Size = new System.Drawing.Size(197, 28);
            this.lblListaCombo.TabIndex = 16;
            this.lblListaCombo.Text = "Listado de Entradas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orden,
            this.Columna,
            this.Fila,
            this.Tarifa});
            this.dataGridView1.Location = new System.Drawing.Point(37, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(605, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // orden
            // 
            this.orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orden.DataPropertyName = "orden";
            this.orden.HeaderText = "Orden";
            this.orden.Name = "orden";
            // 
            // Columna
            // 
            this.Columna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columna.DataPropertyName = "letraColumna";
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            // 
            // Fila
            // 
            this.Fila.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fila.DataPropertyName = "numeroFila";
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            // 
            // Tarifa
            // 
            this.Tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarifa.DataPropertyName = "descripcion";
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            // 
            // btnListaTickets
            // 
            this.btnListaTickets.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnListaTickets.FlatAppearance.BorderSize = 0;
            this.btnListaTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListaTickets.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListaTickets.Location = new System.Drawing.Point(536, 82);
            this.btnListaTickets.Margin = new System.Windows.Forms.Padding(0);
            this.btnListaTickets.Name = "btnListaTickets";
            this.btnListaTickets.Size = new System.Drawing.Size(106, 34);
            this.btnListaTickets.TabIndex = 19;
            this.btnListaTickets.Text = "Volver";
            this.btnListaTickets.UseVisualStyleBackColor = false;
            this.btnListaTickets.Click += new System.EventHandler(this.btnListaTickets_Click);
            // 
            // DetalleVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFondo);
            this.Name = "DetalleVentaEntradas";
            this.Text = "DetalleVentaEntradas";
            this.Load += new System.EventHandler(this.DetalleVentaEntradas_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFondo;
        private Panel panelDetalle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orden;
        private DataGridViewTextBoxColumn Columna;
        private DataGridViewTextBoxColumn Fila;
        private DataGridViewTextBoxColumn Tarifa;
        private Label lblSala;
        private Label label1;
        private Label lblListaCombo;
        private Button btnListaTickets;
    }
}