namespace ProbandoMigrar.Reportes
{
    partial class ReporteListadoCliente
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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K7G032022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLeyendaCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.rdbDsp = new System.Windows.Forms.RadioButton();
            this.mtbFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtNA = new System.Windows.Forms.TextBox();
            this.mtbfechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.rdbAntes = new System.Windows.Forms.RadioButton();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.mtbDni = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbFechaNac = new System.Windows.Forms.RadioButton();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.rdbDni = new System.Windows.Forms.RadioButton();
            this.rdbTodosClientes = new System.Windows.Forms.RadioButton();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G032022DataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
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
            this.panel1.Size = new System.Drawing.Size(1370, 266);
            this.panel1.TabIndex = 6;
            // 
            // txtLeyendaCliente
            // 
            this.txtLeyendaCliente.AutoSize = true;
            this.txtLeyendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyendaCliente.ForeColor = System.Drawing.Color.Yellow;
            this.txtLeyendaCliente.Location = new System.Drawing.Point(31, 226);
            this.txtLeyendaCliente.Name = "txtLeyendaCliente";
            this.txtLeyendaCliente.Size = new System.Drawing.Size(0, 25);
            this.txtLeyendaCliente.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Listado de Clientes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.btnBuscarCliente);
            this.panel3.Controls.Add(this.rdbDsp);
            this.panel3.Controls.Add(this.mtbFechaDesde);
            this.panel3.Controls.Add(this.txtNA);
            this.panel3.Controls.Add(this.mtbfechaHasta);
            this.panel3.Controls.Add(this.rdbAntes);
            this.panel3.Controls.Add(this.rdbEntre);
            this.panel3.Controls.Add(this.mtbDni);
            this.panel3.Location = new System.Drawing.Point(488, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 143);
            this.panel3.TabIndex = 19;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCliente.Location = new System.Drawing.Point(651, 87);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(123, 41);
            this.btnBuscarCliente.TabIndex = 18;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // rdbDsp
            // 
            this.rdbDsp.AutoSize = true;
            this.rdbDsp.Checked = true;
            this.rdbDsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDsp.ForeColor = System.Drawing.Color.White;
            this.rdbDsp.Location = new System.Drawing.Point(44, 24);
            this.rdbDsp.Name = "rdbDsp";
            this.rdbDsp.Size = new System.Drawing.Size(119, 22);
            this.rdbDsp.TabIndex = 23;
            this.rdbDsp.TabStop = true;
            this.rdbDsp.Text = "Después del";
            this.rdbDsp.UseVisualStyleBackColor = true;
            this.rdbDsp.Visible = false;
            this.rdbDsp.CheckedChanged += new System.EventHandler(this.rdbDsp_CheckedChanged);
            // 
            // mtbFechaDesde
            // 
            this.mtbFechaDesde.Location = new System.Drawing.Point(215, 64);
            this.mtbFechaDesde.Mask = "00/00/0000";
            this.mtbFechaDesde.Name = "mtbFechaDesde";
            this.mtbFechaDesde.Size = new System.Drawing.Size(127, 20);
            this.mtbFechaDesde.TabIndex = 21;
            this.mtbFechaDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbFechaDesde.ValidatingType = typeof(System.DateTime);
            this.mtbFechaDesde.Visible = false;
            // 
            // txtNA
            // 
            this.txtNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNA.Location = new System.Drawing.Point(264, 60);
            this.txtNA.Name = "txtNA";
            this.txtNA.Size = new System.Drawing.Size(127, 26);
            this.txtNA.TabIndex = 19;
            this.txtNA.Visible = false;
            // 
            // mtbfechaHasta
            // 
            this.mtbfechaHasta.Location = new System.Drawing.Point(374, 64);
            this.mtbfechaHasta.Mask = "00/00/0000";
            this.mtbfechaHasta.Name = "mtbfechaHasta";
            this.mtbfechaHasta.Size = new System.Drawing.Size(127, 20);
            this.mtbfechaHasta.TabIndex = 22;
            this.mtbfechaHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbfechaHasta.ValidatingType = typeof(System.DateTime);
            this.mtbfechaHasta.Visible = false;
            // 
            // rdbAntes
            // 
            this.rdbAntes.AutoSize = true;
            this.rdbAntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAntes.ForeColor = System.Drawing.Color.White;
            this.rdbAntes.Location = new System.Drawing.Point(43, 97);
            this.rdbAntes.Name = "rdbAntes";
            this.rdbAntes.Size = new System.Drawing.Size(95, 22);
            this.rdbAntes.TabIndex = 25;
            this.rdbAntes.TabStop = true;
            this.rdbAntes.Text = "Antes del";
            this.rdbAntes.UseVisualStyleBackColor = true;
            this.rdbAntes.Visible = false;
            this.rdbAntes.CheckedChanged += new System.EventHandler(this.rdbAntes_CheckedChanged);
            // 
            // rdbEntre
            // 
            this.rdbEntre.AutoSize = true;
            this.rdbEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntre.ForeColor = System.Drawing.Color.White;
            this.rdbEntre.Location = new System.Drawing.Point(44, 62);
            this.rdbEntre.Name = "rdbEntre";
            this.rdbEntre.Size = new System.Drawing.Size(66, 22);
            this.rdbEntre.TabIndex = 24;
            this.rdbEntre.TabStop = true;
            this.rdbEntre.Text = "Entre";
            this.rdbEntre.UseVisualStyleBackColor = true;
            this.rdbEntre.Visible = false;
            this.rdbEntre.CheckedChanged += new System.EventHandler(this.rdbEntre_CheckedChanged);
            // 
            // mtbDni
            // 
            this.mtbDni.Location = new System.Drawing.Point(215, 65);
            this.mtbDni.Mask = "99999999";
            this.mtbDni.Name = "mtbDni";
            this.mtbDni.Size = new System.Drawing.Size(127, 20);
            this.mtbDni.TabIndex = 20;
            this.mtbDni.ValidatingType = typeof(int);
            this.mtbDni.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.rdbNombre);
            this.panel2.Controls.Add(this.rdbFechaNac);
            this.panel2.Controls.Add(this.rdbApellido);
            this.panel2.Controls.Add(this.rdbDni);
            this.panel2.Controls.Add(this.rdbTodosClientes);
            this.panel2.Location = new System.Drawing.Point(36, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 143);
            this.panel2.TabIndex = 21;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNombre.ForeColor = System.Drawing.Color.White;
            this.rdbNombre.Location = new System.Drawing.Point(248, 24);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(86, 22);
            this.rdbNombre.TabIndex = 5;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbFechaNac
            // 
            this.rdbFechaNac.AutoSize = true;
            this.rdbFechaNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFechaNac.ForeColor = System.Drawing.Color.White;
            this.rdbFechaNac.Location = new System.Drawing.Point(24, 106);
            this.rdbFechaNac.Name = "rdbFechaNac";
            this.rdbFechaNac.Size = new System.Drawing.Size(162, 22);
            this.rdbFechaNac.TabIndex = 4;
            this.rdbFechaNac.Text = "Fecha Nacimiento";
            this.rdbFechaNac.UseVisualStyleBackColor = false;
            this.rdbFechaNac.CheckedChanged += new System.EventHandler(this.rdbFechaNac_CheckedChanged);
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbApellido.ForeColor = System.Drawing.Color.White;
            this.rdbApellido.Location = new System.Drawing.Point(248, 65);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(85, 22);
            this.rdbApellido.TabIndex = 6;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = true;
            this.rdbApellido.CheckedChanged += new System.EventHandler(this.rdbApellido_CheckedChanged);
            // 
            // rdbDni
            // 
            this.rdbDni.AutoSize = true;
            this.rdbDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDni.ForeColor = System.Drawing.Color.White;
            this.rdbDni.Location = new System.Drawing.Point(24, 65);
            this.rdbDni.Name = "rdbDni";
            this.rdbDni.Size = new System.Drawing.Size(51, 22);
            this.rdbDni.TabIndex = 3;
            this.rdbDni.Text = "Dni";
            this.rdbDni.UseVisualStyleBackColor = false;
            this.rdbDni.CheckedChanged += new System.EventHandler(this.rdbDni_CheckedChanged);
            // 
            // rdbTodosClientes
            // 
            this.rdbTodosClientes.AutoSize = true;
            this.rdbTodosClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbTodosClientes.Checked = true;
            this.rdbTodosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodosClientes.ForeColor = System.Drawing.Color.White;
            this.rdbTodosClientes.Location = new System.Drawing.Point(24, 24);
            this.rdbTodosClientes.Name = "rdbTodosClientes";
            this.rdbTodosClientes.Size = new System.Drawing.Size(165, 22);
            this.rdbTodosClientes.TabIndex = 2;
            this.rdbTodosClientes.TabStop = true;
            this.rdbTodosClientes.Text = "Todos los clientes";
            this.rdbTodosClientes.UseVisualStyleBackColor = false;
            this.rdbTodosClientes.CheckedChanged += new System.EventHandler(this.rdbTodosClientes_CheckedChanged);
            // 
            // panelAbajo
            // 
            this.panelAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(0, 520);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(1370, 100);
            this.panelAbajo.TabIndex = 7;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Cliente.ReporteCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 266);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1370, 254);
            this.reportViewer1.TabIndex = 8;
            // 
            // ReporteListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 620);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteListadoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ReporteListadoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G032022DataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource bD3K7G032022DataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbFechaNac;
        private System.Windows.Forms.RadioButton rdbDni;
        private System.Windows.Forms.RadioButton rdbTodosClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mtbfechaHasta;
        private System.Windows.Forms.MaskedTextBox mtbFechaDesde;
        private System.Windows.Forms.MaskedTextBox mtbDni;
        private System.Windows.Forms.TextBox txtNA;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbApellido;
        private System.Windows.Forms.RadioButton rdbDsp;
        private System.Windows.Forms.RadioButton rdbAntes;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.Panel panelAbajo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label txtLeyendaCliente;
        private System.Windows.Forms.Panel panel2;
    }
}