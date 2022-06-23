namespace ProbandoMigrar.Reportes.Entrada
{
    partial class ReporteEntrada
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.txtLeyendaTarifa = new System.Windows.Forms.Label();
            this.lblListadoTarifas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbFormato = new System.Windows.Forms.RadioButton();
            this.rdbTodasEntradas = new System.Windows.Forms.RadioButton();
            this.rdbPrecioUnitario = new System.Windows.Forms.RadioButton();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.rdbMenorQue = new System.Windows.Forms.RadioButton();
            this.rdbMayorQue = new System.Windows.Forms.RadioButton();
            this.mtbFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.mtbFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.lblHistoriaEntradas = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelSuperior.Controls.Add(this.lblHistoriaEntradas);
            this.panelSuperior.Controls.Add(this.txtLeyendaTarifa);
            this.panelSuperior.Controls.Add(this.lblListadoTarifas);
            this.panelSuperior.Controls.Add(this.panel1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 230);
            this.panelSuperior.TabIndex = 2;
            // 
            // txtLeyendaTarifa
            // 
            this.txtLeyendaTarifa.AutoSize = true;
            this.txtLeyendaTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtLeyendaTarifa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtLeyendaTarifa.ForeColor = System.Drawing.Color.Yellow;
            this.txtLeyendaTarifa.Location = new System.Drawing.Point(15, 192);
            this.txtLeyendaTarifa.Name = "txtLeyendaTarifa";
            this.txtLeyendaTarifa.Size = new System.Drawing.Size(0, 28);
            this.txtLeyendaTarifa.TabIndex = 23;
            // 
            // lblListadoTarifas
            // 
            this.lblListadoTarifas.AutoSize = true;
            this.lblListadoTarifas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblListadoTarifas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblListadoTarifas.ForeColor = System.Drawing.Color.White;
            this.lblListadoTarifas.Location = new System.Drawing.Point(15, 25);
            this.lblListadoTarifas.Name = "lblListadoTarifas";
            this.lblListadoTarifas.Size = new System.Drawing.Size(168, 28);
            this.lblListadoTarifas.TabIndex = 22;
            this.lblListadoTarifas.Text = "Listado Entradas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.mtbFechaHasta);
            this.panel1.Controls.Add(this.mtbFechaDesde);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mtbHasta);
            this.panel1.Controls.Add(this.mtbDesde);
            this.panel1.Controls.Add(this.rdbEntre);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.rdbMenorQue);
            this.panel1.Controls.Add(this.rdbMayorQue);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 122);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbFormato);
            this.panel2.Controls.Add(this.rdbTodasEntradas);
            this.panel2.Controls.Add(this.rdbPrecioUnitario);
            this.panel2.Location = new System.Drawing.Point(8, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 22;
            // 
            // rdbFormato
            // 
            this.rdbFormato.AutoSize = true;
            this.rdbFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFormato.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbFormato.Location = new System.Drawing.Point(12, 69);
            this.rdbFormato.Name = "rdbFormato";
            this.rdbFormato.Size = new System.Drawing.Size(119, 22);
            this.rdbFormato.TabIndex = 13;
            this.rdbFormato.Text = "Fecha Venta";
            this.rdbFormato.UseVisualStyleBackColor = true;
            this.rdbFormato.CheckedChanged += new System.EventHandler(this.rdbFormato_CheckedChanged);
            // 
            // rdbTodasEntradas
            // 
            this.rdbTodasEntradas.AutoSize = true;
            this.rdbTodasEntradas.Checked = true;
            this.rdbTodasEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodasEntradas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbTodasEntradas.Location = new System.Drawing.Point(12, 11);
            this.rdbTodasEntradas.Name = "rdbTodasEntradas";
            this.rdbTodasEntradas.Size = new System.Drawing.Size(172, 22);
            this.rdbTodasEntradas.TabIndex = 12;
            this.rdbTodasEntradas.TabStop = true;
            this.rdbTodasEntradas.Text = "Todas las Entradas";
            this.rdbTodasEntradas.UseVisualStyleBackColor = true;
            this.rdbTodasEntradas.CheckedChanged += new System.EventHandler(this.rdbTodasEntradas_CheckedChanged);
            // 
            // rdbPrecioUnitario
            // 
            this.rdbPrecioUnitario.AutoSize = true;
            this.rdbPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrecioUnitario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPrecioUnitario.Location = new System.Drawing.Point(12, 39);
            this.rdbPrecioUnitario.Name = "rdbPrecioUnitario";
            this.rdbPrecioUnitario.Size = new System.Drawing.Size(139, 22);
            this.rdbPrecioUnitario.TabIndex = 11;
            this.rdbPrecioUnitario.Text = "Precio Unitario";
            this.rdbPrecioUnitario.UseVisualStyleBackColor = true;
            this.rdbPrecioUnitario.CheckedChanged += new System.EventHandler(this.rdbPrecioUnitario_CheckedChanged);
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(485, 49);
            this.mtbHasta.Mask = "9999999";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 21;
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(370, 49);
            this.mtbDesde.Mask = "9999999";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 20;
            this.mtbDesde.Visible = false;
            // 
            // rdbEntre
            // 
            this.rdbEntre.AutoSize = true;
            this.rdbEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbEntre.Location = new System.Drawing.Point(235, 51);
            this.rdbEntre.Name = "rdbEntre";
            this.rdbEntre.Size = new System.Drawing.Size(66, 22);
            this.rdbEntre.TabIndex = 16;
            this.rdbEntre.Text = "Entre";
            this.rdbEntre.UseVisualStyleBackColor = true;
            this.rdbEntre.Visible = false;
            this.rdbEntre.CheckedChanged += new System.EventHandler(this.rdbEntre_CheckedChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarProducto.Location = new System.Drawing.Point(627, 72);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(123, 35);
            this.btnBuscarProducto.TabIndex = 18;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // rdbMenorQue
            // 
            this.rdbMenorQue.AutoSize = true;
            this.rdbMenorQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMenorQue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbMenorQue.Location = new System.Drawing.Point(234, 79);
            this.rdbMenorQue.Name = "rdbMenorQue";
            this.rdbMenorQue.Size = new System.Drawing.Size(106, 22);
            this.rdbMenorQue.TabIndex = 15;
            this.rdbMenorQue.Text = "Menor que";
            this.rdbMenorQue.UseVisualStyleBackColor = true;
            this.rdbMenorQue.Visible = false;
            this.rdbMenorQue.CheckedChanged += new System.EventHandler(this.rdbMenorQue_CheckedChanged);
            // 
            // rdbMayorQue
            // 
            this.rdbMayorQue.AutoSize = true;
            this.rdbMayorQue.Checked = true;
            this.rdbMayorQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMayorQue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbMayorQue.Location = new System.Drawing.Point(235, 23);
            this.rdbMayorQue.Name = "rdbMayorQue";
            this.rdbMayorQue.Size = new System.Drawing.Size(105, 22);
            this.rdbMayorQue.TabIndex = 14;
            this.rdbMayorQue.TabStop = true;
            this.rdbMayorQue.Text = "Mayor que";
            this.rdbMayorQue.UseVisualStyleBackColor = true;
            this.rdbMayorQue.Visible = false;
            this.rdbMayorQue.CheckedChanged += new System.EventHandler(this.rdbMayorQue_CheckedChanged);
            // 
            // mtbFechaDesde
            // 
            this.mtbFechaDesde.Location = new System.Drawing.Point(251, 49);
            this.mtbFechaDesde.Mask = "00/00/0000";
            this.mtbFechaDesde.Name = "mtbFechaDesde";
            this.mtbFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbFechaDesde.TabIndex = 23;
            this.mtbFechaDesde.ValidatingType = typeof(System.DateTime);
            this.mtbFechaDesde.Visible = false;
            // 
            // mtbFechaHasta
            // 
            this.mtbFechaHasta.Location = new System.Drawing.Point(370, 49);
            this.mtbFechaHasta.Mask = "00/00/0000";
            this.mtbFechaHasta.Name = "mtbFechaHasta";
            this.mtbFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbFechaHasta.TabIndex = 24;
            this.mtbFechaHasta.ValidatingType = typeof(System.DateTime);
            this.mtbFechaHasta.Visible = false;
            // 
            // lblHistoriaEntradas
            // 
            this.lblHistoriaEntradas.AutoSize = true;
            this.lblHistoriaEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblHistoriaEntradas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHistoriaEntradas.ForeColor = System.Drawing.Color.Yellow;
            this.lblHistoriaEntradas.Location = new System.Drawing.Point(15, 192);
            this.lblHistoriaEntradas.Name = "lblHistoriaEntradas";
            this.lblHistoriaEntradas.Size = new System.Drawing.Size(0, 28);
            this.lblHistoriaEntradas.TabIndex = 25;
            this.lblHistoriaEntradas.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Entrada.ReporteEntrada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 230);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 220);
            this.reportViewer1.TabIndex = 3;
            // 
            // ReporteEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelSuperior);
            this.Name = "ReporteEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEntrada";
            this.Load += new System.EventHandler(this.ReporteEntrada_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label txtLeyendaTarifa;
        private System.Windows.Forms.Label lblListadoTarifas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbFormato;
        private System.Windows.Forms.RadioButton rdbTodasEntradas;
        private System.Windows.Forms.RadioButton rdbPrecioUnitario;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.RadioButton rdbMenorQue;
        private System.Windows.Forms.RadioButton rdbMayorQue;
        private System.Windows.Forms.MaskedTextBox mtbFechaDesde;
        private System.Windows.Forms.MaskedTextBox mtbFechaHasta;
        private System.Windows.Forms.Label lblHistoriaEntradas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}