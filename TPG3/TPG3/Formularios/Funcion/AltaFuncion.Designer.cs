namespace TPG3.Formularios.Funcion
{
    partial class AltaFuncion
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
            this.panelBackAltaFuncion = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbFechaFin = new System.Windows.Forms.ComboBox();
            this.cmbFechaInicio = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbPeli = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.btnCargarFuncion = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnListado = new System.Windows.Forms.Button();
            this.funcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBackAltaFuncion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackAltaFuncion
            // 
            this.panelBackAltaFuncion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackAltaFuncion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaFuncion.Controls.Add(this.lblError);
            this.panelBackAltaFuncion.Controls.Add(this.cmbFechaFin);
            this.panelBackAltaFuncion.Controls.Add(this.cmbFechaInicio);
            this.panelBackAltaFuncion.Controls.Add(this.cmbEstado);
            this.panelBackAltaFuncion.Controls.Add(this.cmbPeli);
            this.panelBackAltaFuncion.Controls.Add(this.cmbSala);
            this.panelBackAltaFuncion.Controls.Add(this.btnCargarFuncion);
            this.panelBackAltaFuncion.Controls.Add(this.lblFechaInicio);
            this.panelBackAltaFuncion.Controls.Add(this.lblFechaFin);
            this.panelBackAltaFuncion.Controls.Add(this.lblEstado);
            this.panelBackAltaFuncion.Controls.Add(this.lblPelicula);
            this.panelBackAltaFuncion.Controls.Add(this.lblSala);
            this.panelBackAltaFuncion.Controls.Add(this.maskedTextBox1);
            this.panelBackAltaFuncion.Controls.Add(this.lblFechaHora);
            this.panelBackAltaFuncion.Controls.Add(this.btnListado);
            this.panelBackAltaFuncion.Location = new System.Drawing.Point(85, 56);
            this.panelBackAltaFuncion.Name = "panelBackAltaFuncion";
            this.panelBackAltaFuncion.Size = new System.Drawing.Size(667, 357);
            this.panelBackAltaFuncion.TabIndex = 15;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(331, 158);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 34;
            // 
            // cmbFechaFin
            // 
            this.cmbFechaFin.FormattingEnabled = true;
            this.cmbFechaFin.Location = new System.Drawing.Point(463, 77);
            this.cmbFechaFin.Name = "cmbFechaFin";
            this.cmbFechaFin.Size = new System.Drawing.Size(121, 23);
            this.cmbFechaFin.TabIndex = 5;
            // 
            // cmbFechaInicio
            // 
            this.cmbFechaInicio.FormattingEnabled = true;
            this.cmbFechaInicio.Location = new System.Drawing.Point(463, 25);
            this.cmbFechaInicio.Name = "cmbFechaInicio";
            this.cmbFechaInicio.Size = new System.Drawing.Size(121, 23);
            this.cmbFechaInicio.TabIndex = 4;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(155, 187);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 23);
            this.cmbEstado.TabIndex = 3;
            // 
            // cmbPeli
            // 
            this.cmbPeli.FormattingEnabled = true;
            this.cmbPeli.Location = new System.Drawing.Point(155, 131);
            this.cmbPeli.Name = "cmbPeli";
            this.cmbPeli.Size = new System.Drawing.Size(121, 23);
            this.cmbPeli.TabIndex = 2;
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(155, 77);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(121, 23);
            this.cmbSala.TabIndex = 1;
            // 
            // btnCargarFuncion
            // 
            this.btnCargarFuncion.Location = new System.Drawing.Point(492, 280);
            this.btnCargarFuncion.Name = "btnCargarFuncion";
            this.btnCargarFuncion.Size = new System.Drawing.Size(92, 37);
            this.btnCargarFuncion.TabIndex = 6;
            this.btnCargarFuncion.Text = "Cargar";
            this.btnCargarFuncion.UseVisualStyleBackColor = true;
            this.btnCargarFuncion.Click += new System.EventHandler(this.btnCargarFuncion_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaInicio.Location = new System.Drawing.Point(336, 27);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(105, 21);
            this.lblFechaInicio.TabIndex = 23;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaFin.Location = new System.Drawing.Point(336, 79);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(85, 21);
            this.lblFechaFin.TabIndex = 22;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(26, 189);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(65, 21);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPelicula.Location = new System.Drawing.Point(26, 133);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(75, 21);
            this.lblPelicula.TabIndex = 18;
            this.lblPelicula.Text = "Pelicula:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSala.Location = new System.Drawing.Point(26, 79);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(46, 21);
            this.lblSala.TabIndex = 15;
            this.lblSala.Text = "Sala:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(155, 25);
            this.maskedTextBox1.Mask = "00/00/0000 00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(131, 23);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaHora.Location = new System.Drawing.Point(26, 27);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(112, 21);
            this.lblFechaHora.TabIndex = 13;
            this.lblFechaHora.Text = "Fecha y Hora:";
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(298, 280);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(92, 37);
            this.btnListado.TabIndex = 7;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // funcionBindingSource
            // 
            this.funcionBindingSource.DataSource = typeof(TPG3.Entidades.Funcion);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(85, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 30);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Alta Función";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AltaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBackAltaFuncion);
            this.Name = "AltaFuncion";
            this.Text = "AltaFuncion";
            this.panelBackAltaFuncion.ResumeLayout(false);
            this.panelBackAltaFuncion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBackAltaFuncion;
        private Button btnListado;
        private Label lblTitulo;
        private Label lblFechaHora;
        private Label lblSala;
        private MaskedTextBox maskedTextBox1;
        private BindingSource funcionBindingSource;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Label lblEstado;
        private Label lblPelicula;
        private Button btnCargarFuncion;
        private ComboBox cmbEstado;
        private ComboBox cmbPeli;
        private ComboBox cmbSala;
        private ComboBox cmbFechaFin;
        private ComboBox cmbFechaInicio;
        private Label lblError;
    }
}