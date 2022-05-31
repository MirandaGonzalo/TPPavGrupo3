namespace TPG3.CapaLogicaNegocio
{
    partial class FuncionService
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
            this.lblSeleccionFuncion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFechaHora = new System.Windows.Forms.TextBox();
            this.gdrSeleccionFuncion = new System.Windows.Forms.DataGridView();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdPeliculaFuncion = new System.Windows.Forms.TextBox();
            this.txtFormatoPeli = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSeleccionFuncion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionFuncion
            // 
            this.lblSeleccionFuncion.AutoSize = true;
            this.lblSeleccionFuncion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccionFuncion.Location = new System.Drawing.Point(12, 11);
            this.lblSeleccionFuncion.Name = "lblSeleccionFuncion";
            this.lblSeleccionFuncion.Size = new System.Drawing.Size(210, 28);
            this.lblSeleccionFuncion.TabIndex = 0;
            this.lblSeleccionFuncion.Text = "Selección de Función";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lblSeleccionFuncion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 49);
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(89, 19);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Fecha Hora ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sala";
            // 
            // txtSala
            // 
            this.txtSala.Enabled = false;
            this.txtSala.Location = new System.Drawing.Point(18, 86);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(103, 23);
            this.txtSala.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(18, 139);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(210, 23);
            this.txtEstado.TabIndex = 36;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinuar.Location = new System.Drawing.Point(681, 276);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(107, 36);
            this.btnContinuar.TabIndex = 37;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.Location = new System.Drawing.Point(12, 276);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 36);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Controls.Add(this.txtFechaHora);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEstado);
            this.panel2.Controls.Add(this.txtSala);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(463, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 181);
            this.panel2.TabIndex = 3;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Enabled = false;
            this.txtFechaHora.Location = new System.Drawing.Point(18, 39);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(210, 23);
            this.txtFechaHora.TabIndex = 37;
            // 
            // gdrSeleccionFuncion
            // 
            this.gdrSeleccionFuncion.AllowUserToAddRows = false;
            this.gdrSeleccionFuncion.AllowUserToDeleteRows = false;
            this.gdrSeleccionFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSeleccionFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHora,
            this.Sala,
            this.Pelicula,
            this.Estado});
            this.gdrSeleccionFuncion.Location = new System.Drawing.Point(12, 79);
            this.gdrSeleccionFuncion.Name = "gdrSeleccionFuncion";
            this.gdrSeleccionFuncion.ReadOnly = true;
            this.gdrSeleccionFuncion.RowTemplate.Height = 25;
            this.gdrSeleccionFuncion.Size = new System.Drawing.Size(432, 181);
            this.gdrSeleccionFuncion.TabIndex = 39;
            this.gdrSeleccionFuncion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrSeleccionFuncion_CellClick_1);
            // 
            // FechaHora
            // 
            this.FechaHora.DataPropertyName = "fechaHora";
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // Pelicula
            // 
            this.Pelicula.DataPropertyName = "pelicula";
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // txtIdPeliculaFuncion
            // 
            this.txtIdPeliculaFuncion.Enabled = false;
            this.txtIdPeliculaFuncion.Location = new System.Drawing.Point(12, 326);
            this.txtIdPeliculaFuncion.Name = "txtIdPeliculaFuncion";
            this.txtIdPeliculaFuncion.Size = new System.Drawing.Size(47, 23);
            this.txtIdPeliculaFuncion.TabIndex = 43;
            this.txtIdPeliculaFuncion.Visible = false;
            // 
            // txtFormatoPeli
            // 
            this.txtFormatoPeli.Enabled = false;
            this.txtFormatoPeli.Location = new System.Drawing.Point(12, 355);
            this.txtFormatoPeli.Name = "txtFormatoPeli";
            this.txtFormatoPeli.Size = new System.Drawing.Size(47, 23);
            this.txtFormatoPeli.TabIndex = 44;
            this.txtFormatoPeli.Visible = false;
            // 
            // FuncionService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFormatoPeli);
            this.Controls.Add(this.txtIdPeliculaFuncion);
            this.Controls.Add(this.gdrSeleccionFuncion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.panel1);
            this.Name = "FuncionService";
            this.Text = "FuncionService";
            this.Load += new System.EventHandler(this.FuncionService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSeleccionFuncion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSeleccionFuncion;
        private Panel panel1;
        private Label lblTitulo;
        private Label label1;
        private TextBox txtSala;
        private Label label2;
        private TextBox txtEstado;
        private Button btnContinuar;
        private Button btnVolver;
        private Panel panel2;
        private TextBox txtFechaHora;
        private DataGridView gdrSeleccionFuncion;
        private DataGridViewTextBoxColumn FechaHora;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Pelicula;
        private DataGridViewTextBoxColumn Estado;
        public TextBox txtIdPeliculaFuncion;
        public TextBox txtFormatoPeli;
    }
}