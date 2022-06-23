namespace ProbandoMigrar.Reportes
{
    partial class ReporteCombo
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
            this.txtLeyendaCombo = new System.Windows.Forms.Label();
            this.rdbCantItems = new System.Windows.Forms.RadioButton();
            this.rdbPrecio = new System.Windows.Forms.RadioButton();
            this.rdbTodosCombos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarCombo = new System.Windows.Forms.Button();
            this.rdbMayor = new System.Windows.Forms.RadioButton();
            this.rdbMenor = new System.Windows.Forms.RadioButton();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.txtLeyendaCombo);
            this.panel1.Controls.Add(this.rdbCantItems);
            this.panel1.Controls.Add(this.rdbPrecio);
            this.panel1.Controls.Add(this.rdbTodosCombos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 251);
            this.panel1.TabIndex = 0;
            // 
            // txtLeyendaCombo
            // 
            this.txtLeyendaCombo.AutoSize = true;
            this.txtLeyendaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtLeyendaCombo.ForeColor = System.Drawing.Color.Yellow;
            this.txtLeyendaCombo.Location = new System.Drawing.Point(31, 211);
            this.txtLeyendaCombo.Name = "txtLeyendaCombo";
            this.txtLeyendaCombo.Size = new System.Drawing.Size(0, 25);
            this.txtLeyendaCombo.TabIndex = 20;
            // 
            // rdbCantItems
            // 
            this.rdbCantItems.AutoSize = true;
            this.rdbCantItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbCantItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCantItems.ForeColor = System.Drawing.Color.White;
            this.rdbCantItems.Location = new System.Drawing.Point(36, 162);
            this.rdbCantItems.Name = "rdbCantItems";
            this.rdbCantItems.Size = new System.Drawing.Size(138, 22);
            this.rdbCantItems.TabIndex = 4;
            this.rdbCantItems.Text = "Cantidad items";
            this.rdbCantItems.UseVisualStyleBackColor = false;
            this.rdbCantItems.CheckedChanged += new System.EventHandler(this.rdbCantItems_CheckedChanged);
            // 
            // rdbPrecio
            // 
            this.rdbPrecio.AutoSize = true;
            this.rdbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrecio.ForeColor = System.Drawing.Color.White;
            this.rdbPrecio.Location = new System.Drawing.Point(36, 127);
            this.rdbPrecio.Name = "rdbPrecio";
            this.rdbPrecio.Size = new System.Drawing.Size(75, 22);
            this.rdbPrecio.TabIndex = 3;
            this.rdbPrecio.Text = "Precio";
            this.rdbPrecio.UseVisualStyleBackColor = false;
            this.rdbPrecio.CheckedChanged += new System.EventHandler(this.rdbPrecio_CheckedChanged);
            // 
            // rdbTodosCombos
            // 
            this.rdbTodosCombos.AutoSize = true;
            this.rdbTodosCombos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbTodosCombos.Checked = true;
            this.rdbTodosCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodosCombos.ForeColor = System.Drawing.Color.White;
            this.rdbTodosCombos.Location = new System.Drawing.Point(36, 89);
            this.rdbTodosCombos.Name = "rdbTodosCombos";
            this.rdbTodosCombos.Size = new System.Drawing.Size(168, 22);
            this.rdbTodosCombos.TabIndex = 2;
            this.rdbTodosCombos.TabStop = true;
            this.rdbTodosCombos.Text = "Todos los combos";
            this.rdbTodosCombos.UseVisualStyleBackColor = false;
            this.rdbTodosCombos.CheckedChanged += new System.EventHandler(this.rdbTodosCombos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Combos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.btnBuscarCombo);
            this.panel3.Controls.Add(this.rdbMayor);
            this.panel3.Controls.Add(this.rdbMenor);
            this.panel3.Controls.Add(this.mtbHasta);
            this.panel3.Controls.Add(this.mtbDesde);
            this.panel3.Controls.Add(this.rdbEntre);
            this.panel3.Location = new System.Drawing.Point(12, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1349, 128);
            this.panel3.TabIndex = 19;
            // 
            // btnBuscarCombo
            // 
            this.btnBuscarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCombo.FlatAppearance.BorderSize = 0;
            this.btnBuscarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCombo.Location = new System.Drawing.Point(1216, 78);
            this.btnBuscarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCombo.Name = "btnBuscarCombo";
            this.btnBuscarCombo.Size = new System.Drawing.Size(123, 41);
            this.btnBuscarCombo.TabIndex = 18;
            this.btnBuscarCombo.Text = "Buscar";
            this.btnBuscarCombo.UseVisualStyleBackColor = false;
            this.btnBuscarCombo.Click += new System.EventHandler(this.btnBuscarCombo_Click);
            // 
            // rdbMayor
            // 
            this.rdbMayor.AutoSize = true;
            this.rdbMayor.Checked = true;
            this.rdbMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMayor.ForeColor = System.Drawing.Color.White;
            this.rdbMayor.Location = new System.Drawing.Point(339, 24);
            this.rdbMayor.Name = "rdbMayor";
            this.rdbMayor.Size = new System.Drawing.Size(105, 22);
            this.rdbMayor.TabIndex = 5;
            this.rdbMayor.TabStop = true;
            this.rdbMayor.Text = "Mayor que";
            this.rdbMayor.UseVisualStyleBackColor = true;
            this.rdbMayor.Visible = false;
            this.rdbMayor.CheckedChanged += new System.EventHandler(this.rdbMayor_CheckedChanged);
            // 
            // rdbMenor
            // 
            this.rdbMenor.AutoSize = true;
            this.rdbMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMenor.ForeColor = System.Drawing.Color.White;
            this.rdbMenor.Location = new System.Drawing.Point(338, 97);
            this.rdbMenor.Name = "rdbMenor";
            this.rdbMenor.Size = new System.Drawing.Size(106, 22);
            this.rdbMenor.TabIndex = 7;
            this.rdbMenor.TabStop = true;
            this.rdbMenor.Text = "Menor que";
            this.rdbMenor.UseVisualStyleBackColor = true;
            this.rdbMenor.Visible = false;
            this.rdbMenor.CheckedChanged += new System.EventHandler(this.rdbMenor_CheckedChanged);
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(660, 64);
            this.mtbHasta.Mask = "9999999";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(100, 20);
            this.mtbHasta.TabIndex = 9;
            this.mtbHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbHasta.ValidatingType = typeof(int);
            this.mtbHasta.Visible = false;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(492, 62);
            this.mtbDesde.Mask = "9999999";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(100, 20);
            this.mtbDesde.TabIndex = 8;
            this.mtbDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDesde.ValidatingType = typeof(int);
            this.mtbDesde.Visible = false;
            // 
            // rdbEntre
            // 
            this.rdbEntre.AutoSize = true;
            this.rdbEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntre.ForeColor = System.Drawing.Color.White;
            this.rdbEntre.Location = new System.Drawing.Point(339, 62);
            this.rdbEntre.Name = "rdbEntre";
            this.rdbEntre.Size = new System.Drawing.Size(66, 22);
            this.rdbEntre.TabIndex = 6;
            this.rdbEntre.TabStop = true;
            this.rdbEntre.Text = "Entre";
            this.rdbEntre.UseVisualStyleBackColor = true;
            this.rdbEntre.Visible = false;
            this.rdbEntre.CheckedChanged += new System.EventHandler(this.rdbEntre_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 644);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 61);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Combo.ReporteCombo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 251);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1370, 393);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 705);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Combos";
            this.Load += new System.EventHandler(this.ReporteCombo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
        private System.Windows.Forms.RadioButton rdbMenor;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.RadioButton rdbMayor;
        private System.Windows.Forms.RadioButton rdbCantItems;
        private System.Windows.Forms.RadioButton rdbPrecio;
        private System.Windows.Forms.RadioButton rdbTodosCombos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCombo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtLeyendaCombo;
    }
}