namespace TPG3.CapaLogicaNegocio
{
    partial class TarifaService
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
            this.lblSeleccionFuncion = new System.Windows.Forms.Label();
            this.gdrSeleccionTarifa = new System.Windows.Forms.DataGridView();
            this.IdTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.gridSeleccionPromo = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.grdTarifasSel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPromoSel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblPrecioFinalDescuento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAsientosDis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMedioPagoSel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedioPago = new System.Windows.Forms.DataGridView();
            this.codMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSeleccionTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeleccionPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifasSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromoSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPagoSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionFuncion
            // 
            this.lblSeleccionFuncion.AutoSize = true;
            this.lblSeleccionFuncion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionFuncion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccionFuncion.Location = new System.Drawing.Point(12, 19);
            this.lblSeleccionFuncion.Name = "lblSeleccionFuncion";
            this.lblSeleccionFuncion.Size = new System.Drawing.Size(199, 28);
            this.lblSeleccionFuncion.TabIndex = 0;
            this.lblSeleccionFuncion.Text = "Selección de Tarifas";
            // 
            // gdrSeleccionTarifa
            // 
            this.gdrSeleccionTarifa.AllowUserToAddRows = false;
            this.gdrSeleccionTarifa.AllowUserToDeleteRows = false;
            this.gdrSeleccionTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSeleccionTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTarifa,
            this.Descripcion,
            this.Formato,
            this.Valor});
            this.gdrSeleccionTarifa.Location = new System.Drawing.Point(12, 59);
            this.gdrSeleccionTarifa.Name = "gdrSeleccionTarifa";
            this.gdrSeleccionTarifa.RowTemplate.Height = 25;
            this.gdrSeleccionTarifa.Size = new System.Drawing.Size(918, 112);
            this.gdrSeleccionTarifa.TabIndex = 40;
            this.gdrSeleccionTarifa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrSeleccionTarifa_CellClick);
            this.gdrSeleccionTarifa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrSeleccionTarifa_CellContentClick);
            // 
            // IdTarifa
            // 
            this.IdTarifa.DataPropertyName = "idTarifa";
            this.IdTarifa.HeaderText = "IdTarifa";
            this.IdTarifa.Name = "IdTarifa";
            this.IdTarifa.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Formato
            // 
            this.Formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Formato.DataPropertyName = "formato";
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.Location = new System.Drawing.Point(12, 730);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 36);
            this.btnVolver.TabIndex = 43;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinuar.Location = new System.Drawing.Point(749, 730);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(107, 36);
            this.btnContinuar.TabIndex = 42;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // gridSeleccionPromo
            // 
            this.gridSeleccionPromo.AllowUserToAddRows = false;
            this.gridSeleccionPromo.AllowUserToDeleteRows = false;
            this.gridSeleccionPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeleccionPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gridSeleccionPromo.Location = new System.Drawing.Point(12, 539);
            this.gridSeleccionPromo.Name = "gridSeleccionPromo";
            this.gridSeleccionPromo.ReadOnly = true;
            this.gridSeleccionPromo.RowTemplate.Height = 25;
            this.gridSeleccionPromo.Size = new System.Drawing.Size(451, 112);
            this.gridSeleccionPromo.TabIndex = 46;
            this.gridSeleccionPromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSeleccionPromo_CellClick);
            this.gridSeleccionPromo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSeleccionPromo_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(12, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Selección de Promoción";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // grdTarifasSel
            // 
            this.grdTarifasSel.AllowUserToAddRows = false;
            this.grdTarifasSel.AllowUserToDeleteRows = false;
            this.grdTarifasSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarifasSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn12,
            this.cantidad});
            this.grdTarifasSel.Location = new System.Drawing.Point(12, 222);
            this.grdTarifasSel.Name = "grdTarifasSel";
            this.grdTarifasSel.RowTemplate.Height = 25;
            this.grdTarifasSel.Size = new System.Drawing.Size(918, 112);
            this.grdTarifasSel.TabIndex = 41;
            this.grdTarifasSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTarifasSel_CellContentClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "idTarifa";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdTarifa";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "formato";
            this.dataGridViewTextBoxColumn13.HeaderText = "Formato";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn12.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarifas Seleccionadas";
            // 
            // gridPromoSel
            // 
            this.gridPromoSel.AllowUserToAddRows = false;
            this.gridPromoSel.AllowUserToDeleteRows = false;
            this.gridPromoSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPromoSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gridPromoSel.Location = new System.Drawing.Point(479, 539);
            this.gridPromoSel.Name = "gridPromoSel";
            this.gridPromoSel.ReadOnly = true;
            this.gridPromoSel.RowTemplate.Height = 25;
            this.gridPromoSel.Size = new System.Drawing.Size(451, 112);
            this.gridPromoSel.TabIndex = 50;
            this.gridPromoSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPromoSel_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Final:";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecioFinal.Location = new System.Drawing.Point(162, 655);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(24, 28);
            this.lblPrecioFinal.TabIndex = 51;
            this.lblPrecioFinal.Text = "0";
            // 
            // lblPrecioFinalDescuento
            // 
            this.lblPrecioFinalDescuento.AutoSize = true;
            this.lblPrecioFinalDescuento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioFinalDescuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecioFinalDescuento.Location = new System.Drawing.Point(523, 654);
            this.lblPrecioFinalDescuento.Name = "lblPrecioFinalDescuento";
            this.lblPrecioFinalDescuento.Size = new System.Drawing.Size(24, 28);
            this.lblPrecioFinalDescuento.TabIndex = 53;
            this.lblPrecioFinalDescuento.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(221, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Precio Final con Promoción:";
            // 
            // lblAsientosDis
            // 
            this.lblAsientosDis.AutoSize = true;
            this.lblAsientosDis.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsientosDis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAsientosDis.Location = new System.Drawing.Point(12, 693);
            this.lblAsientosDis.Name = "lblAsientosDis";
            this.lblAsientosDis.Size = new System.Drawing.Size(23, 28);
            this.lblAsientosDis.TabIndex = 54;
            this.lblAsientosDis.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(479, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Medio de Pago seleccionado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "Lista de Medios de Pagos";
            // 
            // dgvMedioPagoSel
            // 
            this.dgvMedioPagoSel.AllowUserToAddRows = false;
            this.dgvMedioPagoSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedioPagoSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvMedioPagoSel.Location = new System.Drawing.Point(482, 372);
            this.dgvMedioPagoSel.Name = "dgvMedioPagoSel";
            this.dgvMedioPagoSel.RowTemplate.Height = 25;
            this.dgvMedioPagoSel.Size = new System.Drawing.Size(448, 66);
            this.dgvMedioPagoSel.TabIndex = 56;
            this.dgvMedioPagoSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedioPagoSel_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codMedioPago";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nombreTarjeta";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tarjeta";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dgvMedioPago
            // 
            this.dgvMedioPago.AllowUserToAddRows = false;
            this.dgvMedioPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedioPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMedioPago,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.Tarjeta,
            this.dataGridViewTextBoxColumn16});
            this.dgvMedioPago.Location = new System.Drawing.Point(9, 372);
            this.dgvMedioPago.Name = "dgvMedioPago";
            this.dgvMedioPago.RowTemplate.Height = 25;
            this.dgvMedioPago.Size = new System.Drawing.Size(448, 123);
            this.dgvMedioPago.TabIndex = 55;
            this.dgvMedioPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedioPago_CellContentClick);
            // 
            // codMedioPago
            // 
            this.codMedioPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codMedioPago.DataPropertyName = "Codigo";
            this.codMedioPago.HeaderText = "Codigo";
            this.codMedioPago.Name = "codMedioPago";
            this.codMedioPago.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn14.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn15.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // Tarjeta
            // 
            this.Tarjeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarjeta.DataPropertyName = "Tarjeta";
            this.Tarjeta.HeaderText = "Tarjeta";
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Nombre Tarjeta";
            this.dataGridViewTextBoxColumn16.HeaderText = "Tarjeta";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // TarifaService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1004, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeleccionFuncion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMedioPagoSel);
            this.Controls.Add(this.dgvMedioPago);
            this.Controls.Add(this.lblAsientosDis);
            this.Controls.Add(this.lblPrecioFinalDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridPromoSel);
            this.Controls.Add(this.grdTarifasSel);
            this.Controls.Add(this.gdrSeleccionTarifa);
            this.Controls.Add(this.gridSeleccionPromo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnContinuar);
            this.Name = "TarifaService";
            this.Text = "TarifaService";
            this.Load += new System.EventHandler(this.TarifaService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrSeleccionTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeleccionPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifasSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromoSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPagoSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblSeleccionFuncion;
        private DataGridView gdrSeleccionTarifa;
        private Button btnVolver;
        private Button btnContinuar;
        private DataGridView gridSeleccionPromo;
        private Label label6;
        private DataGridView grdTarifasSel;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridView gridPromoSel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Label label2;
        private Label lblPrecioFinal;
        private Label lblPrecioFinalDescuento;
        private Label label4;
        private DataGridViewTextBoxColumn IdTarifa;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewTextBoxColumn Valor;
        private Label lblAsientosDis;
        private Label label3;
        private Label label5;
        private DataGridView dgvMedioPagoSel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridView dgvMedioPago;
        private DataGridViewTextBoxColumn codMedioPago;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn Tarjeta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}