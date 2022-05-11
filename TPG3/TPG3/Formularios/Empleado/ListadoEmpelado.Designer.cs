﻿namespace TPG3.Formularios.Empleado
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBackAltaPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscarTipoDoc);
            this.panelBackAltaPromocion.Controls.Add(this.label2);
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscarDni);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Controls.Add(this.lblTitulo);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(30, 133);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(797, 341);
            this.panelBackAltaPromocion.TabIndex = 25;
            // 
            // txtBuscarTipoDoc
            // 
            this.txtBuscarTipoDoc.Location = new System.Drawing.Point(234, 44);
            this.txtBuscarTipoDoc.Name = "txtBuscarTipoDoc";
            this.txtBuscarTipoDoc.Size = new System.Drawing.Size(160, 23);
            this.txtBuscarTipoDoc.TabIndex = 20;
            this.txtBuscarTipoDoc.TextChanged += new System.EventHandler(this.txtBuscarTipoDoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo Doc:";
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(40, 44);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(160, 23);
            this.txtBuscarDni.TabIndex = 18;
            this.txtBuscarDni.TextChanged += new System.EventHandler(this.txtBuscarDni_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "DNI:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(519, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 30);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Lista de Empleados";
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(682, 58);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(145, 52);
            this.btnEliminarEmpleado.TabIndex = 4;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(179, 58);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(143, 52);
            this.btnEditarEmpleado.TabIndex = 3;
            this.btnEditarEmpleado.Text = "Editar Empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnCargarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnCargarEmpleado.Location = new System.Drawing.Point(30, 58);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(143, 52);
            this.btnCargarEmpleado.TabIndex = 1;
            this.btnCargarEmpleado.Text = "Cargar Empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = false;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDocumento,
            this.dni,
            this.idTipoDocumento,
            this.nombre,
            this.apellido,
            this.telefono,
            this.email});
            this.dgvEmpleados.Location = new System.Drawing.Point(53, 217);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(697, 231);
            this.dgvEmpleados.TabIndex = 2;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "tipoDocumento";
            this.tipoDocumento.HeaderText = "Tipo Documento";
            this.tipoDocumento.Name = "tipoDocumento";
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            // 
            // idTipoDocumento
            // 
            this.idTipoDocumento.DataPropertyName = "idTipoDocumento";
            this.idTipoDocumento.HeaderText = "idTipoDoc";
            this.idTipoDocumento.Name = "idTipoDocumento";
            this.idTipoDocumento.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // ListadoEmpelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(897, 506);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.btnCargarEmpleado);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Name = "ListadoEmpelado";
            this.Text = "ListadoEmpelado";
            this.Load += new System.EventHandler(this.ListadoEmpelado_Load);
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

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
        private DataGridViewTextBoxColumn tipoDocumento;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn idTipoDocumento;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
    }
}