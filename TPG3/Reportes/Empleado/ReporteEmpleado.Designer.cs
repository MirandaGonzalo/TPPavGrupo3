namespace ProbandoMigrar.Reportes.Empleado
{
    partial class ReporteEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLeyendaCliente = new System.Windows.Forms.Label();
            this.rdbDni = new System.Windows.Forms.RadioButton();
            this.rdbTodosEmpleados = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtbDni = new System.Windows.Forms.MaskedTextBox();
            this.txtNA = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.txtLeyendaCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 266);
            this.panel1.TabIndex = 7;
            // 
            // txtLeyendaCliente
            // 
            this.txtLeyendaCliente.AutoSize = true;
            this.txtLeyendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyendaCliente.ForeColor = System.Drawing.Color.Yellow;
            this.txtLeyendaCliente.Location = new System.Drawing.Point(45, 208);
            this.txtLeyendaCliente.Name = "txtLeyendaCliente";
            this.txtLeyendaCliente.Size = new System.Drawing.Size(0, 25);
            this.txtLeyendaCliente.TabIndex = 20;
            // 
            // rdbDni
            // 
            this.rdbDni.AutoSize = true;
            this.rdbDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDni.ForeColor = System.Drawing.Color.White;
            this.rdbDni.Location = new System.Drawing.Point(22, 66);
            this.rdbDni.Name = "rdbDni";
            this.rdbDni.Size = new System.Drawing.Size(51, 22);
            this.rdbDni.TabIndex = 3;
            this.rdbDni.Text = "Dni";
            this.rdbDni.UseVisualStyleBackColor = false;
            this.rdbDni.CheckedChanged += new System.EventHandler(this.rdbDni_CheckedChanged);
            // 
            // rdbTodosEmpleados
            // 
            this.rdbTodosEmpleados.AutoSize = true;
            this.rdbTodosEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbTodosEmpleados.Checked = true;
            this.rdbTodosEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodosEmpleados.ForeColor = System.Drawing.Color.White;
            this.rdbTodosEmpleados.Location = new System.Drawing.Point(22, 20);
            this.rdbTodosEmpleados.Name = "rdbTodosEmpleados";
            this.rdbTodosEmpleados.Size = new System.Drawing.Size(189, 22);
            this.rdbTodosEmpleados.TabIndex = 2;
            this.rdbTodosEmpleados.TabStop = true;
            this.rdbTodosEmpleados.Text = "Todos los empleados";
            this.rdbTodosEmpleados.UseVisualStyleBackColor = false;
            this.rdbTodosEmpleados.CheckedChanged += new System.EventHandler(this.rdbTodosClientes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Listado de Empleados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.mtbDni);
            this.panel3.Controls.Add(this.txtNA);
            this.panel3.Controls.Add(this.btnBuscarCliente);
            this.panel3.Location = new System.Drawing.Point(440, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 115);
            this.panel3.TabIndex = 19;
            // 
            // mtbDni
            // 
            this.mtbDni.Location = new System.Drawing.Point(171, 47);
            this.mtbDni.Mask = "99999999";
            this.mtbDni.Name = "mtbDni";
            this.mtbDni.Size = new System.Drawing.Size(127, 20);
            this.mtbDni.TabIndex = 20;
            this.mtbDni.ValidatingType = typeof(int);
            this.mtbDni.Visible = false;
            // 
            // txtNA
            // 
            this.txtNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNA.Location = new System.Drawing.Point(171, 47);
            this.txtNA.Name = "txtNA";
            this.txtNA.Size = new System.Drawing.Size(127, 26);
            this.txtNA.TabIndex = 19;
            this.txtNA.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCliente.Location = new System.Drawing.Point(438, 56);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(123, 41);
            this.btnBuscarCliente.TabIndex = 18;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNombre.ForeColor = System.Drawing.Color.White;
            this.rdbNombre.Location = new System.Drawing.Point(269, 20);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(86, 22);
            this.rdbNombre.TabIndex = 5;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbApellido.ForeColor = System.Drawing.Color.White;
            this.rdbApellido.Location = new System.Drawing.Point(270, 66);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(85, 22);
            this.rdbApellido.TabIndex = 6;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = false;
            this.rdbApellido.CheckedChanged += new System.EventHandler(this.rdbApellido_CheckedChanged);
            // 
            // panelAbajo
            // 
            this.panelAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(0, 620);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(1059, 100);
            this.panelAbajo.TabIndex = 8;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Empleado.ReporteEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 266);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1059, 354);
            this.reportViewer1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.rdbNombre);
            this.panel2.Controls.Add(this.rdbTodosEmpleados);
            this.panel2.Controls.Add(this.rdbDni);
            this.panel2.Controls.Add(this.rdbApellido);
            this.panel2.Location = new System.Drawing.Point(36, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 115);
            this.panel2.TabIndex = 21;
            // 
            // ReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 720);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteEmpleado";
            this.Text = "ReporteEmpleado";
            this.Load += new System.EventHandler(this.ReporteEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtLeyendaCliente;
        private System.Windows.Forms.RadioButton rdbDni;
        private System.Windows.Forms.RadioButton rdbTodosEmpleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mtbDni;
        private System.Windows.Forms.TextBox txtNA;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbApellido;
        private System.Windows.Forms.Panel panelAbajo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
    }
}