namespace ProbandoMigrar.Estadisticas.Funcion
{
    partial class EstadisticaFuncion
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
            this.panelSup = new System.Windows.Forms.Panel();
            this.panelParam = new System.Windows.Forms.Panel();
            this.cbPelicula = new System.Windows.Forms.ComboBox();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListadoPeliculas = new ProbandoMigrar.DataSetListadoPeliculas();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListadoSala = new ProbandoMigrar.DataSetListadoSala();
            this.btnBuscarFuncion = new System.Windows.Forms.Button();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.rdbMenorQue = new System.Windows.Forms.RadioButton();
            this.rdbMayorQue = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbPelicula = new System.Windows.Forms.RadioButton();
            this.rbSala = new System.Windows.Forms.RadioButton();
            this.rdbFechaFuncion = new System.Windows.Forms.RadioButton();
            this.rdbTodasFunciones = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.salaTableAdapter = new ProbandoMigrar.DataSetListadoSalaTableAdapters.SalaTableAdapter();
            this.peliculaTableAdapter = new ProbandoMigrar.DataSetListadoPeliculasTableAdapters.PeliculaTableAdapter();
            this.rpvFuncion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSup.SuspendLayout();
            this.panelParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSala)).BeginInit();
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
            this.panelSup.Size = new System.Drawing.Size(1370, 236);
            this.panelSup.TabIndex = 1;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.cbPelicula);
            this.panelParam.Controls.Add(this.cbSala);
            this.panelParam.Controls.Add(this.btnBuscarFuncion);
            this.panelParam.Controls.Add(this.mtbHasta);
            this.panelParam.Controls.Add(this.mtbDesde);
            this.panelParam.Controls.Add(this.rdbEntre);
            this.panelParam.Controls.Add(this.rdbMenorQue);
            this.panelParam.Controls.Add(this.rdbMayorQue);
            this.panelParam.Location = new System.Drawing.Point(467, 81);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(902, 105);
            this.panelParam.TabIndex = 13;
            // 
            // cbPelicula
            // 
            this.cbPelicula.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peliculaBindingSource, "codPelicula", true));
            this.cbPelicula.DataSource = this.peliculaBindingSource;
            this.cbPelicula.DisplayMember = "titulo";
            this.cbPelicula.FormattingEnabled = true;
            this.cbPelicula.Location = new System.Drawing.Point(130, 47);
            this.cbPelicula.Name = "cbPelicula";
            this.cbPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbPelicula.TabIndex = 29;
            this.cbPelicula.ValueMember = "codPelicula";
            this.cbPelicula.Visible = false;
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
            // cbSala
            // 
            this.cbSala.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salaBindingSource, "codigo", true));
            this.cbSala.DataSource = this.salaBindingSource;
            this.cbSala.DisplayMember = "codigo";
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(130, 47);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(121, 21);
            this.cbSala.TabIndex = 28;
            this.cbSala.ValueMember = "codigo";
            this.cbSala.Visible = false;
            // 
            // salaBindingSource
            // 
            this.salaBindingSource.DataMember = "Sala";
            this.salaBindingSource.DataSource = this.dataSetListadoSala;
            // 
            // dataSetListadoSala
            // 
            this.dataSetListadoSala.DataSetName = "DataSetListadoSala";
            this.dataSetListadoSala.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarFuncion.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarFuncion.Location = new System.Drawing.Point(756, 58);
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
            this.rdbMenorQue.Size = new System.Drawing.Size(68, 22);
            this.rdbMenorQue.TabIndex = 23;
            this.rdbMenorQue.Text = "Antes";
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
            this.rdbMayorQue.Size = new System.Drawing.Size(92, 22);
            this.rdbMayorQue.TabIndex = 22;
            this.rdbMayorQue.TabStop = true;
            this.rdbMayorQue.Text = "Despues";
            this.rdbMayorQue.UseVisualStyleBackColor = true;
            this.rdbMayorQue.Visible = false;
            this.rdbMayorQue.CheckedChanged += new System.EventHandler(this.rdbMayorQue_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.rdbPelicula);
            this.panel1.Controls.Add(this.rbSala);
            this.panel1.Controls.Add(this.rdbFechaFuncion);
            this.panel1.Controls.Add(this.rdbTodasFunciones);
            this.panel1.Location = new System.Drawing.Point(33, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 105);
            this.panel1.TabIndex = 3;
            // 
            // rdbPelicula
            // 
            this.rdbPelicula.AutoSize = true;
            this.rdbPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPelicula.Location = new System.Drawing.Point(240, 65);
            this.rdbPelicula.Name = "rdbPelicula";
            this.rdbPelicula.Size = new System.Drawing.Size(85, 22);
            this.rdbPelicula.TabIndex = 14;
            this.rdbPelicula.Text = "Película";
            this.rdbPelicula.UseVisualStyleBackColor = true;
            this.rdbPelicula.CheckedChanged += new System.EventHandler(this.rdbPelicula_CheckedChanged);
            // 
            // rbSala
            // 
            this.rbSala.AutoSize = true;
            this.rbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSala.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbSala.Location = new System.Drawing.Point(19, 65);
            this.rbSala.Name = "rbSala";
            this.rbSala.Size = new System.Drawing.Size(59, 22);
            this.rbSala.TabIndex = 13;
            this.rbSala.Text = "Sala";
            this.rbSala.UseVisualStyleBackColor = true;
            this.rbSala.CheckedChanged += new System.EventHandler(this.rbSala_CheckedChanged);
            // 
            // rdbFechaFuncion
            // 
            this.rdbFechaFuncion.AutoSize = true;
            this.rdbFechaFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFechaFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbFechaFuncion.Location = new System.Drawing.Point(240, 15);
            this.rdbFechaFuncion.Name = "rdbFechaFuncion";
            this.rdbFechaFuncion.Size = new System.Drawing.Size(137, 22);
            this.rdbFechaFuncion.TabIndex = 12;
            this.rdbFechaFuncion.Text = "Fecha Función";
            this.rdbFechaFuncion.UseVisualStyleBackColor = true;
            this.rdbFechaFuncion.CheckedChanged += new System.EventHandler(this.rdbFechaFuncion_CheckedChanged);
            // 
            // rdbTodasFunciones
            // 
            this.rdbTodasFunciones.AutoSize = true;
            this.rdbTodasFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbTodasFunciones.Checked = true;
            this.rdbTodasFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodasFunciones.ForeColor = System.Drawing.Color.White;
            this.rdbTodasFunciones.Location = new System.Drawing.Point(19, 15);
            this.rdbTodasFunciones.Name = "rdbTodasFunciones";
            this.rdbTodasFunciones.Size = new System.Drawing.Size(178, 22);
            this.rdbTodasFunciones.TabIndex = 3;
            this.rdbTodasFunciones.TabStop = true;
            this.rdbTodasFunciones.Text = "Todas las funciones";
            this.rdbTodasFunciones.UseVisualStyleBackColor = false;
            this.rdbTodasFunciones.CheckedChanged += new System.EventHandler(this.rdbTodasFunciones_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Listado de Funciones";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 649);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1370, 100);
            this.panelInf.TabIndex = 2;
            // 
            // salaTableAdapter
            // 
            this.salaTableAdapter.ClearBeforeFill = true;
            // 
            // peliculaTableAdapter
            // 
            this.peliculaTableAdapter.ClearBeforeFill = true;
            // 
            // rpvFuncion
            // 
            this.rpvFuncion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvFuncion.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.Funcion.EstadisticaFuncion.rdlc";
            this.rpvFuncion.Location = new System.Drawing.Point(0, 236);
            this.rpvFuncion.Name = "rpvFuncion";
            this.rpvFuncion.ServerReport.BearerToken = null;
            this.rpvFuncion.Size = new System.Drawing.Size(1370, 413);
            this.rpvFuncion.TabIndex = 3;
            // 
            // EstadisticaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.rpvFuncion);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "EstadisticaFuncion";
            this.Text = "EstadisticaFuncion";
            this.Load += new System.EventHandler(this.EstadisticaFuncion_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoSala)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.RadioButton rdbMenorQue;
        private System.Windows.Forms.RadioButton rdbMayorQue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbFechaFuncion;
        private System.Windows.Forms.RadioButton rdbTodasFunciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.RadioButton rbSala;
        private System.Windows.Forms.Panel panelInf;
        private DataSetListadoSala dataSetListadoSala;
        private System.Windows.Forms.BindingSource salaBindingSource;
        private DataSetListadoSalaTableAdapters.SalaTableAdapter salaTableAdapter;
        private System.Windows.Forms.ComboBox cbPelicula;
        private System.Windows.Forms.RadioButton rdbPelicula;
        private DataSetListadoPeliculas dataSetListadoPeliculas;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private DataSetListadoPeliculasTableAdapters.PeliculaTableAdapter peliculaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvFuncion;
    }
}