namespace ProbandoMigrar.Estadisticas.Descuentos
{
    partial class EstadisticaDescuento
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
            this.rbPeríodo = new System.Windows.Forms.RadioButton();
            this.rbTodosDescuentos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.rpvDescuento = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.panelSup.Size = new System.Drawing.Size(1231, 213);
            this.panelSup.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Location = new System.Drawing.Point(360, 66);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(817, 105);
            this.panelParam.TabIndex = 14;
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarFuncion.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarFuncion.Location = new System.Drawing.Point(605, 58);
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
            this.panel1.Controls.Add(this.rbPeríodo);
            this.panel1.Controls.Add(this.rbTodosDescuentos);
            this.panel1.Location = new System.Drawing.Point(29, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 105);
            this.panel1.TabIndex = 4;
            // 
            // rbPeríodo
            // 
            this.rbPeríodo.AutoSize = true;
            this.rbPeríodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeríodo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbPeríodo.Location = new System.Drawing.Point(19, 65);
            this.rbPeríodo.Name = "rbPeríodo";
            this.rbPeríodo.Size = new System.Drawing.Size(85, 22);
            this.rbPeríodo.TabIndex = 13;
            this.rbPeríodo.Text = "Período";
            this.rbPeríodo.UseVisualStyleBackColor = true;
            this.rbPeríodo.CheckedChanged += new System.EventHandler(this.rbPeríodo_CheckedChanged);
            // 
            // rbTodosDescuentos
            // 
            this.rbTodosDescuentos.AutoSize = true;
            this.rbTodosDescuentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbTodosDescuentos.Checked = true;
            this.rbTodosDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodosDescuentos.ForeColor = System.Drawing.Color.White;
            this.rbTodosDescuentos.Location = new System.Drawing.Point(19, 15);
            this.rbTodosDescuentos.Name = "rbTodosDescuentos";
            this.rbTodosDescuentos.Size = new System.Drawing.Size(194, 22);
            this.rbTodosDescuentos.TabIndex = 3;
            this.rbTodosDescuentos.TabStop = true;
            this.rbTodosDescuentos.Text = "Todos los descuentos";
            this.rbTodosDescuentos.UseVisualStyleBackColor = false;
            this.rbTodosDescuentos.CheckedChanged += new System.EventHandler(this.rdbTodosDescuentos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Listado de Descuentos";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 522);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1231, 100);
            this.panelInf.TabIndex = 1;
            // 
            // rpvDescuento
            // 
            this.rpvDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDescuento.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.Descuentos.EstadisticaDescuento.rdlc";
            this.rpvDescuento.Location = new System.Drawing.Point(0, 213);
            this.rpvDescuento.Name = "rpvDescuento";
            this.rpvDescuento.ServerReport.BearerToken = null;
            this.rpvDescuento.Size = new System.Drawing.Size(1231, 309);
            this.rpvDescuento.TabIndex = 2;
            // 
            // EstadisticaDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 622);
            this.Controls.Add(this.rpvDescuento);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaDescuento";
            this.Load += new System.EventHandler(this.EstadisticaDescuento_Load);
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
        private System.Windows.Forms.RadioButton rbPeríodo;
        private System.Windows.Forms.RadioButton rbTodosDescuentos;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDescuento;
    }
}