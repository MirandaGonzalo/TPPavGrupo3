namespace ProbandoMigrar.Estadisticas.Combo
{
    partial class EstadisticaCombo
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
            this.rbPeriodoCompra = new System.Windows.Forms.RadioButton();
            this.rbComprados = new System.Windows.Forms.RadioButton();
            this.rbCantItems = new System.Windows.Forms.RadioButton();
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
            this.panelSup.Size = new System.Drawing.Size(1287, 206);
            this.panelSup.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Location = new System.Drawing.Point(417, 72);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(635, 105);
            this.panelParam.TabIndex = 17;
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
            this.panel1.Controls.Add(this.rbPeriodoCompra);
            this.panel1.Controls.Add(this.rbComprados);
            this.panel1.Controls.Add(this.rbCantItems);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 105);
            this.panel1.TabIndex = 16;
            // 
            // rbPeriodoCompra
            // 
            this.rbPeriodoCompra.AutoSize = true;
            this.rbPeriodoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbPeriodoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodoCompra.ForeColor = System.Drawing.Color.White;
            this.rbPeriodoCompra.Location = new System.Drawing.Point(195, 15);
            this.rbPeriodoCompra.Name = "rbPeriodoCompra";
            this.rbPeriodoCompra.Size = new System.Drawing.Size(150, 22);
            this.rbPeriodoCompra.TabIndex = 14;
            this.rbPeriodoCompra.Text = "Período Compra";
            this.rbPeriodoCompra.UseVisualStyleBackColor = false;
            this.rbPeriodoCompra.CheckedChanged += new System.EventHandler(this.rbPeriodoCompra_CheckedChanged);
            // 
            // rbComprados
            // 
            this.rbComprados.AutoSize = true;
            this.rbComprados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComprados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbComprados.Location = new System.Drawing.Point(19, 65);
            this.rbComprados.Name = "rbComprados";
            this.rbComprados.Size = new System.Drawing.Size(114, 22);
            this.rbComprados.TabIndex = 13;
            this.rbComprados.Text = "Comprados";
            this.rbComprados.UseVisualStyleBackColor = true;
            this.rbComprados.CheckedChanged += new System.EventHandler(this.rbComprados_CheckedChanged);
            // 
            // rbCantItems
            // 
            this.rbCantItems.AutoSize = true;
            this.rbCantItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbCantItems.Checked = true;
            this.rbCantItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCantItems.ForeColor = System.Drawing.Color.White;
            this.rbCantItems.Location = new System.Drawing.Point(19, 15);
            this.rbCantItems.Name = "rbCantItems";
            this.rbCantItems.Size = new System.Drawing.Size(112, 22);
            this.rbCantItems.TabIndex = 3;
            this.rbCantItems.TabStop = true;
            this.rbCantItems.Text = "Cant. Items";
            this.rbCantItems.UseVisualStyleBackColor = false;
            this.rbCantItems.CheckedChanged += new System.EventHandler(this.rbCantItems_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Listado de Combos";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 467);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1287, 100);
            this.panelInf.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.Combo.EstadisticaCombo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 206);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1287, 261);
            this.reportViewer1.TabIndex = 2;
            // 
            // EstadisticaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 567);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaCombo";
            this.Load += new System.EventHandler(this.EstadisticaCombo_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPeriodoCompra;
        private System.Windows.Forms.RadioButton rbComprados;
        private System.Windows.Forms.RadioButton rbCantItems;
        private System.Windows.Forms.Panel panelInf;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}