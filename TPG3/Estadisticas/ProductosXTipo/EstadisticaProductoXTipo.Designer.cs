namespace ProbandoMigrar.Estadisticas.ProductosXTipo
{
    partial class EstadisticaProductoXTipo
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
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.rdbMenorQue = new System.Windows.Forms.RadioButton();
            this.rdbMayorQue = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbPrecio = new System.Windows.Forms.RadioButton();
            this.rdbTodosProductos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.rpV = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.panelSup.Size = new System.Drawing.Size(1255, 236);
            this.panelSup.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.btnBuscarProducto);
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Controls.Add(this.rdbEntre);
            this.panelParam.Controls.Add(this.rdbMenorQue);
            this.panelParam.Controls.Add(this.rdbMayorQue);
            this.panelParam.Location = new System.Drawing.Point(327, 81);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(902, 113);
            this.panelParam.TabIndex = 13;
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
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(245, 47);
            this.mtbHasta.Mask = "9999999";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 26;
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(130, 47);
            this.mtbDesde.Mask = "9999999";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 25;
            this.mtbDesde.Visible = false;
            // 
            // rdbEntre
            // 
            this.rdbEntre.AutoSize = true;
            this.rdbEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbEntre.Location = new System.Drawing.Point(13, 43);
            this.rdbEntre.Name = "rdbEntre";
            this.rdbEntre.Size = new System.Drawing.Size(66, 22);
            this.rdbEntre.TabIndex = 24;
            this.rdbEntre.Text = "Entre";
            this.rdbEntre.UseVisualStyleBackColor = true;
            this.rdbEntre.Visible = false;
            this.rdbEntre.CheckedChanged += new System.EventHandler(this.rdbEntre_CheckedChanged);
            // 
            // rdbMenorQue
            // 
            this.rdbMenorQue.AutoSize = true;
            this.rdbMenorQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMenorQue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbMenorQue.Location = new System.Drawing.Point(12, 71);
            this.rdbMenorQue.Name = "rdbMenorQue";
            this.rdbMenorQue.Size = new System.Drawing.Size(106, 22);
            this.rdbMenorQue.TabIndex = 23;
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
            this.rdbMayorQue.Location = new System.Drawing.Point(13, 15);
            this.rdbMayorQue.Name = "rdbMayorQue";
            this.rdbMayorQue.Size = new System.Drawing.Size(105, 22);
            this.rdbMayorQue.TabIndex = 22;
            this.rdbMayorQue.TabStop = true;
            this.rdbMayorQue.Text = "Mayor que";
            this.rdbMayorQue.UseVisualStyleBackColor = true;
            this.rdbMayorQue.Visible = false;
            this.rdbMayorQue.CheckedChanged += new System.EventHandler(this.rdbMayorQue_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.rdbPrecio);
            this.panel1.Controls.Add(this.rdbTodosProductos);
            this.panel1.Location = new System.Drawing.Point(33, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 113);
            this.panel1.TabIndex = 3;
            // 
            // rdbPrecio
            // 
            this.rdbPrecio.AutoSize = true;
            this.rdbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPrecio.Location = new System.Drawing.Point(19, 43);
            this.rdbPrecio.Name = "rdbPrecio";
            this.rdbPrecio.Size = new System.Drawing.Size(75, 22);
            this.rdbPrecio.TabIndex = 12;
            this.rdbPrecio.Text = "Precio";
            this.rdbPrecio.UseVisualStyleBackColor = true;
            this.rdbPrecio.CheckedChanged += new System.EventHandler(this.rdbPrecio_CheckedChanged);
            // 
            // rdbTodosProductos
            // 
            this.rdbTodosProductos.AutoSize = true;
            this.rdbTodosProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbTodosProductos.Checked = true;
            this.rdbTodosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodosProductos.ForeColor = System.Drawing.Color.White;
            this.rdbTodosProductos.Location = new System.Drawing.Point(19, 15);
            this.rdbTodosProductos.Name = "rdbTodosProductos";
            this.rdbTodosProductos.Size = new System.Drawing.Size(183, 22);
            this.rdbTodosProductos.TabIndex = 3;
            this.rdbTodosProductos.TabStop = true;
            this.rdbTodosProductos.Text = "Todos los productos";
            this.rdbTodosProductos.UseVisualStyleBackColor = false;
            this.rdbTodosProductos.CheckedChanged += new System.EventHandler(this.rdbTodosProductos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Listado de Productos x Tipo";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 578);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1255, 100);
            this.panelInf.TabIndex = 1;
            // 
            // rpV
            // 
            this.rpV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpV.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.ProductosXTipo.EstadisticaProductoTipo.rdlc";
            this.rpV.Location = new System.Drawing.Point(0, 236);
            this.rpV.Name = "rpV";
            this.rpV.ServerReport.BearerToken = null;
            this.rpV.Size = new System.Drawing.Size(1255, 342);
            this.rpV.TabIndex = 2;
            // 
            // EstadisticaProductoXTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 678);
            this.Controls.Add(this.rpV);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaProductoXTipo";
            this.Text = "EstadisticaProductoXTipo";
            this.Load += new System.EventHandler(this.EstadisticaProductoXTipo_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.RadioButton rdbTodosProductos;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.RadioButton rdbPrecio;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.RadioButton rdbMenorQue;
        private System.Windows.Forms.RadioButton rdbMayorQue;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.Button btnBuscarProducto;
        private Microsoft.Reporting.WinForms.ReportViewer rpV;
    }
}