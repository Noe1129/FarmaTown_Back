
namespace farmatown.Vistas
{
    partial class FrmNuevaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaFactura));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBObraSocial = new System.Windows.Forms.CheckBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboArticulos = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbTarjeta = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaVto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDniFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSeguridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDroga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDroga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAceptar.Location = new System.Drawing.Point(1083, 419);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 33);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImage = global::farmatown.Properties.Resources.fondoCeleste;
            this.groupBox1.Controls.Add(this.cBObraSocial);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.lblDescuento);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAgregarDetalle);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.cboArticulos);
            this.groupBox1.Controls.Add(this.dgvDetalles);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblNroFactura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 387);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1216, 473);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // cBObraSocial
            // 
            this.cBObraSocial.AutoSize = true;
            this.cBObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.cBObraSocial.Location = new System.Drawing.Point(630, 106);
            this.cBObraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.cBObraSocial.Name = "cBObraSocial";
            this.cBObraSocial.Size = new System.Drawing.Size(173, 27);
            this.cBObraSocial.TabIndex = 60;
            this.cBObraSocial.Text = "Tiene obra Social";
            this.cBObraSocial.UseVisualStyleBackColor = false;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuento.Location = new System.Drawing.Point(824, 74);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(101, 23);
            this.lblDescuento.TabIndex = 59;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(826, 107);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(183, 29);
            this.txtDescuento.TabIndex = 58;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(487, 104);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(106, 29);
            this.nudCantidad.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(31, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 23);
            this.label10.TabIndex = 56;
            this.label10.Text = "Artículo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(486, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "Cantidad:";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(1074, 103);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(111, 33);
            this.btnAgregarDetalle.TabIndex = 53;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1098, 393);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 24);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "Total $ 0";
            // 
            // cboArticulos
            // 
            this.cboArticulos.FormattingEnabled = true;
            this.cboArticulos.Location = new System.Drawing.Point(32, 103);
            this.cboArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.cboArticulos.Name = "cboArticulos";
            this.cboArticulos.Size = new System.Drawing.Size(413, 29);
            this.cboArticulos.TabIndex = 49;
            this.cboArticulos.SelectedIndexChanged += new System.EventHandler(this.cboArticulos_SelectedIndexChanged);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ColArticulo,
            this.ColTipoArt,
            this.idDroga,
            this.nombreDroga,
            this.idLaboratorio,
            this.nombreLab,
            this.ColPrecio,
            this.ColCantidad,
            this.colDescuento,
            this.ColTotal,
            this.ColBorrar});
            this.dgvDetalles.Location = new System.Drawing.Point(33, 146);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(1152, 237);
            this.dgvDetalles.TabIndex = 45;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(991, 42);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 23);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblNroFactura.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(91, 30);
            this.lblNroFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(110, 24);
            this.lblNroFactura.TabIndex = 32;
            this.lblNroFactura.Text = "Factura Nº: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackgroundImage = global::farmatown.Properties.Resources.fondoCeleste;
            this.groupBox2.Controls.Add(this.gbTarjeta);
            this.groupBox2.Controls.Add(this.chkTarjeta);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.lblDni);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(65, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(693, 288);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // gbTarjeta
            // 
            this.gbTarjeta.BackgroundImage = global::farmatown.Properties.Resources.fondoColor;
            this.gbTarjeta.Controls.Add(this.label6);
            this.gbTarjeta.Controls.Add(this.dtpFechaVto);
            this.gbTarjeta.Controls.Add(this.label5);
            this.gbTarjeta.Controls.Add(this.txtCodigoSeguridad);
            this.gbTarjeta.Controls.Add(this.label7);
            this.gbTarjeta.Controls.Add(this.txtNroTarjeta);
            this.gbTarjeta.Location = new System.Drawing.Point(21, 157);
            this.gbTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.gbTarjeta.Name = "gbTarjeta";
            this.gbTarjeta.Padding = new System.Windows.Forms.Padding(4);
            this.gbTarjeta.Size = new System.Drawing.Size(650, 124);
            this.gbTarjeta.TabIndex = 78;
            this.gbTarjeta.TabStop = false;
            this.gbTarjeta.Text = "Tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(23, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 46);
            this.label6.TabIndex = 72;
            this.label6.Text = "Código de \r\nSeguridad:";
            // 
            // dtpFechaVto
            // 
            this.dtpFechaVto.Location = new System.Drawing.Point(373, 60);
            this.dtpFechaVto.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaVto.Name = "dtpFechaVto";
            this.dtpFechaVto.Size = new System.Drawing.Size(260, 29);
            this.dtpFechaVto.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(371, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 71;
            this.label5.Text = "Fecha de vto:";
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(139, 81);
            this.txtCodigoSeguridad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(176, 29);
            this.txtCodigoSeguridad.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(10, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 73;
            this.label7.Text = "N° de Tarjeta:";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(139, 30);
            this.txtNroTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(176, 29);
            this.txtNroTarjeta.TabIndex = 74;
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.chkTarjeta.Location = new System.Drawing.Point(457, 122);
            this.chkTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(168, 27);
            this.chkTarjeta.TabIndex = 70;
            this.chkTarjeta.Text = "Pago con Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = false;
            this.chkTarjeta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(457, 29);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 29);
            this.txtTelefono.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(362, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Teléfono:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(160, 30);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(176, 29);
            this.txtDni.TabIndex = 67;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Location = new System.Drawing.Point(106, 32);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(46, 23);
            this.lblDni.TabIndex = 66;
            this.lblDni.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 83);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 29);
            this.txtNombre.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(70, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(365, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(457, 80);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 29);
            this.txtApellido.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "DNI:";
            // 
            // txtDniFiltro
            // 
            this.txtDniFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDniFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniFiltro.Location = new System.Drawing.Point(818, 92);
            this.txtDniFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniFiltro.Name = "txtDniFiltro";
            this.txtDniFiltro.Size = new System.Drawing.Size(329, 29);
            this.txtDniFiltro.TabIndex = 38;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrar.Location = new System.Drawing.Point(1158, 92);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(123, 29);
            this.btnFiltrar.TabIndex = 37;
            this.btnFiltrar.Text = "Buscar cliente";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConsultar.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cApellido,
            this.cDni,
            this.ColTelefono,
            this.NroTarjeta,
            this.CodigoSeguridad,
            this.FechaVenc});
            this.dgvConsultar.Location = new System.Drawing.Point(777, 128);
            this.dgvConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.RowHeadersWidth = 62;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(504, 169);
            this.dgvConsultar.TabIndex = 36;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick);
            // 
            // cNombre
            // 
            this.cNombre.FillWeight = 160F;
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 8;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 125;
            // 
            // cApellido
            // 
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.MinimumWidth = 8;
            this.cApellido.Name = "cApellido";
            this.cApellido.ReadOnly = true;
            this.cApellido.Width = 125;
            // 
            // cDni
            // 
            this.cDni.HeaderText = "DNI";
            this.cDni.MinimumWidth = 8;
            this.cDni.Name = "cDni";
            this.cDni.ReadOnly = true;
            this.cDni.Width = 125;
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.MinimumWidth = 6;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 125;
            // 
            // NroTarjeta
            // 
            this.NroTarjeta.HeaderText = "Column1";
            this.NroTarjeta.MinimumWidth = 6;
            this.NroTarjeta.Name = "NroTarjeta";
            this.NroTarjeta.ReadOnly = true;
            this.NroTarjeta.Visible = false;
            this.NroTarjeta.Width = 125;
            // 
            // CodigoSeguridad
            // 
            this.CodigoSeguridad.HeaderText = "Column1";
            this.CodigoSeguridad.MinimumWidth = 6;
            this.CodigoSeguridad.Name = "CodigoSeguridad";
            this.CodigoSeguridad.ReadOnly = true;
            this.CodigoSeguridad.Visible = false;
            this.CodigoSeguridad.Width = 125;
            // 
            // FechaVenc
            // 
            this.FechaVenc.HeaderText = "Column1";
            this.FechaVenc.MinimumWidth = 6;
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.ReadOnly = true;
            this.FechaVenc.Visible = false;
            this.FechaVenc.Width = 125;
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFiltro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(1168, 308);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(113, 33);
            this.btnEliminarFiltro.TabIndex = 40;
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 90;
            // 
            // ColArticulo
            // 
            this.ColArticulo.HeaderText = "Articulo";
            this.ColArticulo.MinimumWidth = 6;
            this.ColArticulo.Name = "ColArticulo";
            this.ColArticulo.ReadOnly = true;
            this.ColArticulo.Width = 200;
            // 
            // ColTipoArt
            // 
            this.ColTipoArt.HeaderText = "Tipo de articulo";
            this.ColTipoArt.MinimumWidth = 6;
            this.ColTipoArt.Name = "ColTipoArt";
            this.ColTipoArt.ReadOnly = true;
            this.ColTipoArt.Width = 150;
            // 
            // idDroga
            // 
            this.idDroga.HeaderText = "idDroga";
            this.idDroga.MinimumWidth = 6;
            this.idDroga.Name = "idDroga";
            this.idDroga.ReadOnly = true;
            this.idDroga.Visible = false;
            this.idDroga.Width = 125;
            // 
            // nombreDroga
            // 
            this.nombreDroga.HeaderText = "Droga";
            this.nombreDroga.MinimumWidth = 6;
            this.nombreDroga.Name = "nombreDroga";
            this.nombreDroga.ReadOnly = true;
            this.nombreDroga.Width = 125;
            // 
            // idLaboratorio
            // 
            this.idLaboratorio.HeaderText = "idLab";
            this.idLaboratorio.MinimumWidth = 6;
            this.idLaboratorio.Name = "idLaboratorio";
            this.idLaboratorio.ReadOnly = true;
            this.idLaboratorio.Visible = false;
            this.idLaboratorio.Width = 125;
            // 
            // nombreLab
            // 
            this.nombreLab.HeaderText = "Laboratorio";
            this.nombreLab.MinimumWidth = 6;
            this.nombreLab.Name = "nombreLab";
            this.nombreLab.ReadOnly = true;
            this.nombreLab.Width = 215;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 70;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 83;
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.MinimumWidth = 6;
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            this.colDescuento.Width = 105;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.MinimumWidth = 6;
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.Width = 85;
            // 
            // ColBorrar
            // 
            this.ColBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBorrar.HeaderText = "";
            this.ColBorrar.MinimumWidth = 6;
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.ReadOnly = true;
            this.ColBorrar.Text = "Quitar";
            this.ColBorrar.UseColumnTextForButtonValue = true;
            // 
            // FrmNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::farmatown.Properties.Resources.fondoBlanco2;
            this.ClientSize = new System.Drawing.Size(1348, 952);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDniFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvConsultar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNuevaFactura";
            this.Text = "Nueva Factura";
            this.Load += new System.EventHandler(this.FrmNuevaFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbTarjeta.ResumeLayout(false);
            this.gbTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboArticulos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.CheckBox cBObraSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.DateTimePicker dtpFechaVto;
        private System.Windows.Forms.TextBox txtCodigoSeguridad;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSeguridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDroga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDroga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
    }
}