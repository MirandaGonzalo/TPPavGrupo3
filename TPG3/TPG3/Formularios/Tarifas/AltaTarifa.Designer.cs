namespace TPG3.Formularios.Tarifas
{
    partial class AltaTarifa
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
            this.lblError = new System.Windows.Forms.Label();
            this.gdrActualizarTarifa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdTarifa = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescripcionTarifa = new System.Windows.Forms.TextBox();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblActualizarTarifa = new System.Windows.Forms.Label();
            this.lblRegistroTarifa = new System.Windows.Forms.Label();
            this.idTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarTarifa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(34, 15);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(43, 19);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Error";
            // 
            // gdrActualizarTarifa
            // 
            this.gdrActualizarTarifa.AllowUserToAddRows = false;
            this.gdrActualizarTarifa.AllowUserToDeleteRows = false;
            this.gdrActualizarTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrActualizarTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarifa,
            this.Descripción,
            this.Valor,
            this.Formato});
            this.gdrActualizarTarifa.Location = new System.Drawing.Point(34, 239);
            this.gdrActualizarTarifa.Name = "gdrActualizarTarifa";
            this.gdrActualizarTarifa.ReadOnly = true;
            this.gdrActualizarTarifa.RowTemplate.Height = 25;
            this.gdrActualizarTarifa.Size = new System.Drawing.Size(733, 203);
            this.gdrActualizarTarifa.TabIndex = 18;
            this.gdrActualizarTarifa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrActualizarTarifa_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdTarifa);
            this.panel1.Controls.Add(this.btnLimpiarCampos);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.txtDescripcionTarifa);
            this.panel1.Controls.Add(this.cmbFormato);
            this.panel1.Controls.Add(this.lblFormato);
            this.panel1.Location = new System.Drawing.Point(34, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 152);
            this.panel1.TabIndex = 22;
            // 
            // txtIdTarifa
            // 
            this.txtIdTarifa.Location = new System.Drawing.Point(50, 103);
            this.txtIdTarifa.Name = "txtIdTarifa";
            this.txtIdTarifa.Size = new System.Drawing.Size(29, 23);
            this.txtIdTarifa.TabIndex = 14;
            this.txtIdTarifa.Text = "-1";
            this.txtIdTarifa.Visible = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(247, 103);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(150, 28);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Location = new System.Drawing.Point(439, 103);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 28);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(571, 103);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(553, 50);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(111, 23);
            this.txtValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(553, 19);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(44, 19);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor";
            // 
            // txtDescripcionTarifa
            // 
            this.txtDescripcionTarifa.Location = new System.Drawing.Point(213, 50);
            this.txtDescripcionTarifa.Name = "txtDescripcionTarifa";
            this.txtDescripcionTarifa.Size = new System.Drawing.Size(281, 23);
            this.txtDescripcionTarifa.TabIndex = 1;
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(50, 50);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(105, 23);
            this.cmbFormato.TabIndex = 0;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFormato.Location = new System.Drawing.Point(50, 19);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(66, 19);
            this.lblFormato.TabIndex = 7;
            this.lblFormato.Text = "Formato";
            // 
            // lblActualizarTarifa
            // 
            this.lblActualizarTarifa.AutoSize = true;
            this.lblActualizarTarifa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActualizarTarifa.Location = new System.Drawing.Point(599, 208);
            this.lblActualizarTarifa.Name = "lblActualizarTarifa";
            this.lblActualizarTarifa.Size = new System.Drawing.Size(168, 28);
            this.lblActualizarTarifa.TabIndex = 21;
            this.lblActualizarTarifa.Text = "Actualizar Tarifa";
            // 
            // lblRegistroTarifa
            // 
            this.lblRegistroTarifa.AutoSize = true;
            this.lblRegistroTarifa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistroTarifa.Location = new System.Drawing.Point(572, 9);
            this.lblRegistroTarifa.Name = "lblRegistroTarifa";
            this.lblRegistroTarifa.Size = new System.Drawing.Size(195, 28);
            this.lblRegistroTarifa.TabIndex = 19;
            this.lblRegistroTarifa.Text = "Registro de  Tarifas";
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
            this.Formato.DataPropertyName = "codFormato";
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // AltaTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gdrActualizarTarifa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblActualizarTarifa);
            this.Controls.Add(this.lblRegistroTarifa);
            this.Name = "AltaTarifa";
            this.Text = "AltaTarifa";
            this.Load += new System.EventHandler(this.AltaTarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarTarifa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblError;
        private DataGridView gdrActualizarTarifa;
        private Panel panel1;
        private Button btnLimpiarCampos;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtValor;
        private Label label1;
        private Label lblValor;
        private TextBox txtDescripcionTarifa;
        private ComboBox cmbFormato;
        private Label lblFormato;
        private Label lblActualizarTarifa;
        private Label lblRegistroTarifa;
        private TextBox txtIdTarifa;
        private DataGridViewTextBoxColumn idTarifa;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Formato;
    }
}