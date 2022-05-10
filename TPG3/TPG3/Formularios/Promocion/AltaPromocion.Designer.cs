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
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.mtbFin = new System.Windows.Forms.MaskedTextBox();
            this.btnCargarPromocion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnListado = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.panelBackAltaPromocion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(71, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(338, 144);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 21);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(170, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 29);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(462, 136);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(131, 29);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(71, 207);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 21);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(209, 209);
            this.mtbValor.Mask = "99999";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(92, 23);
            this.mtbValor.TabIndex = 5;
            this.mtbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbValor.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Inicio:";
            // 
            // mtbInicio
            // 
            this.mtbInicio.Location = new System.Drawing.Point(209, 280);
            this.mtbInicio.Mask = "00/00/0000";
            this.mtbInicio.Name = "mtbInicio";
            this.mtbInicio.Size = new System.Drawing.Size(92, 23);
            this.mtbInicio.TabIndex = 7;
            this.mtbInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFin.Location = new System.Drawing.Point(338, 282);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(85, 21);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fecha Fin:";
            // 
            // mtbFin
            // 
            this.mtbFin.Location = new System.Drawing.Point(449, 177);
            this.mtbFin.Mask = "00/00/0000";
            this.mtbFin.Name = "mtbFin";
            this.mtbFin.Size = new System.Drawing.Size(92, 23);
            this.mtbFin.TabIndex = 9;
            this.mtbFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbFin.ValidatingType = typeof(System.DateTime);
            // 
            // btnCargarPromocion
            // 
            this.btnCargarPromocion.Location = new System.Drawing.Point(501, 385);
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
            this.lblTitulo.Location = new System.Drawing.Point(51, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 30);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Alta Promoción";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(298, 280);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(92, 37);
            this.btnListado.TabIndex = 12;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(71, 340);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 13;
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.mtbFin);
            this.panelBackAltaPromocion.Controls.Add(this.btnListado);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(51, 104);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(580, 357);
            this.panelBackAltaPromocion.TabIndex = 14;
            // 
            // AltaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 586);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCargarPromocion);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.mtbInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Name = "AltaPromocion";
            this.Text = "AltaPromocion";
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblValor;
        private MaskedTextBox mtbValor;
        private Label label1;
        private MaskedTextBox mtbInicio;
        private Label lblFin;
        private MaskedTextBox mtbFin;
        private Button btnCargarPromocion;
        private Label lblTitulo;
        private Button btnListado;
        private Label lblError;
        private Panel panelBackAltaPromocion;
    }
}