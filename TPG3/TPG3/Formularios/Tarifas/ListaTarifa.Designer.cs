namespace TPG3.Formularios.Tarifas
{
    partial class ListaTarifa
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
            this.lblListaTarifa = new System.Windows.Forms.Label();
            this.pnlListadoProducto = new System.Windows.Forms.Panel();
            this.gdrListadoTarifa = new System.Windows.Forms.DataGridView();
            this.txtBuscadorDescripcion = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBuscadorFormato = new System.Windows.Forms.TextBox();
            this.lblBuscadorFormato = new System.Windows.Forms.Label();
            this.lblBuscadorDescripcion = new System.Windows.Forms.Label();
            this.btnRegistrarTarifa = new System.Windows.Forms.Button();
            this.idTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlListadoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrListadoTarifa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaTarifa
            // 
            this.lblListaTarifa.AutoSize = true;
            this.lblListaTarifa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaTarifa.Location = new System.Drawing.Point(589, 62);
            this.lblListaTarifa.Name = "lblListaTarifa";
            this.lblListaTarifa.Size = new System.Drawing.Size(178, 28);
            this.lblListaTarifa.TabIndex = 21;
            this.lblListaTarifa.Text = "Listado de Tarifas";
            // 
            // pnlListadoProducto
            // 
            this.pnlListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListadoProducto.Controls.Add(this.gdrListadoTarifa);
            this.pnlListadoProducto.Controls.Add(this.txtBuscadorDescripcion);
            this.pnlListadoProducto.Controls.Add(this.flowLayoutPanel1);
            this.pnlListadoProducto.Controls.Add(this.txtBuscadorFormato);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorFormato);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorDescripcion);
            this.pnlListadoProducto.Location = new System.Drawing.Point(33, 96);
            this.pnlListadoProducto.Name = "pnlListadoProducto";
            this.pnlListadoProducto.Size = new System.Drawing.Size(734, 332);
            this.pnlListadoProducto.TabIndex = 20;
            // 
            // gdrListadoTarifa
            // 
            this.gdrListadoTarifa.AllowUserToAddRows = false;
            this.gdrListadoTarifa.AllowUserToDeleteRows = false;
            this.gdrListadoTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrListadoTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarifa,
            this.Descripción,
            this.Valor,
            this.Formato});
            this.gdrListadoTarifa.Location = new System.Drawing.Point(18, 105);
            this.gdrListadoTarifa.Name = "gdrListadoTarifa";
            this.gdrListadoTarifa.ReadOnly = true;
            this.gdrListadoTarifa.RowTemplate.Height = 25;
            this.gdrListadoTarifa.Size = new System.Drawing.Size(692, 210);
            this.gdrListadoTarifa.TabIndex = 19;
            // 
            // txtBuscadorDescripcion
            // 
            this.txtBuscadorDescripcion.Location = new System.Drawing.Point(18, 59);
            this.txtBuscadorDescripcion.Name = "txtBuscadorDescripcion";
            this.txtBuscadorDescripcion.Size = new System.Drawing.Size(225, 23);
            this.txtBuscadorDescripcion.TabIndex = 15;
            this.txtBuscadorDescripcion.TextChanged += new System.EventHandler(this.txtBuscadorDescripcion_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // txtBuscadorFormato
            // 
            this.txtBuscadorFormato.Location = new System.Drawing.Point(300, 59);
            this.txtBuscadorFormato.Name = "txtBuscadorFormato";
            this.txtBuscadorFormato.Size = new System.Drawing.Size(225, 23);
            this.txtBuscadorFormato.TabIndex = 11;
            this.txtBuscadorFormato.TextChanged += new System.EventHandler(this.txtBuscadorFormato_TextChanged);
            // 
            // lblBuscadorFormato
            // 
            this.lblBuscadorFormato.AutoSize = true;
            this.lblBuscadorFormato.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorFormato.Location = new System.Drawing.Point(300, 24);
            this.lblBuscadorFormato.Name = "lblBuscadorFormato";
            this.lblBuscadorFormato.Size = new System.Drawing.Size(132, 19);
            this.lblBuscadorFormato.TabIndex = 9;
            this.lblBuscadorFormato.Text = "Buscador Formato";
            // 
            // lblBuscadorDescripcion
            // 
            this.lblBuscadorDescripcion.AutoSize = true;
            this.lblBuscadorDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorDescripcion.Location = new System.Drawing.Point(18, 24);
            this.lblBuscadorDescripcion.Name = "lblBuscadorDescripcion";
            this.lblBuscadorDescripcion.Size = new System.Drawing.Size(153, 19);
            this.lblBuscadorDescripcion.TabIndex = 8;
            this.lblBuscadorDescripcion.Text = "Buscador Descripción";
            // 
            // btnRegistrarTarifa
            // 
            this.btnRegistrarTarifa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarTarifa.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTarifa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarTarifa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarTarifa.Location = new System.Drawing.Point(33, 22);
            this.btnRegistrarTarifa.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarTarifa.Name = "btnRegistrarTarifa";
            this.btnRegistrarTarifa.Size = new System.Drawing.Size(308, 47);
            this.btnRegistrarTarifa.TabIndex = 19;
            this.btnRegistrarTarifa.Text = "Registrar / Actualizar Tarifa";
            this.btnRegistrarTarifa.UseVisualStyleBackColor = false;
            this.btnRegistrarTarifa.Click += new System.EventHandler(this.btnRegistrarTarifa_Click);
            // 
            // idTarifa
            // 
            this.idTarifa.DataPropertyName = "idTarifa";
            this.idTarifa.HeaderText = "idTarifa";
            this.idTarifa.Name = "idTarifa";
            this.idTarifa.ReadOnly = true;
            this.idTarifa.Visible = false;
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripción.DataPropertyName = "descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Formato.DataPropertyName = "Formato.descripcion";
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // ListaTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListaTarifa);
            this.Controls.Add(this.pnlListadoProducto);
            this.Controls.Add(this.btnRegistrarTarifa);
            this.Name = "ListaTarifa";
            this.Text = "ListaTarifa";
            this.Load += new System.EventHandler(this.ListaTarifa_Load);
            this.pnlListadoProducto.ResumeLayout(false);
            this.pnlListadoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrListadoTarifa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblListaTarifa;
        private Panel pnlListadoProducto;
        private TextBox txtBuscadorDescripcion;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtBuscadorFormato;
        private Label lblBuscadorFormato;
        private Label lblBuscadorDescripcion;
        private Button btnRegistrarTarifa;
        private DataGridView gdrListadoTarifa;
        private DataGridViewTextBoxColumn idTarifa;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Formato;
    }
}