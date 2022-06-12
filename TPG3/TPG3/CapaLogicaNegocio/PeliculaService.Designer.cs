namespace TPG3.CapaLogicaNegocio
{
    partial class PeliculaService
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
            this.lblSeleccionPelicula = new System.Windows.Forms.Label();
            this.gdrSeleccionPelicula = new System.Windows.Forms.DataGridView();
            this.codPeliculaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdSeleccionFuncion = new System.Windows.Forms.DataGridView();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.grdFuncionSel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodPelicula = new System.Windows.Forms.TextBox();
            this.txtFormatoSel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSeleccionPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeleccionFuncion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionSel)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeleccionPelicula
            // 
            this.lblSeleccionPelicula.AutoSize = true;
            this.lblSeleccionPelicula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccionPelicula.Location = new System.Drawing.Point(12, 11);
            this.lblSeleccionPelicula.Name = "lblSeleccionPelicula";
            this.lblSeleccionPelicula.Size = new System.Drawing.Size(209, 28);
            this.lblSeleccionPelicula.TabIndex = 0;
            this.lblSeleccionPelicula.Text = "Selección de Película";
            // 
            // gdrSeleccionPelicula
            // 
            this.gdrSeleccionPelicula.AllowUserToAddRows = false;
            this.gdrSeleccionPelicula.AllowUserToDeleteRows = false;
            this.gdrSeleccionPelicula.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.gdrSeleccionPelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdrSeleccionPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSeleccionPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPeliculaItem,
            this.formato,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Duración,
            this.dataGridViewTextBoxColumn3,
            this.Origen,
            this.Calificación,
            this.dataGridViewTextBoxColumn7,
            this.Genero,
            this.Distribuidora,
            this.Idioma});
            this.gdrSeleccionPelicula.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.gdrSeleccionPelicula.Location = new System.Drawing.Point(13, 76);
            this.gdrSeleccionPelicula.Name = "gdrSeleccionPelicula";
            this.gdrSeleccionPelicula.ReadOnly = true;
            this.gdrSeleccionPelicula.RowTemplate.Height = 25;
            this.gdrSeleccionPelicula.Size = new System.Drawing.Size(843, 180);
            this.gdrSeleccionPelicula.TabIndex = 27;
            this.gdrSeleccionPelicula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrSeleccionPelicula_CellClick);
            // 
            // codPeliculaItem
            // 
            this.codPeliculaItem.DataPropertyName = "codPelicula";
            this.codPeliculaItem.HeaderText = "codPelicula";
            this.codPeliculaItem.Name = "codPeliculaItem";
            this.codPeliculaItem.ReadOnly = true;
            this.codPeliculaItem.Visible = false;
            // 
            // formato
            // 
            this.formato.DataPropertyName = "formato";
            this.formato.HeaderText = "Formato";
            this.formato.Name = "formato";
            this.formato.ReadOnly = true;
            this.formato.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ptitulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pleyenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "Leyenda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Duración
            // 
            this.Duración.DataPropertyName = "duracion";
            this.Duración.HeaderText = "Duración";
            this.Duración.Name = "Duración";
            this.Duración.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sinopsis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sinopsis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "nombre";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Calificación
            // 
            this.Calificación.DataPropertyName = "abreviatura";
            this.Calificación.HeaderText = "Calificación";
            this.Calificación.Name = "Calificación";
            this.Calificación.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fdescripcion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Formato";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "gdescripcion";
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Distribuidora
            // 
            this.Distribuidora.DataPropertyName = "nombreDistribuidora";
            this.Distribuidora.HeaderText = "Distribuidora";
            this.Distribuidora.Name = "Distribuidora";
            this.Distribuidora.ReadOnly = true;
            // 
            // Idioma
            // 
            this.Idioma.DataPropertyName = "idescripcion";
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinuar.Location = new System.Drawing.Point(748, 615);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(107, 36);
            this.btnContinuar.TabIndex = 29;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selección de Función";
            // 
            // grdSeleccionFuncion
            // 
            this.grdSeleccionFuncion.AllowUserToAddRows = false;
            this.grdSeleccionFuncion.AllowUserToDeleteRows = false;
            this.grdSeleccionFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeleccionFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHora,
            this.Sala,
            this.Estado});
            this.grdSeleccionFuncion.Location = new System.Drawing.Point(12, 339);
            this.grdSeleccionFuncion.Name = "grdSeleccionFuncion";
            this.grdSeleccionFuncion.ReadOnly = true;
            this.grdSeleccionFuncion.RowTemplate.Height = 25;
            this.grdSeleccionFuncion.Size = new System.Drawing.Size(844, 109);
            this.grdSeleccionFuncion.TabIndex = 40;
            this.grdSeleccionFuncion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSeleccionFuncion_CellContentClick);
            // 
            // FechaHora
            // 
            this.FechaHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaHora.DataPropertyName = "fechaHora";
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sala.DataPropertyName = "sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Función Seleccionada";
            // 
            // grdFuncionSel
            // 
            this.grdFuncionSel.AllowUserToAddRows = false;
            this.grdFuncionSel.AllowUserToDeleteRows = false;
            this.grdFuncionSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFuncionSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.grdFuncionSel.Location = new System.Drawing.Point(12, 540);
            this.grdFuncionSel.Name = "grdFuncionSel";
            this.grdFuncionSel.ReadOnly = true;
            this.grdFuncionSel.RowTemplate.Height = 25;
            this.grdFuncionSel.Size = new System.Drawing.Size(844, 66);
            this.grdFuncionSel.TabIndex = 41;
            this.grdFuncionSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFuncionSel_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fechaHora";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaHora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sala";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sala";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // txtCodPelicula
            // 
            this.txtCodPelicula.Location = new System.Drawing.Point(13, 624);
            this.txtCodPelicula.Name = "txtCodPelicula";
            this.txtCodPelicula.Size = new System.Drawing.Size(31, 23);
            this.txtCodPelicula.TabIndex = 42;
            this.txtCodPelicula.Text = "-1";
            this.txtCodPelicula.Visible = false;
            // 
            // txtFormatoSel
            // 
            this.txtFormatoSel.Location = new System.Drawing.Point(69, 625);
            this.txtFormatoSel.Name = "txtFormatoSel";
            this.txtFormatoSel.Size = new System.Drawing.Size(33, 23);
            this.txtFormatoSel.TabIndex = 43;
            this.txtFormatoSel.Text = "-1";
            this.txtFormatoSel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 49);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 49);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lblSeleccionPelicula);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 49);
            this.panel1.TabIndex = 1;
            // 
            // PeliculaService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(925, 708);
            this.Controls.Add(this.txtFormatoSel);
            this.Controls.Add(this.txtCodPelicula);
            this.Controls.Add(this.grdFuncionSel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grdSeleccionFuncion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.gdrSeleccionPelicula);
            this.Controls.Add(this.panel1);
            this.Name = "PeliculaService";
            this.Text = "PeliculaService";
            this.Load += new System.EventHandler(this.PeliculaService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrSeleccionPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeleccionFuncion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionSel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSeleccionPelicula;
        private DataGridView gdrSeleccionPelicula;
        private Button btnContinuar;
        private Label label1;
        private DataGridView grdSeleccionFuncion;
        private DataGridViewTextBoxColumn FechaHora;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Estado;
        private Label label2;
        private DataGridView grdFuncionSel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox txtCodPelicula;
        private TextBox txtFormatoSel;
        private DataGridViewTextBoxColumn codPeliculaItem;
        private DataGridViewTextBoxColumn formato;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Duración;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Calificación;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Distribuidora;
        private DataGridViewTextBoxColumn Idioma;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
    }
}