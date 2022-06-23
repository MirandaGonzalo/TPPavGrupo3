namespace ProbandoMigrar.Reportes.Pelicula
{
    partial class ReportePelicula
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
            this.txtLeyendaPelicula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.idiomaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIdioma = new ProbandoMigrar.dataSetIdioma();
            this.idiomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbDistribuidora = new System.Windows.Forms.ComboBox();
            this.distribuidoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDistribuidora = new ProbandoMigrar.DataSetDistribuidora();
            this.distribuidoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.generoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGenero = new ProbandoMigrar.DataSetGenero();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.formatoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFormato = new ProbandoMigrar.DataSetFormato();
            this.formatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCalificacion = new System.Windows.Forms.ComboBox();
            this.calificacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCalificacion = new ProbandoMigrar.DataSetCalificacion();
            this.calificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.origenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOrigen = new ProbandoMigrar.DataSetOrigen();
            this.origenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.rdbIdioma = new System.Windows.Forms.RadioButton();
            this.rdbDistrbuidora = new System.Windows.Forms.RadioButton();
            this.rdbGenero = new System.Windows.Forms.RadioButton();
            this.rdbFormato = new System.Windows.Forms.RadioButton();
            this.rdbCalificacion = new System.Windows.Forms.RadioButton();
            this.rdborigen = new System.Windows.Forms.RadioButton();
            this.rdbTitulo = new System.Windows.Forms.RadioButton();
            this.rdbTodasPeliculas = new System.Windows.Forms.RadioButton();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.origenTableAdapter = new ProbandoMigrar.DataSetOrigenTableAdapters.OrigenTableAdapter();
            this.calificacionTableAdapter = new ProbandoMigrar.DataSetCalificacionTableAdapters.CalificacionTableAdapter();
            this.formatoTableAdapter = new ProbandoMigrar.DataSetFormatoTableAdapters.FormatoTableAdapter();
            this.generoTableAdapter = new ProbandoMigrar.DataSetGeneroTableAdapters.GeneroTableAdapter();
            this.idiomaTableAdapter = new ProbandoMigrar.dataSetIdiomaTableAdapters.IdiomaTableAdapter();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.distribuidoraTableAdapter = new ProbandoMigrar.DataSetDistribuidoraTableAdapters.DistribuidoraTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIdioma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDistribuidora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCalificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.txtLeyendaPelicula);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 266);
            this.panel1.TabIndex = 8;
            // 
            // txtLeyendaPelicula
            // 
            this.txtLeyendaPelicula.AutoSize = true;
            this.txtLeyendaPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyendaPelicula.ForeColor = System.Drawing.Color.Yellow;
            this.txtLeyendaPelicula.Location = new System.Drawing.Point(45, 208);
            this.txtLeyendaPelicula.Name = "txtLeyendaPelicula";
            this.txtLeyendaPelicula.Size = new System.Drawing.Size(0, 25);
            this.txtLeyendaPelicula.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Listado de Películas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.lblHelp);
            this.panel3.Controls.Add(this.cbIdioma);
            this.panel3.Controls.Add(this.cbDistribuidora);
            this.panel3.Controls.Add(this.cbGenero);
            this.panel3.Controls.Add(this.cbFormato);
            this.panel3.Controls.Add(this.cbCalificacion);
            this.panel3.Controls.Add(this.cbOrigen);
            this.panel3.Controls.Add(this.txtTitulo);
            this.panel3.Controls.Add(this.rdbIdioma);
            this.panel3.Controls.Add(this.rdbDistrbuidora);
            this.panel3.Controls.Add(this.rdbGenero);
            this.panel3.Controls.Add(this.rdbFormato);
            this.panel3.Controls.Add(this.rdbCalificacion);
            this.panel3.Controls.Add(this.rdborigen);
            this.panel3.Controls.Add(this.rdbTitulo);
            this.panel3.Controls.Add(this.rdbTodasPeliculas);
            this.panel3.Controls.Add(this.btnBuscarCliente);
            this.panel3.Location = new System.Drawing.Point(12, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1367, 119);
            this.panel3.TabIndex = 19;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(694, 28);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(0, 20);
            this.lblHelp.TabIndex = 34;
            this.lblHelp.Visible = false;
            // 
            // cbIdioma
            // 
            this.cbIdioma.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.idiomaBindingSource1, "codIdioma", true));
            this.cbIdioma.DataSource = this.idiomaBindingSource;
            this.cbIdioma.DisplayMember = "descripcion";
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(822, 28);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(161, 21);
            this.cbIdioma.TabIndex = 33;
            this.cbIdioma.ValueMember = "codIdioma";
            this.cbIdioma.Visible = false;
            // 
            // idiomaBindingSource1
            // 
            this.idiomaBindingSource1.DataMember = "Idioma";
            this.idiomaBindingSource1.DataSource = this.dataSetIdioma;
            // 
            // dataSetIdioma
            // 
            this.dataSetIdioma.DataSetName = "dataSetIdioma";
            this.dataSetIdioma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomaBindingSource
            // 
            this.idiomaBindingSource.DataMember = "Idioma";
            this.idiomaBindingSource.DataSource = this.dataSetIdioma;
            // 
            // cbDistribuidora
            // 
            this.cbDistribuidora.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.distribuidoraBindingSource1, "idDistribuidora", true));
            this.cbDistribuidora.DataSource = this.distribuidoraBindingSource;
            this.cbDistribuidora.DisplayMember = "nombreDistribuidora";
            this.cbDistribuidora.FormattingEnabled = true;
            this.cbDistribuidora.Location = new System.Drawing.Point(822, 26);
            this.cbDistribuidora.Name = "cbDistribuidora";
            this.cbDistribuidora.Size = new System.Drawing.Size(161, 21);
            this.cbDistribuidora.TabIndex = 32;
            this.cbDistribuidora.ValueMember = "idDistribuidora";
            this.cbDistribuidora.Visible = false;
            // 
            // distribuidoraBindingSource1
            // 
            this.distribuidoraBindingSource1.DataMember = "Distribuidora";
            this.distribuidoraBindingSource1.DataSource = this.dataSetDistribuidora;
            // 
            // dataSetDistribuidora
            // 
            this.dataSetDistribuidora.DataSetName = "DataSetDistribuidora";
            this.dataSetDistribuidora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distribuidoraBindingSource
            // 
            this.distribuidoraBindingSource.DataMember = "Distribuidora";
            this.distribuidoraBindingSource.DataSource = this.dataSetDistribuidora;
            // 
            // cbGenero
            // 
            this.cbGenero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.generoBindingSource1, "codGenero", true));
            this.cbGenero.DataSource = this.generoBindingSource;
            this.cbGenero.DisplayMember = "descripcion";
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(822, 26);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(161, 21);
            this.cbGenero.TabIndex = 31;
            this.cbGenero.ValueMember = "codGenero";
            this.cbGenero.Visible = false;
            // 
            // generoBindingSource1
            // 
            this.generoBindingSource1.DataMember = "Genero";
            this.generoBindingSource1.DataSource = this.dataSetGenero;
            // 
            // dataSetGenero
            // 
            this.dataSetGenero.DataSetName = "DataSetGenero";
            this.dataSetGenero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.dataSetGenero;
            // 
            // cbFormato
            // 
            this.cbFormato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.formatoBindingSource1, "codFormato", true));
            this.cbFormato.DataSource = this.formatoBindingSource;
            this.cbFormato.DisplayMember = "descripcion";
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(822, 26);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(161, 21);
            this.cbFormato.TabIndex = 30;
            this.cbFormato.ValueMember = "codFormato";
            this.cbFormato.Visible = false;
            // 
            // formatoBindingSource1
            // 
            this.formatoBindingSource1.DataMember = "Formato";
            this.formatoBindingSource1.DataSource = this.dataSetFormato;
            // 
            // dataSetFormato
            // 
            this.dataSetFormato.DataSetName = "DataSetFormato";
            this.dataSetFormato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formatoBindingSource
            // 
            this.formatoBindingSource.DataMember = "Formato";
            this.formatoBindingSource.DataSource = this.dataSetFormato;
            // 
            // cbCalificacion
            // 
            this.cbCalificacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.calificacionBindingSource1, "codCalificacion", true));
            this.cbCalificacion.DataSource = this.calificacionBindingSource;
            this.cbCalificacion.DisplayMember = "abreviatura";
            this.cbCalificacion.FormattingEnabled = true;
            this.cbCalificacion.Location = new System.Drawing.Point(822, 26);
            this.cbCalificacion.Name = "cbCalificacion";
            this.cbCalificacion.Size = new System.Drawing.Size(161, 21);
            this.cbCalificacion.TabIndex = 29;
            this.cbCalificacion.ValueMember = "codCalificacion";
            this.cbCalificacion.Visible = false;
            // 
            // calificacionBindingSource1
            // 
            this.calificacionBindingSource1.DataMember = "Calificacion";
            this.calificacionBindingSource1.DataSource = this.dataSetCalificacion;
            // 
            // dataSetCalificacion
            // 
            this.dataSetCalificacion.DataSetName = "DataSetCalificacion";
            this.dataSetCalificacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calificacionBindingSource
            // 
            this.calificacionBindingSource.DataMember = "Calificacion";
            this.calificacionBindingSource.DataSource = this.dataSetCalificacion;
            // 
            // cbOrigen
            // 
            this.cbOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.origenBindingSource1, "idOrigen", true));
            this.cbOrigen.DataSource = this.origenBindingSource;
            this.cbOrigen.DisplayMember = "nombre";
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(822, 26);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(161, 21);
            this.cbOrigen.TabIndex = 28;
            this.cbOrigen.ValueMember = "idOrigen";
            this.cbOrigen.Visible = false;
            // 
            // origenBindingSource1
            // 
            this.origenBindingSource1.DataMember = "Origen";
            this.origenBindingSource1.DataSource = this.dataSetOrigen;
            // 
            // dataSetOrigen
            // 
            this.dataSetOrigen.DataSetName = "DataSetOrigen";
            this.dataSetOrigen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // origenBindingSource
            // 
            this.origenBindingSource.DataMember = "Origen";
            this.origenBindingSource.DataSource = this.dataSetOrigen;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(822, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(161, 20);
            this.txtTitulo.TabIndex = 27;
            this.txtTitulo.Visible = false;
            // 
            // rdbIdioma
            // 
            this.rdbIdioma.AutoSize = true;
            this.rdbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIdioma.ForeColor = System.Drawing.Color.White;
            this.rdbIdioma.Location = new System.Drawing.Point(486, 60);
            this.rdbIdioma.Name = "rdbIdioma";
            this.rdbIdioma.Size = new System.Drawing.Size(76, 22);
            this.rdbIdioma.TabIndex = 26;
            this.rdbIdioma.Text = "Idioma";
            this.rdbIdioma.UseVisualStyleBackColor = true;
            this.rdbIdioma.CheckedChanged += new System.EventHandler(this.rdbIdioma_CheckedChanged);
            // 
            // rdbDistrbuidora
            // 
            this.rdbDistrbuidora.AutoSize = true;
            this.rdbDistrbuidora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDistrbuidora.ForeColor = System.Drawing.Color.White;
            this.rdbDistrbuidora.Location = new System.Drawing.Point(486, 23);
            this.rdbDistrbuidora.Name = "rdbDistrbuidora";
            this.rdbDistrbuidora.Size = new System.Drawing.Size(122, 22);
            this.rdbDistrbuidora.TabIndex = 25;
            this.rdbDistrbuidora.Text = "Distribuidora";
            this.rdbDistrbuidora.UseVisualStyleBackColor = true;
            this.rdbDistrbuidora.CheckedChanged += new System.EventHandler(this.rdbDistrbuidora_CheckedChanged);
            // 
            // rdbGenero
            // 
            this.rdbGenero.AutoSize = true;
            this.rdbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGenero.ForeColor = System.Drawing.Color.White;
            this.rdbGenero.Location = new System.Drawing.Point(363, 60);
            this.rdbGenero.Name = "rdbGenero";
            this.rdbGenero.Size = new System.Drawing.Size(82, 22);
            this.rdbGenero.TabIndex = 24;
            this.rdbGenero.Text = "Genero";
            this.rdbGenero.UseVisualStyleBackColor = true;
            this.rdbGenero.CheckedChanged += new System.EventHandler(this.rdbGenero_CheckedChanged);
            // 
            // rdbFormato
            // 
            this.rdbFormato.AutoSize = true;
            this.rdbFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFormato.ForeColor = System.Drawing.Color.White;
            this.rdbFormato.Location = new System.Drawing.Point(363, 23);
            this.rdbFormato.Name = "rdbFormato";
            this.rdbFormato.Size = new System.Drawing.Size(90, 22);
            this.rdbFormato.TabIndex = 23;
            this.rdbFormato.Text = "Formato";
            this.rdbFormato.UseVisualStyleBackColor = true;
            this.rdbFormato.CheckedChanged += new System.EventHandler(this.rdbFormato_CheckedChanged);
            // 
            // rdbCalificacion
            // 
            this.rdbCalificacion.AutoSize = true;
            this.rdbCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCalificacion.ForeColor = System.Drawing.Color.White;
            this.rdbCalificacion.Location = new System.Drawing.Point(226, 60);
            this.rdbCalificacion.Name = "rdbCalificacion";
            this.rdbCalificacion.Size = new System.Drawing.Size(114, 22);
            this.rdbCalificacion.TabIndex = 22;
            this.rdbCalificacion.Text = "Calificación";
            this.rdbCalificacion.UseVisualStyleBackColor = true;
            this.rdbCalificacion.CheckedChanged += new System.EventHandler(this.rdbCalificacion_CheckedChanged);
            // 
            // rdborigen
            // 
            this.rdborigen.AutoSize = true;
            this.rdborigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdborigen.ForeColor = System.Drawing.Color.White;
            this.rdborigen.Location = new System.Drawing.Point(226, 23);
            this.rdborigen.Name = "rdborigen";
            this.rdborigen.Size = new System.Drawing.Size(76, 22);
            this.rdborigen.TabIndex = 21;
            this.rdborigen.Text = "Origen";
            this.rdborigen.UseVisualStyleBackColor = true;
            this.rdborigen.CheckedChanged += new System.EventHandler(this.rdborigen_CheckedChanged);
            // 
            // rdbTitulo
            // 
            this.rdbTitulo.AutoSize = true;
            this.rdbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTitulo.ForeColor = System.Drawing.Color.White;
            this.rdbTitulo.Location = new System.Drawing.Point(24, 60);
            this.rdbTitulo.Name = "rdbTitulo";
            this.rdbTitulo.Size = new System.Drawing.Size(68, 22);
            this.rdbTitulo.TabIndex = 20;
            this.rdbTitulo.Text = "Título";
            this.rdbTitulo.UseVisualStyleBackColor = true;
            this.rdbTitulo.CheckedChanged += new System.EventHandler(this.rdbTitulo_CheckedChanged);
            // 
            // rdbTodasPeliculas
            // 
            this.rdbTodasPeliculas.AutoSize = true;
            this.rdbTodasPeliculas.Checked = true;
            this.rdbTodasPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodasPeliculas.ForeColor = System.Drawing.Color.White;
            this.rdbTodasPeliculas.Location = new System.Drawing.Point(24, 23);
            this.rdbTodasPeliculas.Name = "rdbTodasPeliculas";
            this.rdbTodasPeliculas.Size = new System.Drawing.Size(178, 22);
            this.rdbTodasPeliculas.TabIndex = 19;
            this.rdbTodasPeliculas.TabStop = true;
            this.rdbTodasPeliculas.Text = "Todas las Películas ";
            this.rdbTodasPeliculas.UseVisualStyleBackColor = true;
            this.rdbTodasPeliculas.CheckedChanged += new System.EventHandler(this.rdbTodasPeliculas_CheckedChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCliente.Location = new System.Drawing.Point(1226, 60);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(123, 41);
            this.btnBuscarCliente.TabIndex = 18;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // origenTableAdapter
            // 
            this.origenTableAdapter.ClearBeforeFill = true;
            // 
            // calificacionTableAdapter
            // 
            this.calificacionTableAdapter.ClearBeforeFill = true;
            // 
            // formatoTableAdapter
            // 
            this.formatoTableAdapter.ClearBeforeFill = true;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // idiomaTableAdapter
            // 
            this.idiomaTableAdapter.ClearBeforeFill = true;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 573);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1370, 100);
            this.panelInferior.TabIndex = 9;
            // 
            // distribuidoraTableAdapter
            // 
            this.distribuidoraTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Pelicula.ReportePelicula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 266);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1370, 307);
            this.reportViewer1.TabIndex = 10;
            // 
            // ReportePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 673);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panel1);
            this.Name = "ReportePelicula";
            this.Text = "ReportePelicula";
            this.Load += new System.EventHandler(this.ReportePelicula_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIdioma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDistribuidora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCalificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtLeyendaPelicula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.RadioButton rdbTodasPeliculas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RadioButton rdbIdioma;
        private System.Windows.Forms.RadioButton rdbDistrbuidora;
        private System.Windows.Forms.RadioButton rdbGenero;
        private System.Windows.Forms.RadioButton rdbFormato;
        private System.Windows.Forms.RadioButton rdbCalificacion;
        private System.Windows.Forms.RadioButton rdborigen;
        private System.Windows.Forms.RadioButton rdbTitulo;
        private System.Windows.Forms.ComboBox cbOrigen;
        private DataSetOrigen dataSetOrigen;
        private System.Windows.Forms.BindingSource origenBindingSource;
        private DataSetOrigenTableAdapters.OrigenTableAdapter origenTableAdapter;
        private System.Windows.Forms.BindingSource origenBindingSource1;
        private System.Windows.Forms.ComboBox cbCalificacion;
        private DataSetCalificacion dataSetCalificacion;
        private System.Windows.Forms.BindingSource calificacionBindingSource;
        private DataSetCalificacionTableAdapters.CalificacionTableAdapter calificacionTableAdapter;
        private System.Windows.Forms.BindingSource calificacionBindingSource1;
        private System.Windows.Forms.ComboBox cbFormato;
        private DataSetFormato dataSetFormato;
        private System.Windows.Forms.BindingSource formatoBindingSource;
        private DataSetFormatoTableAdapters.FormatoTableAdapter formatoTableAdapter;
        private System.Windows.Forms.BindingSource formatoBindingSource1;
        private System.Windows.Forms.ComboBox cbGenero;
        private DataSetGenero dataSetGenero;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private DataSetGeneroTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.BindingSource generoBindingSource1;
        private System.Windows.Forms.ComboBox cbDistribuidora;
        private System.Windows.Forms.ComboBox cbIdioma;
        private dataSetIdioma dataSetIdioma;
        private System.Windows.Forms.BindingSource idiomaBindingSource;
        private dataSetIdiomaTableAdapters.IdiomaTableAdapter idiomaTableAdapter;
        private System.Windows.Forms.BindingSource idiomaBindingSource1;
        private System.Windows.Forms.Panel panelInferior;
        private DataSetDistribuidora dataSetDistribuidora;
        private System.Windows.Forms.BindingSource distribuidoraBindingSource;
        private DataSetDistribuidoraTableAdapters.DistribuidoraTableAdapter distribuidoraTableAdapter;
        private System.Windows.Forms.BindingSource distribuidoraBindingSource1;
        private System.Windows.Forms.Label lblHelp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}