namespace TPG3.Formularios.Empleado
{
    partial class ListadoEmpelado
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
            this.txtBuscarTipoDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panelBackAltaPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscarTipoDoc);
            this.panelBackAltaPromocion.Controls.Add(this.label2);
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscarDni);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(53, 135);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(556, 46);
            this.panelBackAltaPromocion.TabIndex = 25;
            // 
            // txtBuscarTipoDoc
            // 
            this.txtBuscarTipoDoc.Location = new System.Drawing.Point(361, 10);
            this.txtBuscarTipoDoc.Name = "txtBuscarTipoDoc";
            this.txtBuscarTipoDoc.Size = new System.Drawing.Size(160, 23);
            this.txtBuscarTipoDoc.TabIndex = 20;
            this.txtBuscarTipoDoc.TextChanged += new System.EventHandler(this.txtBuscarTipoDoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo Doc:";
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(75, 10);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(160, 23);
            this.txtBuscarDni.TabIndex = 18;
            this.txtBuscarDni.TextChanged += new System.EventHandler(this.txtBuscarDni_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "DNI:";
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(351, 89);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(145, 23);
            this.btnEliminarEmpleado.TabIndex = 24;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Location = new System.Drawing.Point(202, 89);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(143, 23);
            this.btnEditarEmpleado.TabIndex = 23;
            this.btnEditarEmpleado.Text = "Editar Empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Location = new System.Drawing.Point(53, 89);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(143, 23);
            this.btnCargarEmpleado.TabIndex = 22;
            this.btnCargarEmpleado.Text = "Cargar Empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(53, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 30);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Lista de Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(53, 217);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(791, 231);
            this.dgvEmpleados.TabIndex = 26;
            // 
            // ListadoEmpelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 506);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.btnCargarEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoEmpelado";
            this.Text = "ListadoEmpelado";
            this.Load += new System.EventHandler(this.ListadoEmpelado_Load);
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBackAltaPromocion;
        private TextBox txtBuscarDni;
        private Label label1;
        private Button btnEliminarEmpleado;
        private Button btnEditarEmpleado;
        private Button btnCargarEmpleado;
        private Label lblTitulo;
        private DataGridView dgvEmpleados;
        private TextBox txtBuscarTipoDoc;
        private Label label2;
    }
}