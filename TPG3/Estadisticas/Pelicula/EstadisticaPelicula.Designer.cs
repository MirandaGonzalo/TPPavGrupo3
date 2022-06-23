namespace ProbandoMigrar.Estadisticas.Pelicula
{
    partial class EstadisticaPelicula
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelParam = new System.Windows.Forms.Panel();
            this.btnBuscarPelicula = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDistribuidora = new System.Windows.Forms.RadioButton();
            this.rbOrigen = new System.Windows.Forms.RadioButton();
            this.rbCalificacion = new System.Windows.Forms.RadioButton();
            this.rdbTodasPeliculas = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.rpvPeliculas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelSuperior.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelSuperior.Controls.Add(this.panelParam);
            this.panelSuperior.Controls.Add(this.panel1);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(922, 206);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelParam.Controls.Add(this.btnBuscarPelicula);
            this.panelParam.Location = new System.Drawing.Point(494, 56);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(431, 105);
            this.panelParam.TabIndex = 14;
            // 
            // btnBuscarPelicula
            // 
            this.btnBuscarPelicula.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarPelicula.FlatAppearance.BorderSize = 0;
            this.btnBuscarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPelicula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarPelicula.Location = new System.Drawing.Point(273, 52);
            this.btnBuscarPelicula.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarPelicula.Name = "btnBuscarPelicula";
            this.btnBuscarPelicula.Size = new System.Drawing.Size(123, 35);
            this.btnBuscarPelicula.TabIndex = 27;
            this.btnBuscarPelicula.Text = "Buscar";
            this.btnBuscarPelicula.UseVisualStyleBackColor = false;
            this.btnBuscarPelicula.Click += new System.EventHandler(this.btnBuscarPelicula_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.rbDistribuidora);
            this.panel1.Controls.Add(this.rbOrigen);
            this.panel1.Controls.Add(this.rbCalificacion);
            this.panel1.Controls.Add(this.rdbTodasPeliculas);
            this.panel1.Location = new System.Drawing.Point(30, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 105);
            this.panel1.TabIndex = 4;
            // 
            // rbDistribuidora
            // 
            this.rbDistribuidora.AutoSize = true;
            this.rbDistribuidora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDistribuidora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDistribuidora.Location = new System.Drawing.Point(240, 65);
            this.rbDistribuidora.Name = "rbDistribuidora";
            this.rbDistribuidora.Size = new System.Drawing.Size(122, 22);
            this.rbDistribuidora.TabIndex = 14;
            this.rbDistribuidora.Text = "Distribuidora";
            this.rbDistribuidora.UseVisualStyleBackColor = true;
            // 
            // rbOrigen
            // 
            this.rbOrigen.AutoSize = true;
            this.rbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrigen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbOrigen.Location = new System.Drawing.Point(19, 65);
            this.rbOrigen.Name = "rbOrigen";
            this.rbOrigen.Size = new System.Drawing.Size(76, 22);
            this.rbOrigen.TabIndex = 13;
            this.rbOrigen.Text = "Origen";
            this.rbOrigen.UseVisualStyleBackColor = true;
            // 
            // rbCalificacion
            // 
            this.rbCalificacion.AutoSize = true;
            this.rbCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCalificacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbCalificacion.Location = new System.Drawing.Point(240, 15);
            this.rbCalificacion.Name = "rbCalificacion";
            this.rbCalificacion.Size = new System.Drawing.Size(114, 22);
            this.rbCalificacion.TabIndex = 12;
            this.rbCalificacion.Text = "Calificación";
            this.rbCalificacion.UseVisualStyleBackColor = true;
            // 
            // rdbTodasPeliculas
            // 
            this.rdbTodasPeliculas.AutoSize = true;
            this.rdbTodasPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.rdbTodasPeliculas.Checked = true;
            this.rdbTodasPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodasPeliculas.ForeColor = System.Drawing.Color.White;
            this.rdbTodasPeliculas.Location = new System.Drawing.Point(19, 15);
            this.rdbTodasPeliculas.Name = "rdbTodasPeliculas";
            this.rdbTodasPeliculas.Size = new System.Drawing.Size(85, 22);
            this.rdbTodasPeliculas.TabIndex = 3;
            this.rdbTodasPeliculas.TabStop = true;
            this.rdbTodasPeliculas.Text = "Estreno";
            this.rdbTodasPeliculas.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Listado de Películas";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 463);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(922, 78);
            this.panelInferior.TabIndex = 1;
            // 
            // rpvPeliculas
            // 
            this.rpvPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvPeliculas.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Estadisticas.Pelicula.ReporteEstadisticaPelicula.rdlc";
            this.rpvPeliculas.Location = new System.Drawing.Point(0, 206);
            this.rpvPeliculas.Name = "rpvPeliculas";
            this.rpvPeliculas.ServerReport.BearerToken = null;
            this.rpvPeliculas.Size = new System.Drawing.Size(922, 257);
            this.rpvPeliculas.TabIndex = 2;
            // 
            // EstadisticaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 541);
            this.Controls.Add(this.rpvPeliculas);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Name = "EstadisticaPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaPelicula";
            this.Load += new System.EventHandler(this.EstadisticaPelicula_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelParam.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDistribuidora;
        private System.Windows.Forms.RadioButton rbOrigen;
        private System.Windows.Forms.RadioButton rbCalificacion;
        private System.Windows.Forms.RadioButton rdbTodasPeliculas;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPeliculas;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnBuscarPelicula;
    }
}