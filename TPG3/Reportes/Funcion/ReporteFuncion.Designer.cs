namespace ProbandoMigrar.Reportes.Funcion
{
    partial class ReporteFuncion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAlcanceFuncion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeyendaCombo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPelicula = new System.Windows.Forms.Label();
            this.labelSala = new System.Windows.Forms.Label();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListadoPeliculas = new ProbandoMigrar.DataSetListadoPeliculas();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListadoSalaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListadoSala = new ProbandoMigrar.DataSetListadoSala();
            this.rdbRangoFecha = new System.Windows.Forms.RadioButton();
            this.rdbPelicula = new System.Windows.Forms.RadioButton();
            this.btnBuscarCombo = new System.Windows.Forms.Button();
            this.rdnSala = new System.Windows.Forms.RadioButton();
            this.rdbTodasFunciones = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBajo = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetListadoSalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaTableAdapter = new ProbandoMigrar.DataSetListadoSalaTableAdapters.SalaTableAdapter();
            this.peliculaTableAdapter = new ProbandoMigrar.DataSetListadoPeliculasTableAdapters.PeliculaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSalaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSalaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.lblAlcanceFuncion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLeyendaCombo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 250);
            this.panel1.TabIndex = 0;
            // 
            // lblAlcanceFuncion
            // 
            this.lblAlcanceFuncion.AutoSize = true;
            this.lblAlcanceFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcanceFuncion.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlcanceFuncion.Location = new System.Drawing.Point(26, 213);
            this.lblAlcanceFuncion.Name = "lblAlcanceFuncion";
            this.lblAlcanceFuncion.Size = new System.Drawing.Size(0, 25);
            this.lblAlcanceFuncion.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(694, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 22;
            // 
            // txtLeyendaCombo
            // 
            this.txtLeyendaCombo.AutoSize = true;
            this.txtLeyendaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtLeyendaCombo.ForeColor = System.Drawing.Color.Yellow;
            this.txtLeyendaCombo.Location = new System.Drawing.Point(686, 113);
            this.txtLeyendaCombo.Name = "txtLeyendaCombo";
            this.txtLeyendaCombo.Size = new System.Drawing.Size(0, 25);
            this.txtLeyendaCombo.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.labelPelicula);
            this.panel3.Controls.Add(this.labelSala);
            this.panel3.Controls.Add(this.mtbHasta);
            this.panel3.Controls.Add(this.mtbDesde);
            this.panel3.Controls.Add(this.cmbPelicula);
            this.panel3.Controls.Add(this.cmbSala);
            this.panel3.Controls.Add(this.rdbRangoFecha);
            this.panel3.Controls.Add(this.rdbPelicula);
            this.panel3.Controls.Add(this.btnBuscarCombo);
            this.panel3.Controls.Add(this.rdnSala);
            this.panel3.Controls.Add(this.rdbTodasFunciones);
            this.panel3.Location = new System.Drawing.Point(11, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1349, 128);
            this.panel3.TabIndex = 20;
            // 
            // labelPelicula
            // 
            this.labelPelicula.AutoSize = true;
            this.labelPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPelicula.ForeColor = System.Drawing.Color.White;
            this.labelPelicula.Location = new System.Drawing.Point(453, 43);
            this.labelPelicula.Name = "labelPelicula";
            this.labelPelicula.Size = new System.Drawing.Size(85, 20);
            this.labelPelicula.TabIndex = 24;
            this.labelPelicula.Text = "Películas:";
            this.labelPelicula.Visible = false;
            // 
            // labelSala
            // 
            this.labelSala.AutoSize = true;
            this.labelSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSala.ForeColor = System.Drawing.Color.White;
            this.labelSala.Location = new System.Drawing.Point(453, 44);
            this.labelSala.Name = "labelSala";
            this.labelSala.Size = new System.Drawing.Size(59, 20);
            this.labelSala.TabIndex = 21;
            this.labelSala.Text = "Salas:";
            this.labelSala.Visible = false;
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(595, 43);
            this.mtbHasta.Mask = "00/00/0000";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 23;
            this.mtbHasta.ValidatingType = typeof(System.DateTime);
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(457, 43);
            this.mtbDesde.Mask = "00/00/0000";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 22;
            this.mtbDesde.ValidatingType = typeof(System.DateTime);
            this.mtbDesde.Visible = false;
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.DataSource = this.peliculaBindingSource;
            this.cmbPelicula.DisplayMember = "titulo";
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(544, 43);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbPelicula.TabIndex = 21;
            this.cmbPelicula.ValueMember = "codPelicula";
            this.cmbPelicula.Visible = false;
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataMember = "Pelicula";
            this.peliculaBindingSource.DataSource = this.dataSetListadoPeliculas;
            // 
            // dataSetListadoPeliculas
            // 
            this.dataSetListadoPeliculas.DataSetName = "DataSetListadoPeliculas";
            this.dataSetListadoPeliculas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSala
            // 
            this.cmbSala.DataSource = this.salaBindingSource;
            this.cmbSala.DisplayMember = "codigo";
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(544, 43);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(121, 21);
            this.cmbSala.TabIndex = 20;
            this.cmbSala.ValueMember = "numero";
            this.cmbSala.Visible = false;
            // 
            // salaBindingSource
            // 
            this.salaBindingSource.DataMember = "Sala";
            this.salaBindingSource.DataSource = this.dataSetListadoSalaBindingSource1;
            // 
            // dataSetListadoSalaBindingSource1
            // 
            this.dataSetListadoSalaBindingSource1.DataSource = this.dataSetListadoSala;
            this.dataSetListadoSalaBindingSource1.Position = 0;
            // 
            // dataSetListadoSala
            // 
            this.dataSetListadoSala.DataSetName = "DataSetListadoSala";
            this.dataSetListadoSala.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdbRangoFecha
            // 
            this.rdbRangoFecha.AutoSize = true;
            this.rdbRangoFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbRangoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRangoFecha.ForeColor = System.Drawing.Color.White;
            this.rdbRangoFecha.Location = new System.Drawing.Point(223, 24);
            this.rdbRangoFecha.Name = "rdbRangoFecha";
            this.rdbRangoFecha.Size = new System.Drawing.Size(126, 22);
            this.rdbRangoFecha.TabIndex = 19;
            this.rdbRangoFecha.Text = "Rango Fecha";
            this.rdbRangoFecha.UseVisualStyleBackColor = false;
            this.rdbRangoFecha.CheckedChanged += new System.EventHandler(this.rdbRangoFecha_CheckedChanged);
            // 
            // rdbPelicula
            // 
            this.rdbPelicula.AutoSize = true;
            this.rdbPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPelicula.ForeColor = System.Drawing.Color.White;
            this.rdbPelicula.Location = new System.Drawing.Point(223, 62);
            this.rdbPelicula.Name = "rdbPelicula";
            this.rdbPelicula.Size = new System.Drawing.Size(179, 22);
            this.rdbPelicula.TabIndex = 7;
            this.rdbPelicula.Text = "Seleccionar Película";
            this.rdbPelicula.UseVisualStyleBackColor = false;
            this.rdbPelicula.CheckedChanged += new System.EventHandler(this.rdbPelicula_CheckedChanged);
            // 
            // btnBuscarCombo
            // 
            this.btnBuscarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCombo.FlatAppearance.BorderSize = 0;
            this.btnBuscarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCombo.Location = new System.Drawing.Point(1216, 78);
            this.btnBuscarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCombo.Name = "btnBuscarCombo";
            this.btnBuscarCombo.Size = new System.Drawing.Size(123, 41);
            this.btnBuscarCombo.TabIndex = 18;
            this.btnBuscarCombo.Text = "Buscar";
            this.btnBuscarCombo.UseVisualStyleBackColor = false;
            this.btnBuscarCombo.Click += new System.EventHandler(this.btnBuscarCombo_Click);
            // 
            // rdnSala
            // 
            this.rdnSala.AutoSize = true;
            this.rdnSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdnSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnSala.ForeColor = System.Drawing.Color.White;
            this.rdnSala.Location = new System.Drawing.Point(20, 62);
            this.rdnSala.Name = "rdnSala";
            this.rdnSala.Size = new System.Drawing.Size(153, 22);
            this.rdnSala.TabIndex = 6;
            this.rdnSala.Text = "Seleccionar Sala";
            this.rdnSala.UseVisualStyleBackColor = false;
            this.rdnSala.CheckedChanged += new System.EventHandler(this.rdnSala_CheckedChanged);
            // 
            // rdbTodasFunciones
            // 
            this.rdbTodasFunciones.AutoSize = true;
            this.rdbTodasFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbTodasFunciones.Checked = true;
            this.rdbTodasFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodasFunciones.ForeColor = System.Drawing.Color.White;
            this.rdbTodasFunciones.Location = new System.Drawing.Point(20, 24);
            this.rdbTodasFunciones.Name = "rdbTodasFunciones";
            this.rdbTodasFunciones.Size = new System.Drawing.Size(179, 22);
            this.rdbTodasFunciones.TabIndex = 5;
            this.rdbTodasFunciones.TabStop = true;
            this.rdbTodasFunciones.Text = "Todos las funciones";
            this.rdbTodasFunciones.UseVisualStyleBackColor = false;
            this.rdbTodasFunciones.CheckedChanged += new System.EventHandler(this.rdbTodasFunciones_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Funciones";
            // 
            // panelBajo
            // 
            this.panelBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.panelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBajo.Location = new System.Drawing.Point(0, 596);
            this.panelBajo.Name = "panelBajo";
            this.panelBajo.Size = new System.Drawing.Size(1370, 44);
            this.panelBajo.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Funcion.ReporteFuncion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 250);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1370, 346);
            this.reportViewer1.TabIndex = 2;
            // 
            // dataSetListadoSalaBindingSource
            // 
            this.dataSetListadoSalaBindingSource.DataSource = this.dataSetListadoSala;
            this.dataSetListadoSalaBindingSource.Position = 0;
            // 
            // salaTableAdapter
            // 
            this.salaTableAdapter.ClearBeforeFill = true;
            // 
            // peliculaTableAdapter
            // 
            this.peliculaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 640);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelBajo);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteFuncion";
            this.Text = "ReporteFuncion";
            this.Load += new System.EventHandler(this.ReporteFuncion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSalaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSalaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarCombo;
        private System.Windows.Forms.RadioButton rdbPelicula;
        private System.Windows.Forms.RadioButton rdnSala;
        private System.Windows.Forms.RadioButton rdbTodasFunciones;
        private System.Windows.Forms.Panel panelBajo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton rdbRangoFecha;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.BindingSource dataSetListadoSalaBindingSource1;
        private DataSetListadoSala dataSetListadoSala;
        private System.Windows.Forms.BindingSource dataSetListadoSalaBindingSource;
        private System.Windows.Forms.BindingSource salaBindingSource;
        private DataSetListadoSalaTableAdapters.SalaTableAdapter salaTableAdapter;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private DataSetListadoPeliculas dataSetListadoPeliculas;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private DataSetListadoPeliculasTableAdapters.PeliculaTableAdapter peliculaTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.Label labelPelicula;
        private System.Windows.Forms.Label labelSala;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.Label txtLeyendaCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlcanceFuncion;
    }
}