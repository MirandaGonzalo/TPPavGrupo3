namespace TPG3.Formularios.TipoDocumento
{
    partial class ListadoTipoDocumento
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
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarPromo = new System.Windows.Forms.Button();
            this.btnEditarPromo = new System.Windows.Forms.Button();
            this.btnCargarTipoDoc = new System.Windows.Forms.Button();
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBackAltaPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscar);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(53, 106);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(292, 46);
            this.panelBackAltaPromocion.TabIndex = 26;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(120, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 23);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // btnEliminarPromo
            // 
            this.btnEliminarPromo.Location = new System.Drawing.Point(351, 60);
            this.btnEliminarPromo.Name = "btnEliminarPromo";
            this.btnEliminarPromo.Size = new System.Drawing.Size(145, 23);
            this.btnEliminarPromo.TabIndex = 25;
            this.btnEliminarPromo.Text = "Eliminar Tipo Doc";
            this.btnEliminarPromo.UseVisualStyleBackColor = true;
            // 
            // btnEditarPromo
            // 
            this.btnEditarPromo.Location = new System.Drawing.Point(202, 60);
            this.btnEditarPromo.Name = "btnEditarPromo";
            this.btnEditarPromo.Size = new System.Drawing.Size(143, 23);
            this.btnEditarPromo.TabIndex = 24;
            this.btnEditarPromo.Text = "Editar Tipo Doc";
            this.btnEditarPromo.UseVisualStyleBackColor = true;
            // 
            // btnCargarTipoDoc
            // 
            this.btnCargarTipoDoc.Location = new System.Drawing.Point(53, 60);
            this.btnCargarTipoDoc.Name = "btnCargarTipoDoc";
            this.btnCargarTipoDoc.Size = new System.Drawing.Size(143, 23);
            this.btnCargarTipoDoc.TabIndex = 23;
            this.btnCargarTipoDoc.Text = "Cargar Tipo Doc";
            this.btnCargarTipoDoc.UseVisualStyleBackColor = true;
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.AllowUserToAddRows = false;
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Location = new System.Drawing.Point(53, 169);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowTemplate.Height = 25;
            this.dgvPromocion.Size = new System.Drawing.Size(292, 273);
            this.dgvPromocion.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(53, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 30);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Lista de Tipos de Documentos";
            // 
            // ListadoTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Controls.Add(this.btnEliminarPromo);
            this.Controls.Add(this.btnEditarPromo);
            this.Controls.Add(this.btnCargarTipoDoc);
            this.Controls.Add(this.dgvPromocion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoTipoDocumento";
            this.Text = "ListadoTipoDocumento";
            this.Load += new System.EventHandler(this.ListadoTipoDocumento_Load);
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBackAltaPromocion;
        private TextBox txtBuscar;
        private Label label1;
        private Button btnEliminarPromo;
        private Button btnEditarPromo;
        private Button btnCargarTipoDoc;
        private DataGridView dgvPromocion;
        private Label lblTitulo;
    }
}