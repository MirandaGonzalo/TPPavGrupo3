namespace TPG3.Formularios.EntradasVendidas
{
    partial class ListaEntradas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizarCombo = new System.Windows.Forms.Button();
            this.gridTicket = new System.Windows.Forms.DataGridView();
            this.nroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets Emitidos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.btnActualizarCombo);
            this.panel2.Controls.Add(this.gridTicket);
            this.panel2.Location = new System.Drawing.Point(59, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 329);
            this.panel2.TabIndex = 0;
            // 
            // btnActualizarCombo
            // 
            this.btnActualizarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizarCombo.FlatAppearance.BorderSize = 0;
            this.btnActualizarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarCombo.Location = new System.Drawing.Point(521, 22);
            this.btnActualizarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizarCombo.Name = "btnActualizarCombo";
            this.btnActualizarCombo.Size = new System.Drawing.Size(138, 47);
            this.btnActualizarCombo.TabIndex = 17;
            this.btnActualizarCombo.Text = "Detalle Ticket";
            this.btnActualizarCombo.UseVisualStyleBackColor = false;
            this.btnActualizarCombo.Click += new System.EventHandler(this.btnActualizarCombo_Click);
            // 
            // gridTicket
            // 
            this.gridTicket.AllowUserToAddRows = false;
            this.gridTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroTicket,
            this.fechaHoraVenta,
            this.CodMedioPago,
            this.MedioPago,
            this.Precio,
            this.Apellido,
            this.Nombre,
            this.Promo,
            this.precioPromo});
            this.gridTicket.Location = new System.Drawing.Point(17, 88);
            this.gridTicket.Name = "gridTicket";
            this.gridTicket.RowTemplate.Height = 25;
            this.gridTicket.Size = new System.Drawing.Size(642, 216);
            this.gridTicket.TabIndex = 0;
            // 
            // nroTicket
            // 
            this.nroTicket.DataPropertyName = "nroTicket";
            this.nroTicket.HeaderText = "nroTicket";
            this.nroTicket.Name = "nroTicket";
            this.nroTicket.Visible = false;
            // 
            // fechaHoraVenta
            // 
            this.fechaHoraVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaHoraVenta.DataPropertyName = "fechaHoraVenta";
            this.fechaHoraVenta.HeaderText = "Fecha Venta";
            this.fechaHoraVenta.Name = "fechaHoraVenta";
            // 
            // CodMedioPago
            // 
            this.CodMedioPago.DataPropertyName = "codMedioPago";
            this.CodMedioPago.HeaderText = "CodMedioPago";
            this.CodMedioPago.Name = "CodMedioPago";
            this.CodMedioPago.Visible = false;
            // 
            // MedioPago
            // 
            this.MedioPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedioPago.DataPropertyName = "nombre";
            this.MedioPago.HeaderText = "Medio de Pago";
            this.MedioPago.Name = "MedioPago";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "enombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Promo
            // 
            this.Promo.DataPropertyName = "promo";
            this.Promo.HeaderText = "Promo";
            this.Promo.Name = "Promo";
            this.Promo.Visible = false;
            // 
            // precioPromo
            // 
            this.precioPromo.DataPropertyName = "preciopromo";
            this.precioPromo.HeaderText = "precioPromo";
            this.precioPromo.Name = "precioPromo";
            this.precioPromo.Visible = false;
            // 
            // ListaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListaEntradas";
            this.Text = "ListaEntradas";
            this.Load += new System.EventHandler(this.ListaEntradas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView gridTicket;
        private Button btnActualizarCombo;
        private DataGridViewTextBoxColumn nroTicket;
        private DataGridViewTextBoxColumn fechaHoraVenta;
        private DataGridViewTextBoxColumn CodMedioPago;
        private DataGridViewTextBoxColumn MedioPago;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Promo;
        private DataGridViewTextBoxColumn precioPromo;
    }
}