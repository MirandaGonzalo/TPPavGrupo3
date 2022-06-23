namespace ProbandoMigrar.Reportes.Producto
{
    partial class ReporteProducto
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
            this.components = new System.ComponentModel.Container();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.txtLeyendaProducto = new System.Windows.Forms.Label();
            this.lblListadoProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbTodosProductos = new System.Windows.Forms.RadioButton();
            this.rdbPrecio = new System.Windows.Forms.RadioButton();
            this.rdbTipoProducto = new System.Windows.Forms.RadioButton();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.rdbMenorQue = new System.Windows.Forms.RadioButton();
            this.rdbMayorQue = new System.Windows.Forms.RadioButton();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.tipoProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTipoProducto = new ProbandoMigrar.DataSetTipoProducto();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBajo = new System.Windows.Forms.Panel();
            this.tipoProductoTableAdapter = new ProbandoMigrar.DataSetTipoProductoTableAdapters.TipoProductoTableAdapter();
            this.rpvProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelSuperior.Controls.Add(this.txtLeyendaProducto);
            this.panelSuperior.Controls.Add(this.lblListadoProducto);
            this.panelSuperior.Controls.Add(this.panel1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1121, 247);
            this.panelSuperior.TabIndex = 0;
            // 
            // txtLeyendaProducto
            // 
            this.txtLeyendaProducto.AutoSize = true;
            this.txtLeyendaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtLeyendaProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtLeyendaProducto.ForeColor = System.Drawing.Color.Yellow;
            this.txtLeyendaProducto.Location = new System.Drawing.Point(16, 204);
            this.txtLeyendaProducto.Name = "txtLeyendaProducto";
            this.txtLeyendaProducto.Size = new System.Drawing.Size(0, 28);
            this.txtLeyendaProducto.TabIndex = 23;
            // 
            // lblListadoProducto
            // 
            this.lblListadoProducto.AutoSize = true;
            this.lblListadoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblListadoProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblListadoProducto.ForeColor = System.Drawing.Color.White;
            this.lblListadoProducto.Location = new System.Drawing.Point(15, 25);
            this.lblListadoProducto.Name = "lblListadoProducto";
            this.lblListadoProducto.Size = new System.Drawing.Size(172, 28);
            this.lblListadoProducto.TabIndex = 22;
            this.lblListadoProducto.Text = "Listado Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mtbHasta);
            this.panel1.Controls.Add(this.mtbDesde);
            this.panel1.Controls.Add(this.rdbEntre);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.rdbMenorQue);
            this.panel1.Controls.Add(this.rdbMayorQue);
            this.panel1.Controls.Add(this.cmbTipoProducto);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 122);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbTodosProductos);
            this.panel2.Controls.Add(this.rdbPrecio);
            this.panel2.Controls.Add(this.rdbTipoProducto);
            this.panel2.Location = new System.Drawing.Point(8, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 22;
            // 
            // rdbTodosProductos
            // 
            this.rdbTodosProductos.AutoSize = true;
            this.rdbTodosProductos.Checked = true;
            this.rdbTodosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodosProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbTodosProductos.Location = new System.Drawing.Point(12, 11);
            this.rdbTodosProductos.Name = "rdbTodosProductos";
            this.rdbTodosProductos.Size = new System.Drawing.Size(185, 22);
            this.rdbTodosProductos.TabIndex = 12;
            this.rdbTodosProductos.TabStop = true;
            this.rdbTodosProductos.Text = "Todos los Productos";
            this.rdbTodosProductos.UseVisualStyleBackColor = true;
            this.rdbTodosProductos.CheckedChanged += new System.EventHandler(this.rdbTodosProductos_CheckedChanged);
            // 
            // rdbPrecio
            // 
            this.rdbPrecio.AutoSize = true;
            this.rdbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPrecio.Location = new System.Drawing.Point(12, 39);
            this.rdbPrecio.Name = "rdbPrecio";
            this.rdbPrecio.Size = new System.Drawing.Size(75, 22);
            this.rdbPrecio.TabIndex = 11;
            this.rdbPrecio.TabStop = true;
            this.rdbPrecio.Text = "Precio";
            this.rdbPrecio.UseVisualStyleBackColor = true;
            this.rdbPrecio.CheckedChanged += new System.EventHandler(this.rdbPrecio_CheckedChanged);
            // 
            // rdbTipoProducto
            // 
            this.rdbTipoProducto.AutoSize = true;
            this.rdbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTipoProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbTipoProducto.Location = new System.Drawing.Point(12, 67);
            this.rdbTipoProducto.Name = "rdbTipoProducto";
            this.rdbTipoProducto.Size = new System.Drawing.Size(156, 22);
            this.rdbTipoProducto.TabIndex = 13;
            this.rdbTipoProducto.TabStop = true;
            this.rdbTipoProducto.Text = "Tipo de Producto";
            this.rdbTipoProducto.UseVisualStyleBackColor = true;
            this.rdbTipoProducto.CheckedChanged += new System.EventHandler(this.rdbTipoProducto_CheckedChanged);
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(819, 64);
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
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoProductoBindingSource1, "idTipoProducto", true));
            this.cmbTipoProducto.DataSource = this.tipoProductoBindingSource;
            this.cmbTipoProducto.DisplayMember = "nombreTipoProd";
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(370, 50);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(193, 21);
            this.cmbTipoProducto.TabIndex = 8;
            this.cmbTipoProducto.ValueMember = "idTipoProducto";
            this.cmbTipoProducto.Visible = false;
            // 
            // tipoProductoBindingSource1
            // 
            this.tipoProductoBindingSource1.DataMember = "TipoProducto";
            this.tipoProductoBindingSource1.DataSource = this.dataSetTipoProducto;
            // 
            // dataSetTipoProducto
            // 
            this.dataSetTipoProducto.DataSetName = "DataSetTipoProducto";
            this.dataSetTipoProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "TipoProducto";
            this.tipoProductoBindingSource.DataSource = this.dataSetTipoProducto;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            // 
            // panelBajo
            // 
            this.panelBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBajo.Location = new System.Drawing.Point(0, 481);
            this.panelBajo.Name = "panelBajo";
            this.panelBajo.Size = new System.Drawing.Size(1121, 69);
            this.panelBajo.TabIndex = 1;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // rpvProducto
            // 
            this.rpvProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rpvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvProducto.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Producto.ReporteProducto.rdlc";
            this.rpvProducto.Location = new System.Drawing.Point(0, 247);
            this.rpvProducto.Name = "rpvProducto";
            this.rpvProducto.ServerReport.BearerToken = null;
            this.rpvProducto.Size = new System.Drawing.Size(1121, 234);
            this.rpvProducto.TabIndex = 2;
            // 
            // ReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 550);
            this.Controls.Add(this.rpvProducto);
            this.Controls.Add(this.panelBajo);
            this.Controls.Add(this.panelSuperior);
            this.Name = "ReporteProducto";
            this.Text = "ReporteProducto";
            this.Load += new System.EventHandler(this.ReporteProducto_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel panelBajo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblListadoProducto;
        private System.Windows.Forms.RadioButton rdbPrecio;
        private System.Windows.Forms.RadioButton rdbTipoProducto;
        private System.Windows.Forms.RadioButton rdbTodosProductos;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.RadioButton rdbMenorQue;
        private System.Windows.Forms.RadioButton rdbMayorQue;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Panel panel2;
        private DataSetTipoProducto dataSetTipoProducto;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private DataSetTipoProductoTableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvProducto;
        private System.Windows.Forms.Label txtLeyendaProducto;
    }
}