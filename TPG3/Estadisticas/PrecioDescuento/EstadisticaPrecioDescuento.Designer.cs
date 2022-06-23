
namespace ProbandoMigrar.Estadisticas.PrecioDescuento
{
    partial class EstadisticaPrecioDescuento
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
            this.panelParam = new System.Windows.Forms.Panel();
            this.btnBuscarFuncion = new System.Windows.Forms.Button();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.rbPeriodoCombo = new System.Windows.Forms.RadioButton();
            this.rbPeriodoEntrada = new System.Windows.Forms.RadioButton();
            this.rbCombos = new System.Windows.Forms.RadioButton();
            this.rbEntradas = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.rpvPrecioDescuento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSuperior.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelSuperior.Controls.Add(this.panelParam);
            this.panelSuperior.Controls.Add(this.panelOpciones);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(952, 169);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Location = new System.Drawing.Point(422, 48);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(511, 105);
            this.panelParam.TabIndex = 18;
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarFuncion.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarFuncion.Location = new System.Drawing.Point(369, 47);
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
            this.mtbHasta.Location = new System.Drawing.Point(189, 47);
            this.mtbHasta.Mask = "00/00/0000";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 26;
            this.mtbHasta.ValidatingType = typeof(System.DateTime);
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(29, 47);
            this.mtbDesde.Mask = "00/00/0000";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 25;
            this.mtbDesde.ValidatingType = typeof(System.DateTime);
            this.mtbDesde.Visible = false;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelOpciones.Controls.Add(this.rbPeriodoCombo);
            this.panelOpciones.Controls.Add(this.rbPeriodoEntrada);
            this.panelOpciones.Controls.Add(this.rbCombos);
            this.panelOpciones.Controls.Add(this.rbEntradas);
            this.panelOpciones.Location = new System.Drawing.Point(33, 48);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(383, 105);
            this.panelOpciones.TabIndex = 17;
            // 
            // rbPeriodoCombo
            // 
            this.rbPeriodoCombo.AutoSize = true;
            this.rbPeriodoCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbPeriodoCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodoCombo.ForeColor = System.Drawing.Color.White;
            this.rbPeriodoCombo.Location = new System.Drawing.Point(195, 65);
            this.rbPeriodoCombo.Name = "rbPeriodoCombo";
            this.rbPeriodoCombo.Size = new System.Drawing.Size(145, 22);
            this.rbPeriodoCombo.TabIndex = 15;
            this.rbPeriodoCombo.Text = "Período Combo";
            this.rbPeriodoCombo.UseVisualStyleBackColor = false;
            this.rbPeriodoCombo.CheckedChanged += new System.EventHandler(this.rbPeriodoCombo_CheckedChanged);
            // 
            // rbPeriodoEntrada
            // 
            this.rbPeriodoEntrada.AutoSize = true;
            this.rbPeriodoEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbPeriodoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodoEntrada.ForeColor = System.Drawing.Color.White;
            this.rbPeriodoEntrada.Location = new System.Drawing.Point(195, 15);
            this.rbPeriodoEntrada.Name = "rbPeriodoEntrada";
            this.rbPeriodoEntrada.Size = new System.Drawing.Size(148, 22);
            this.rbPeriodoEntrada.TabIndex = 14;
            this.rbPeriodoEntrada.Text = "Período Entrada";
            this.rbPeriodoEntrada.UseVisualStyleBackColor = false;
            this.rbPeriodoEntrada.CheckedChanged += new System.EventHandler(this.rbPeriodoEntrada_CheckedChanged);
            // 
            // rbCombos
            // 
            this.rbCombos.AutoSize = true;
            this.rbCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCombos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbCombos.Location = new System.Drawing.Point(19, 65);
            this.rbCombos.Name = "rbCombos";
            this.rbCombos.Size = new System.Drawing.Size(90, 22);
            this.rbCombos.TabIndex = 13;
            this.rbCombos.Text = "Combos";
            this.rbCombos.UseVisualStyleBackColor = true;
            this.rbCombos.CheckedChanged += new System.EventHandler(this.rbCombos_CheckedChanged);
            // 
            // rbEntradas
            // 
            this.rbEntradas.AutoSize = true;
            this.rbEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rbEntradas.Checked = true;
            this.rbEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEntradas.ForeColor = System.Drawing.Color.White;
            this.rbEntradas.Location = new System.Drawing.Point(19, 15);
            this.rbEntradas.Name = "rbEntradas";
            this.rbEntradas.Size = new System.Drawing.Size(93, 22);
            this.rbEntradas.TabIndex = 3;
            this.rbEntradas.TabStop = true;
            this.rbEntradas.Text = "Entradas";
            this.rbEntradas.UseVisualStyleBackColor = false;
            this.rbEntradas.CheckedChanged += new System.EventHandler(this.rbEntradas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Listado de Precios / Descuento";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 420);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(952, 45);
            this.panelInferior.TabIndex = 1;
            // 
            // rpvPrecioDescuento
            // 
            this.rpvPrecioDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvPrecioDescuento.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.PrecioDescuento.EstadisticaPrecioDescuento.rdlc";
            this.rpvPrecioDescuento.Location = new System.Drawing.Point(0, 169);
            this.rpvPrecioDescuento.Name = "rpvPrecioDescuento";
            this.rpvPrecioDescuento.ServerReport.BearerToken = null;
            this.rpvPrecioDescuento.Size = new System.Drawing.Size(952, 251);
            this.rpvPrecioDescuento.TabIndex = 2;
            // 
            // EstadisticaPrecioDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 465);
            this.Controls.Add(this.rpvPrecioDescuento);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Name = "EstadisticaPrecioDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaPrecioDescuento";
            this.Load += new System.EventHandler(this.EstadisticaPrecioDescuento_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.RadioButton rbPeriodoCombo;
        private System.Windows.Forms.RadioButton rbPeriodoEntrada;
        private System.Windows.Forms.RadioButton rbCombos;
        private System.Windows.Forms.RadioButton rbEntradas;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPrecioDescuento;
    }
}