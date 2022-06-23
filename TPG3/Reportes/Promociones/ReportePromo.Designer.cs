namespace ProbandoMigrar.Reportes.Promociones
{
    partial class ReportePromo
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
            this.lblHistoriaPromocion = new System.Windows.Forms.Label();
            this.lblListadoPromo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbHastaVigencia = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesdeVigencia = new System.Windows.Forms.MaskedTextBox();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.rdbMenorQue = new System.Windows.Forms.RadioButton();
            this.rdbMayorQue = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbTodasPromociones = new System.Windows.Forms.RadioButton();
            this.rdbPrecio = new System.Windows.Forms.RadioButton();
            this.rdbVigencia = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.panelInferiorr = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelSuperior.Controls.Add(this.lblHistoriaPromocion);
            this.panelSuperior.Controls.Add(this.lblListadoPromo);
            this.panelSuperior.Controls.Add(this.panel1);
            this.panelSuperior.Controls.Add(this.panel2);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1370, 244);
            this.panelSuperior.TabIndex = 1;
            // 
            // lblHistoriaPromocion
            // 
            this.lblHistoriaPromocion.AutoSize = true;
            this.lblHistoriaPromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblHistoriaPromocion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHistoriaPromocion.ForeColor = System.Drawing.Color.Yellow;
            this.lblHistoriaPromocion.Location = new System.Drawing.Point(15, 194);
            this.lblHistoriaPromocion.Name = "lblHistoriaPromocion";
            this.lblHistoriaPromocion.Size = new System.Drawing.Size(0, 28);
            this.lblHistoriaPromocion.TabIndex = 23;
            // 
            // lblListadoPromo
            // 
            this.lblListadoPromo.AutoSize = true;
            this.lblListadoPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblListadoPromo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblListadoPromo.ForeColor = System.Drawing.Color.White;
            this.lblListadoPromo.Location = new System.Drawing.Point(15, 25);
            this.lblListadoPromo.Name = "lblListadoPromo";
            this.lblListadoPromo.Size = new System.Drawing.Size(208, 28);
            this.lblListadoPromo.TabIndex = 22;
            this.lblListadoPromo.Text = "Listado Promociones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.mtbHastaVigencia);
            this.panel1.Controls.Add(this.mtbDesdeVigencia);
            this.panel1.Controls.Add(this.mtbHasta);
            this.panel1.Controls.Add(this.mtbDesde);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.rdbEntre);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.rdbMenorQue);
            this.panel1.Controls.Add(this.rdbMayorQue);
            this.panel1.Location = new System.Drawing.Point(484, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 122);
            this.panel1.TabIndex = 21;
            // 
            // mtbHastaVigencia
            // 
            this.mtbHastaVigencia.Location = new System.Drawing.Point(290, 48);
            this.mtbHastaVigencia.Mask = "00/00/0000";
            this.mtbHastaVigencia.Name = "mtbHastaVigencia";
            this.mtbHastaVigencia.Size = new System.Drawing.Size(100, 20);
            this.mtbHastaVigencia.TabIndex = 25;
            this.mtbHastaVigencia.ValidatingType = typeof(System.DateTime);
            this.mtbHastaVigencia.Visible = false;
            // 
            // mtbDesdeVigencia
            // 
            this.mtbDesdeVigencia.Location = new System.Drawing.Point(172, 47);
            this.mtbDesdeVigencia.Mask = "00/00/0000";
            this.mtbDesdeVigencia.Name = "mtbDesdeVigencia";
            this.mtbDesdeVigencia.Size = new System.Drawing.Size(100, 20);
            this.mtbDesdeVigencia.TabIndex = 24;
            this.mtbDesdeVigencia.ValidatingType = typeof(System.DateTime);
            this.mtbDesdeVigencia.Visible = false;
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(290, 48);
            this.mtbHasta.Mask = "9999999";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 21;
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(172, 48);
            this.mtbDesde.Mask = "9999999";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 20;
            this.mtbDesde.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.Visible = false;
            // 
            // rdbEntre
            // 
            this.rdbEntre.AutoSize = true;
            this.rdbEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbEntre.Location = new System.Drawing.Point(18, 47);
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(431, 71);
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
            this.rdbMenorQue.Location = new System.Drawing.Point(17, 75);
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
            this.rdbMayorQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMayorQue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbMayorQue.Location = new System.Drawing.Point(18, 19);
            this.rdbMayorQue.Name = "rdbMayorQue";
            this.rdbMayorQue.Size = new System.Drawing.Size(105, 22);
            this.rdbMayorQue.TabIndex = 14;
            this.rdbMayorQue.Text = "Mayor que";
            this.rdbMayorQue.UseVisualStyleBackColor = true;
            this.rdbMayorQue.Visible = false;
            this.rdbMayorQue.CheckedChanged += new System.EventHandler(this.rdbMayorQue_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.rdbTodasPromociones);
            this.panel2.Controls.Add(this.rdbPrecio);
            this.panel2.Controls.Add(this.rdbVigencia);
            this.panel2.Controls.Add(this.rdbNombre);
            this.panel2.Location = new System.Drawing.Point(62, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 124);
            this.panel2.TabIndex = 26;
            // 
            // rdbTodasPromociones
            // 
            this.rdbTodasPromociones.AutoSize = true;
            this.rdbTodasPromociones.Checked = true;
            this.rdbTodasPromociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodasPromociones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbTodasPromociones.Location = new System.Drawing.Point(8, 24);
            this.rdbTodasPromociones.Name = "rdbTodasPromociones";
            this.rdbTodasPromociones.Size = new System.Drawing.Size(206, 22);
            this.rdbTodasPromociones.TabIndex = 12;
            this.rdbTodasPromociones.TabStop = true;
            this.rdbTodasPromociones.Text = "Todas las Promociones";
            this.rdbTodasPromociones.UseVisualStyleBackColor = true;
            this.rdbTodasPromociones.CheckedChanged += new System.EventHandler(this.rdbTodasPromociones_CheckedChanged);
            // 
            // rdbPrecio
            // 
            this.rdbPrecio.AutoSize = true;
            this.rdbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPrecio.Location = new System.Drawing.Point(8, 83);
            this.rdbPrecio.Name = "rdbPrecio";
            this.rdbPrecio.Size = new System.Drawing.Size(75, 22);
            this.rdbPrecio.TabIndex = 11;
            this.rdbPrecio.Text = "Precio";
            this.rdbPrecio.UseVisualStyleBackColor = true;
            this.rdbPrecio.CheckedChanged += new System.EventHandler(this.rdbPrecio_CheckedChanged);
            // 
            // rdbVigencia
            // 
            this.rdbVigencia.AutoSize = true;
            this.rdbVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVigencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbVigencia.Location = new System.Drawing.Point(236, 83);
            this.rdbVigencia.Name = "rdbVigencia";
            this.rdbVigencia.Size = new System.Drawing.Size(89, 22);
            this.rdbVigencia.TabIndex = 23;
            this.rdbVigencia.Text = "Vigencia";
            this.rdbVigencia.UseVisualStyleBackColor = true;
            this.rdbVigencia.CheckedChanged += new System.EventHandler(this.rdbVigencia_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbNombre.Location = new System.Drawing.Point(236, 24);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(86, 22);
            this.rdbNombre.TabIndex = 22;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // panelInferiorr
            // 
            this.panelInferiorr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInferiorr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorr.Location = new System.Drawing.Point(0, 566);
            this.panelInferiorr.Name = "panelInferiorr";
            this.panelInferiorr.Size = new System.Drawing.Size(1370, 67);
            this.panelInferiorr.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Promociones.ReportePromocion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 244);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1370, 322);
            this.reportViewer1.TabIndex = 3;
            // 
            // ReportePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 633);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelInferiorr);
            this.Controls.Add(this.panelSuperior);
            this.Name = "ReportePromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Promociones";
            this.Load += new System.EventHandler(this.ReportePromo_Load);
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
        private System.Windows.Forms.Label lblListadoPromo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbTodasPromociones;
        private System.Windows.Forms.RadioButton rdbPrecio;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.RadioButton rdbMenorQue;
        private System.Windows.Forms.RadioButton rdbMayorQue;
        private System.Windows.Forms.RadioButton rdbVigencia;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.MaskedTextBox mtbHastaVigencia;
        private System.Windows.Forms.MaskedTextBox mtbDesdeVigencia;
        private System.Windows.Forms.Panel panelInferiorr;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblHistoriaPromocion;
        private System.Windows.Forms.Panel panel2;
    }
}