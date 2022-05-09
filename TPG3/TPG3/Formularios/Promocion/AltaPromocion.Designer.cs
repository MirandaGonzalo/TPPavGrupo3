namespace TPG3.Formularios.Promocion
{
    partial class AltaPromocion
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.mtbFin = new System.Windows.Forms.MaskedTextBox();
            this.btnCargarPromocion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(103, 185);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(103, 227);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 21);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(215, 177);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 29);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(215, 219);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(131, 29);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(103, 273);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 21);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(284, 271);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(62, 23);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Inicio:";
            // 
            // mtbInicio
            // 
            this.mtbInicio.Location = new System.Drawing.Point(284, 314);
            this.mtbInicio.Mask = "00/00/0000";
            this.mtbInicio.Name = "mtbInicio";
            this.mtbInicio.Size = new System.Drawing.Size(62, 23);
            this.mtbInicio.TabIndex = 7;
            this.mtbInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFin.Location = new System.Drawing.Point(103, 353);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(85, 21);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fecha Fin:";
            // 
            // mtbFin
            // 
            this.mtbFin.Location = new System.Drawing.Point(284, 351);
            this.mtbFin.Mask = "00/00/0000";
            this.mtbFin.Name = "mtbFin";
            this.mtbFin.Size = new System.Drawing.Size(62, 23);
            this.mtbFin.TabIndex = 9;
            this.mtbFin.ValidatingType = typeof(System.DateTime);
            // 
            // btnCargarPromocion
            // 
            this.btnCargarPromocion.Location = new System.Drawing.Point(254, 398);
            this.btnCargarPromocion.Name = "btnCargarPromocion";
            this.btnCargarPromocion.Size = new System.Drawing.Size(92, 37);
            this.btnCargarPromocion.TabIndex = 10;
            this.btnCargarPromocion.Text = "Cargar";
            this.btnCargarPromocion.UseVisualStyleBackColor = true;
            this.btnCargarPromocion.Click += new System.EventHandler(this.btnCargarPromocion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(103, 123);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 30);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Alta Promoción";
            // 
            // AltaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 586);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCargarPromocion);
            this.Controls.Add(this.mtbFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.mtbInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Name = "AltaPromocion";
            this.Text = "AltaPromocion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblValor;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private MaskedTextBox mtbInicio;
        private Label lblFin;
        private MaskedTextBox mtbFin;
        private Button btnCargarPromocion;
        private Label lblTitulo;
    }
}