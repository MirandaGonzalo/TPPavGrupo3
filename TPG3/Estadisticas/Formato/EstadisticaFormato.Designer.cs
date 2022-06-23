
namespace ProbandoMigrar.Estadisticas.Formato
{
    partial class EstadisticaFormato
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
            this.rbRecaudadoPeriodo = new System.Windows.Forms.RadioButton();
            this.rbRecaudado = new System.Windows.Forms.RadioButton();
            this.rbCantEntradas = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.rpvFormato = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.panelSup.Size = new System.Drawing.Size(1014, 174);
            this.panelSup.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Location = new System.Drawing.Point(463, 51);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(485, 100);
            this.panelParam.TabIndex = 15;
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarFuncion.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarFuncion.Location = new System.Drawing.Point(341, 45);
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
            this.mtbHasta.Location = new System.Drawing.Point(177, 38);
            this.mtbHasta.Mask = "00/00/0000";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 26;
            this.mtbHasta.ValidatingType = typeof(System.DateTime);
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(38, 38);
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
            this.panel1.Controls.Add(this.rbRecaudadoPeriodo);
            this.panel1.Controls.Add(this.rbRecaudado);
            this.panel1.Controls.Add(this.rbCantEntradas);
            this.panel1.Location = new System.Drawing.Point(30, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 100);
            this.panel1.TabIndex = 5;
            // 
            // rbRecaudadoPeriodo
            // 
            this.rbRecaudadoPeriodo.AutoSize = true;
            this.rbRecaudadoPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbRecaudadoPeriodo.Checked = true;
            this.rbRecaudadoPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecaudadoPeriodo.ForeColor = System.Drawing.Color.White;
            this.rbRecaudadoPeriodo.Location = new System.Drawing.Point(213, 15);
            this.rbRecaudadoPeriodo.Name = "rbRecaudadoPeriodo";
            this.rbRecaudadoPeriodo.Size = new System.Drawing.Size(188, 22);
            this.rbRecaudadoPeriodo.TabIndex = 6;
            this.rbRecaudadoPeriodo.TabStop = true;
            this.rbRecaudadoPeriodo.Text = "Recaudación Período";
            this.rbRecaudadoPeriodo.UseVisualStyleBackColor = false;
            this.rbRecaudadoPeriodo.CheckedChanged += new System.EventHandler(this.rbRecaudadoPeriodo_CheckedChanged);
            // 
            // rbRecaudado
            // 
            this.rbRecaudado.AutoSize = true;
            this.rbRecaudado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbRecaudado.Checked = true;
            this.rbRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecaudado.ForeColor = System.Drawing.Color.White;
            this.rbRecaudado.Location = new System.Drawing.Point(18, 53);
            this.rbRecaudado.Name = "rbRecaudado";
            this.rbRecaudado.Size = new System.Drawing.Size(124, 22);
            this.rbRecaudado.TabIndex = 5;
            this.rbRecaudado.TabStop = true;
            this.rbRecaudado.Text = "Recaudación";
            this.rbRecaudado.UseVisualStyleBackColor = false;
            this.rbRecaudado.CheckedChanged += new System.EventHandler(this.rbRecaudado_CheckedChanged);
            // 
            // rbCantEntradas
            // 
            this.rbCantEntradas.AutoSize = true;
            this.rbCantEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbCantEntradas.Checked = true;
            this.rbCantEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCantEntradas.ForeColor = System.Drawing.Color.White;
            this.rbCantEntradas.Location = new System.Drawing.Point(18, 15);
            this.rbCantEntradas.Name = "rbCantEntradas";
            this.rbCantEntradas.Size = new System.Drawing.Size(164, 22);
            this.rbCantEntradas.TabIndex = 4;
            this.rbCantEntradas.TabStop = true;
            this.rbCantEntradas.Text = "Cantidad Entradas";
            this.rbCantEntradas.UseVisualStyleBackColor = false;
            this.rbCantEntradas.CheckedChanged += new System.EventHandler(this.rbCantEntradas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Listado de Formatos";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 425);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1014, 57);
            this.panelInf.TabIndex = 1;
            // 
            // rpvFormato
            // 
            this.rpvFormato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvFormato.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.Formato.EstadisticaFormato.rdlc";
            this.rpvFormato.Location = new System.Drawing.Point(0, 174);
            this.rpvFormato.Name = "rpvFormato";
            this.rpvFormato.ServerReport.BearerToken = null;
            this.rpvFormato.Size = new System.Drawing.Size(1014, 251);
            this.rpvFormato.TabIndex = 2;
            // 
            // EstadisticaFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 482);
            this.Controls.Add(this.rpvFormato);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaFormato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaFormato";
            this.Load += new System.EventHandler(this.EstadisticaFormato_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbRecaudadoPeriodo;
        private System.Windows.Forms.RadioButton rbRecaudado;
        private System.Windows.Forms.RadioButton rbCantEntradas;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvFormato;
    }
}