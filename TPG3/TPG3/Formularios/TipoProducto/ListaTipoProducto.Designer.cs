﻿namespace TPG3.Formularios.TipoProducto
{
    partial class ListaTipoProducto
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
            this.grdBuscadorTipoProd = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorTipoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.grdBuscadorTipoProd);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 347);
            this.panel1.TabIndex = 19;
            // 
            // grdBuscadorTipoProd
            // 
            this.grdBuscadorTipoProd.AllowUserToAddRows = false;
            this.grdBuscadorTipoProd.AllowUserToDeleteRows = false;
            this.grdBuscadorTipoProd.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadorTipoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadorTipoProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.grdBuscadorTipoProd.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadorTipoProd.Location = new System.Drawing.Point(72, 103);
            this.grdBuscadorTipoProd.Name = "grdBuscadorTipoProd";
            this.grdBuscadorTipoProd.ReadOnly = true;
            this.grdBuscadorTipoProd.RowTemplate.Height = 25;
            this.grdBuscadorTipoProd.Size = new System.Drawing.Size(440, 211);
            this.grdBuscadorTipoProd.TabIndex = 14;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "idTipoProducto";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombreTipoProd";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(72, 34);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(296, 28);
            this.lblListado.TabIndex = 12;
            this.lblListado.Text = "Listado de Tipos de Productos";
            // 
            // ListaTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.panel1);
            this.Name = "ListaTipoProducto";
            this.Text = "ListaTipoProducto";
            this.Load += new System.EventHandler(this.ListaTipoProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorTipoProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private DataGridView grdBuscadorTipoProd;
        private Label lblListado;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
    }
}