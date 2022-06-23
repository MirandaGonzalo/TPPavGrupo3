namespace ProbandoMigrar.Estadisticas.TicketEntrada
{
    partial class EstadisticaTicketEntrada
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
            this.panelSup = new System.Windows.Forms.Panel();
            this.panelParam = new System.Windows.Forms.Panel();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarFuncion = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTarifa = new System.Windows.Forms.RadioButton();
            this.rbFechaVenta = new System.Windows.Forms.RadioButton();
            this.rbPelicula = new System.Windows.Forms.RadioButton();
            this.rbSala = new System.Windows.Forms.RadioButton();
            this.rbMedioPago = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.rpvEntradas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSup.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelSup.Controls.Add(this.panelParam);
            this.panelSup.Controls.Add(this.panel1);
            this.panelSup.Controls.Add(this.label4);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(1303, 236);
            this.panelSup.TabIndex = 1;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.btnBuscarProducto);
            this.panelParam.Location = new System.Drawing.Point(627, 81);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(602, 113);
            this.panelParam.TabIndex = 13;
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(203, 38);
            this.mtbHasta.Mask = "00/00/0000";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 30;
            this.mtbHasta.ValidatingType = typeof(System.DateTime);
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(51, 38);
            this.mtbDesde.Mask = "00/00/0000";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 29;
            this.mtbDesde.ValidatingType = typeof(System.DateTime);
            this.mtbDesde.Visible = false;
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarFuncion.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarFuncion.Location = new System.Drawing.Point(450, 58);
            this.btnBuscarFuncion.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarFuncion.Name = "btnBuscarFuncion";
            this.btnBuscarFuncion.Size = new System.Drawing.Size(123, 35);
            this.btnBuscarFuncion.TabIndex = 28;
            this.btnBuscarFuncion.Text = "Buscar";
            this.btnBuscarFuncion.UseVisualStyleBackColor = false;
            this.btnBuscarFuncion.Click += new System.EventHandler(this.btnBuscarFuncion_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarProducto.Location = new System.Drawing.Point(756, 58);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(123, 35);
            this.btnBuscarProducto.TabIndex = 27;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.rbTarifa);
            this.panel1.Controls.Add(this.rbFechaVenta);
            this.panel1.Controls.Add(this.rbPelicula);
            this.panel1.Controls.Add(this.rbSala);
            this.panel1.Controls.Add(this.rbMedioPago);
            this.panel1.Location = new System.Drawing.Point(33, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 113);
            this.panel1.TabIndex = 3;
            // 
            // rbTarifa
            // 
            this.rbTarifa.AutoSize = true;
            this.rbTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarifa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbTarifa.Location = new System.Drawing.Point(31, 71);
            this.rbTarifa.Name = "rbTarifa";
            this.rbTarifa.Size = new System.Drawing.Size(69, 22);
            this.rbTarifa.TabIndex = 16;
            this.rbTarifa.Text = "Tarifa";
            this.rbTarifa.UseVisualStyleBackColor = true;
            this.rbTarifa.CheckedChanged += new System.EventHandler(this.rbTarifa_CheckedChanged);
            // 
            // rbFechaVenta
            // 
            this.rbFechaVenta.AutoSize = true;
            this.rbFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbFechaVenta.Location = new System.Drawing.Point(390, 24);
            this.rbFechaVenta.Name = "rbFechaVenta";
            this.rbFechaVenta.Size = new System.Drawing.Size(119, 22);
            this.rbFechaVenta.TabIndex = 15;
            this.rbFechaVenta.Text = "Fecha Venta";
            this.rbFechaVenta.UseVisualStyleBackColor = true;
            this.rbFechaVenta.CheckedChanged += new System.EventHandler(this.rbFechaVenta_CheckedChanged);
            // 
            // rbPelicula
            // 
            this.rbPelicula.AutoSize = true;
            this.rbPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbPelicula.Location = new System.Drawing.Point(193, 71);
            this.rbPelicula.Name = "rbPelicula";
            this.rbPelicula.Size = new System.Drawing.Size(85, 22);
            this.rbPelicula.TabIndex = 14;
            this.rbPelicula.Text = "Película";
            this.rbPelicula.UseVisualStyleBackColor = true;
            this.rbPelicula.CheckedChanged += new System.EventHandler(this.rbPelicula_CheckedChanged);
            // 
            // rbSala
            // 
            this.rbSala.AutoSize = true;
            this.rbSala.Checked = true;
            this.rbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSala.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbSala.Location = new System.Drawing.Point(31, 24);
            this.rbSala.Name = "rbSala";
            this.rbSala.Size = new System.Drawing.Size(59, 22);
            this.rbSala.TabIndex = 13;
            this.rbSala.TabStop = true;
            this.rbSala.Text = "Sala";
            this.rbSala.UseVisualStyleBackColor = true;
            this.rbSala.CheckedChanged += new System.EventHandler(this.rbSala_CheckedChanged);
            // 
            // rbMedioPago
            // 
            this.rbMedioPago.AutoSize = true;
            this.rbMedioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedioPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbMedioPago.Location = new System.Drawing.Point(193, 24);
            this.rbMedioPago.Name = "rbMedioPago";
            this.rbMedioPago.Size = new System.Drawing.Size(139, 22);
            this.rbMedioPago.TabIndex = 12;
            this.rbMedioPago.Text = "Medio de Pago";
            this.rbMedioPago.UseVisualStyleBackColor = true;
            this.rbMedioPago.CheckedChanged += new System.EventHandler(this.rdbMedioPago_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Listado de Entradas Vendidas";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 649);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1303, 100);
            this.panelInf.TabIndex = 2;
            // 
            // rpvEntradas
            // 
            this.rpvEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvEntradas.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.TicketEntrada.EstadisticaTicketEntrada.rdlc";
            this.rpvEntradas.Location = new System.Drawing.Point(0, 236);
            this.rpvEntradas.Name = "rpvEntradas";
            this.rpvEntradas.ServerReport.BearerToken = null;
            this.rpvEntradas.Size = new System.Drawing.Size(1303, 413);
            this.rpvEntradas.TabIndex = 3;
            // 
            // EstadisticaTicketEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 749);
            this.Controls.Add(this.rpvEntradas);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaTicketEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaTicketEntrada";
            this.Load += new System.EventHandler(this.EstadisticaTicketEntrada_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMedioPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbTarifa;
        private System.Windows.Forms.RadioButton rbFechaVenta;
        private System.Windows.Forms.RadioButton rbPelicula;
        private System.Windows.Forms.RadioButton rbSala;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.Panel panelInf;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEntradas;
    }
}