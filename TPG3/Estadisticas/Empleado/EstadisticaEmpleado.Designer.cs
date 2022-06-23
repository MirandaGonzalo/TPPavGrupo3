namespace ProbandoMigrar.Estadisticas.Empleado
{
    partial class EstadisticaEmpleado
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
            this.btnBuscarFuncion = new System.Windows.Forms.Button();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPeriodoEntradas = new System.Windows.Forms.RadioButton();
            this.rbTipoDoc = new System.Windows.Forms.RadioButton();
            this.rbVentasEntradas = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.panelSup.Size = new System.Drawing.Size(1259, 203);
            this.panelSup.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Location = new System.Drawing.Point(435, 70);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(635, 105);
            this.panelParam.TabIndex = 15;
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarFuncion.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarFuncion.Location = new System.Drawing.Point(483, 52);
            this.btnBuscarFuncion.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarFuncion.Name = "btnBuscarFuncion";
            this.btnBuscarFuncion.Size = new System.Drawing.Size(123, 35);
            this.btnBuscarFuncion.TabIndex = 27;
            this.btnBuscarFuncion.Text = "Buscar";
            this.btnBuscarFuncion.UseVisualStyleBackColor = false;
            this.btnBuscarFuncion.Click += new System.EventHandler(this.btnBuscarFuncion_Click);
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(245, 47);
            this.mtbHasta.Mask = "00/00/0000";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 26;
            this.mtbHasta.ValidatingType = typeof(System.DateTime);
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(130, 47);
            this.mtbDesde.Mask = "00/00/0000";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 25;
            this.mtbDesde.ValidatingType = typeof(System.DateTime);
            this.mtbDesde.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.rbPeriodoEntradas);
            this.panel1.Controls.Add(this.rbTipoDoc);
            this.panel1.Controls.Add(this.rbVentasEntradas);
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 105);
            this.panel1.TabIndex = 5;
            // 
            // rbPeriodoEntradas
            // 
            this.rbPeriodoEntradas.AutoSize = true;
            this.rbPeriodoEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbPeriodoEntradas.Checked = true;
            this.rbPeriodoEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodoEntradas.ForeColor = System.Drawing.Color.White;
            this.rbPeriodoEntradas.Location = new System.Drawing.Point(195, 15);
            this.rbPeriodoEntradas.Name = "rbPeriodoEntradas";
            this.rbPeriodoEntradas.Size = new System.Drawing.Size(157, 22);
            this.rbPeriodoEntradas.TabIndex = 14;
            this.rbPeriodoEntradas.TabStop = true;
            this.rbPeriodoEntradas.Text = "Período Entradas";
            this.rbPeriodoEntradas.UseVisualStyleBackColor = false;
            this.rbPeriodoEntradas.CheckedChanged += new System.EventHandler(this.rbPeriodoEntradas_CheckedChanged);
            // 
            // rbTipoDoc
            // 
            this.rbTipoDoc.AutoSize = true;
            this.rbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoDoc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbTipoDoc.Location = new System.Drawing.Point(19, 65);
            this.rbTipoDoc.Name = "rbTipoDoc";
            this.rbTipoDoc.Size = new System.Drawing.Size(151, 22);
            this.rbTipoDoc.TabIndex = 13;
            this.rbTipoDoc.Text = "Tipo Documento";
            this.rbTipoDoc.UseVisualStyleBackColor = true;
            this.rbTipoDoc.CheckedChanged += new System.EventHandler(this.rbPeríodo_CheckedChanged);
            // 
            // rbVentasEntradas
            // 
            this.rbVentasEntradas.AutoSize = true;
            this.rbVentasEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbVentasEntradas.Checked = true;
            this.rbVentasEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVentasEntradas.ForeColor = System.Drawing.Color.White;
            this.rbVentasEntradas.Location = new System.Drawing.Point(19, 15);
            this.rbVentasEntradas.Name = "rbVentasEntradas";
            this.rbVentasEntradas.Size = new System.Drawing.Size(93, 22);
            this.rbVentasEntradas.TabIndex = 3;
            this.rbVentasEntradas.TabStop = true;
            this.rbVentasEntradas.Text = "Entradas";
            this.rbVentasEntradas.UseVisualStyleBackColor = false;
            this.rbVentasEntradas.CheckedChanged += new System.EventHandler(this.rbVentasEntradas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Listado de Empleados";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 517);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1259, 65);
            this.panelInf.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.Empleado.EstadisticaEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 203);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1259, 314);
            this.reportViewer1.TabIndex = 2;
            // 
            // EstadisticaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 582);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaEmpleado";
            this.Load += new System.EventHandler(this.EstadisticaEmpleado_Load);
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
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPeriodoEntradas;
        private System.Windows.Forms.RadioButton rbTipoDoc;
        private System.Windows.Forms.RadioButton rbVentasEntradas;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}