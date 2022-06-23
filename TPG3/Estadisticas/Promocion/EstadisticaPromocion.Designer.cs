namespace ProbandoMigrar.Estadisticas.Promocion
{
    partial class EstadisticaPromocion
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
            this.rbFechaVenta = new System.Windows.Forms.RadioButton();
            this.rbTodasPromos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.rpvPromocion = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.panelSup.Size = new System.Drawing.Size(1041, 239);
            this.panelSup.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.btnBuscarProducto);
            this.panelParam.Location = new System.Drawing.Point(423, 96);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(602, 113);
            this.panelParam.TabIndex = 15;
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
            this.panel1.Controls.Add(this.rbFechaVenta);
            this.panel1.Controls.Add(this.rbTodasPromos);
            this.panel1.Location = new System.Drawing.Point(31, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 113);
            this.panel1.TabIndex = 14;
            // 
            // rbFechaVenta
            // 
            this.rbFechaVenta.AutoSize = true;
            this.rbFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbFechaVenta.Location = new System.Drawing.Point(31, 65);
            this.rbFechaVenta.Name = "rbFechaVenta";
            this.rbFechaVenta.Size = new System.Drawing.Size(119, 22);
            this.rbFechaVenta.TabIndex = 15;
            this.rbFechaVenta.Text = "Fecha Venta";
            this.rbFechaVenta.UseVisualStyleBackColor = true;
            this.rbFechaVenta.CheckedChanged += new System.EventHandler(this.rbFechaVenta_CheckedChanged);
            // 
            // rbTodasPromos
            // 
            this.rbTodasPromos.AutoSize = true;
            this.rbTodasPromos.Checked = true;
            this.rbTodasPromos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodasPromos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbTodasPromos.Location = new System.Drawing.Point(31, 24);
            this.rbTodasPromos.Name = "rbTodasPromos";
            this.rbTodasPromos.Size = new System.Drawing.Size(206, 22);
            this.rbTodasPromos.TabIndex = 13;
            this.rbTodasPromos.TabStop = true;
            this.rbTodasPromos.Text = "Todas las Promociones";
            this.rbTodasPromos.UseVisualStyleBackColor = true;
            this.rbTodasPromos.CheckedChanged += new System.EventHandler(this.rbTodasPromos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Listado de Promociones";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 590);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1041, 49);
            this.panelInf.TabIndex = 1;
            // 
            // rpvPromocion
            // 
            this.rpvPromocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvPromocion.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.Promocion.EstadisticaPromocions.rdlc";
            this.rpvPromocion.Location = new System.Drawing.Point(0, 239);
            this.rpvPromocion.Name = "rpvPromocion";
            this.rpvPromocion.ServerReport.BearerToken = null;
            this.rpvPromocion.Size = new System.Drawing.Size(1041, 351);
            this.rpvPromocion.TabIndex = 2;
            // 
            // EstadisticaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 639);
            this.Controls.Add(this.rpvPromocion);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaPromocion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaPromocion";
            this.Load += new System.EventHandler(this.EstadisticaPromocion_Load);
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
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFechaVenta;
        private System.Windows.Forms.RadioButton rbTodasPromos;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPromocion;
    }
}