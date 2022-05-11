namespace TPG3.Formularios.Funcion
{
    partial class ListaFuncion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCargarFuncion = new System.Windows.Forms.Button();
            this.btnEliminarFuncion = new System.Windows.Forms.Button();
            this.btnEditarFuncion = new System.Windows.Forms.Button();
            this.dgvFuncion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(52, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 30);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Lista de Funciones";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnCargarFuncion
            // 
            this.btnCargarFuncion.Location = new System.Drawing.Point(52, 96);
            this.btnCargarFuncion.Name = "btnCargarFuncion";
            this.btnCargarFuncion.Size = new System.Drawing.Size(143, 23);
            this.btnCargarFuncion.TabIndex = 0;
            this.btnCargarFuncion.Text = "Cargar Funcion";
            this.btnCargarFuncion.UseVisualStyleBackColor = true;
            this.btnCargarFuncion.Click += new System.EventHandler(this.btnCargarFuncion_Click);
            // 
            // btnEliminarFuncion
            // 
            this.btnEliminarFuncion.Location = new System.Drawing.Point(350, 96);
            this.btnEliminarFuncion.Name = "btnEliminarFuncion";
            this.btnEliminarFuncion.Size = new System.Drawing.Size(143, 23);
            this.btnEliminarFuncion.TabIndex = 2;
            this.btnEliminarFuncion.Text = "Eliminar Funcion";
            this.btnEliminarFuncion.UseVisualStyleBackColor = true;
            this.btnEliminarFuncion.Click += new System.EventHandler(this.btnEliminarFuncion_Click);
            // 
            // btnEditarFuncion
            // 
            this.btnEditarFuncion.Location = new System.Drawing.Point(201, 96);
            this.btnEditarFuncion.Name = "btnEditarFuncion";
            this.btnEditarFuncion.Size = new System.Drawing.Size(143, 23);
            this.btnEditarFuncion.TabIndex = 1;
            this.btnEditarFuncion.Text = "Editar Funcion";
            this.btnEditarFuncion.UseVisualStyleBackColor = true;
            this.btnEditarFuncion.Click += new System.EventHandler(this.btnEditarFuncion_Click);
            // 
            // dgvFuncion
            // 
            this.dgvFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncion.Location = new System.Drawing.Point(56, 151);
            this.dgvFuncion.Name = "dgvFuncion";
            this.dgvFuncion.RowTemplate.Height = 25;
            this.dgvFuncion.Size = new System.Drawing.Size(732, 199);
            this.dgvFuncion.TabIndex = 3;
            this.dgvFuncion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncion_CellContentClick);
            // 
            // ListaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFuncion);
            this.Controls.Add(this.btnEditarFuncion);
            this.Controls.Add(this.btnEliminarFuncion);
            this.Controls.Add(this.btnCargarFuncion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListaFuncion";
            this.Text = "ListaFuncion";
            this.Load += new System.EventHandler(this.ListaFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Button btnCargarFuncion;
        private Button btnEliminarFuncion;
        private Button btnEditarFuncion;
        private DataGridView dgvFuncion;
    }
}