namespace TPG3.Formularios.Tarjeta
{
    partial class AltaTarjeta
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
            this.txtCodTarjeta = new System.Windows.Forms.TextBox();
            this.btnRegistrarTarjeta = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBancoTarjeta = new System.Windows.Forms.Label();
            this.lblDescripcionTarjeta = new System.Windows.Forms.Label();
            this.lblNombreTarjeta = new System.Windows.Forms.Label();
            this.lblCodTarjeta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnListado = new System.Windows.Forms.Button();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodTarjeta
            // 
            this.txtCodTarjeta.Location = new System.Drawing.Point(215, 110);
            this.txtCodTarjeta.MaxLength = 16;
            this.txtCodTarjeta.Name = "txtCodTarjeta";
            this.txtCodTarjeta.Size = new System.Drawing.Size(199, 23);
            this.txtCodTarjeta.TabIndex = 24;
            // 
            // btnRegistrarTarjeta
            // 
            this.btnRegistrarTarjeta.Location = new System.Drawing.Point(101, 281);
            this.btnRegistrarTarjeta.Name = "btnRegistrarTarjeta";
            this.btnRegistrarTarjeta.Size = new System.Drawing.Size(122, 23);
            this.btnRegistrarTarjeta.TabIndex = 23;
            this.btnRegistrarTarjeta.Text = "Registrar Tarjeta";
            this.btnRegistrarTarjeta.UseVisualStyleBackColor = true;
            this.btnRegistrarTarjeta.Click += new System.EventHandler(this.btnRegistrarTarjeta_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(215, 194);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 23);
            this.txtDescripcion.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblBancoTarjeta
            // 
            this.lblBancoTarjeta.AutoSize = true;
            this.lblBancoTarjeta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBancoTarjeta.Location = new System.Drawing.Point(139, 241);
            this.lblBancoTarjeta.Name = "lblBancoTarjeta";
            this.lblBancoTarjeta.Size = new System.Drawing.Size(56, 20);
            this.lblBancoTarjeta.TabIndex = 19;
            this.lblBancoTarjeta.Text = "Banco:";
            // 
            // lblDescripcionTarjeta
            // 
            this.lblDescripcionTarjeta.AutoSize = true;
            this.lblDescripcionTarjeta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcionTarjeta.Location = new System.Drawing.Point(101, 197);
            this.lblDescripcionTarjeta.Name = "lblDescripcionTarjeta";
            this.lblDescripcionTarjeta.Size = new System.Drawing.Size(94, 20);
            this.lblDescripcionTarjeta.TabIndex = 18;
            this.lblDescripcionTarjeta.Text = "Descripcion:";
            // 
            // lblNombreTarjeta
            // 
            this.lblNombreTarjeta.AutoSize = true;
            this.lblNombreTarjeta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreTarjeta.Location = new System.Drawing.Point(124, 154);
            this.lblNombreTarjeta.Name = "lblNombreTarjeta";
            this.lblNombreTarjeta.Size = new System.Drawing.Size(71, 20);
            this.lblNombreTarjeta.TabIndex = 17;
            this.lblNombreTarjeta.Text = "Nombre:";
            // 
            // lblCodTarjeta
            // 
            this.lblCodTarjeta.AutoSize = true;
            this.lblCodTarjeta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodTarjeta.Location = new System.Drawing.Point(51, 113);
            this.lblCodTarjeta.Name = "lblCodTarjeta";
            this.lblCodTarjeta.Size = new System.Drawing.Size(144, 20);
            this.lblCodTarjeta.TabIndex = 16;
            this.lblCodTarjeta.Text = "Numero de Tarjeta:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(51, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 32);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Alta Tarjeta";
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(330, 281);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(122, 23);
            this.btnListado.TabIndex = 25;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(215, 238);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(199, 23);
            this.cmbBanco.TabIndex = 26;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(101, 344);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 27;
            // 
            // AltaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.txtCodTarjeta);
            this.Controls.Add(this.btnRegistrarTarjeta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblBancoTarjeta);
            this.Controls.Add(this.lblDescripcionTarjeta);
            this.Controls.Add(this.lblNombreTarjeta);
            this.Controls.Add(this.lblCodTarjeta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AltaTarjeta";
            this.Text = "AltaTarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCodTarjeta;
        private Button btnRegistrarTarjeta;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblBancoTarjeta;
        private Label lblDescripcionTarjeta;
        private Label lblNombreTarjeta;
        private Label lblCodTarjeta;
        private Label lblTitulo;
        private Button btnListado;
        private ComboBox cmbBanco;
        private Label lblError;
    }
}