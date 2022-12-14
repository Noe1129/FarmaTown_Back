
namespace farmatown.Vistas
{
    partial class FrmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDroga = new System.Windows.Forms.TextBox();
            this.btnFiltrarDroga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrarNombre = new System.Windows.Forms.Button();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdTipoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDroga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDroga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.cboDroga = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoArticulo = new System.Windows.Forms.ComboBox();
            this.btnCrearArticulo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(812, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "ARTÍCULOS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::farmatown.Properties.Resources.fondoCeleste;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDroga);
            this.groupBox1.Controls.Add(this.btnFiltrarDroga);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.btnEliminarFiltro);
            this.groupBox1.Controls.Add(this.btnFiltrarNombre);
            this.groupBox1.Controls.Add(this.dgvConsultar);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(167, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1405, 486);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(737, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "Droga:";
            // 
            // txtDroga
            // 
            this.txtDroga.Location = new System.Drawing.Point(811, 32);
            this.txtDroga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDroga.Name = "txtDroga";
            this.txtDroga.Size = new System.Drawing.Size(260, 29);
            this.txtDroga.TabIndex = 51;
            // 
            // btnFiltrarDroga
            // 
            this.btnFiltrarDroga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarDroga.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarDroga.Location = new System.Drawing.Point(1095, 25);
            this.btnFiltrarDroga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrarDroga.Name = "btnFiltrarDroga";
            this.btnFiltrarDroga.Size = new System.Drawing.Size(149, 38);
            this.btnFiltrarDroga.TabIndex = 50;
            this.btnFiltrarDroga.Text = "Filtrar por droga";
            this.btnFiltrarDroga.UseVisualStyleBackColor = true;
            this.btnFiltrarDroga.Click += new System.EventHandler(this.btnFiltrarDroga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Artículo";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(112, 32);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(260, 29);
            this.txtProducto.TabIndex = 48;
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFiltro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(1224, 380);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(149, 42);
            this.btnEliminarFiltro.TabIndex = 47;
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click_1);
            // 
            // btnFiltrarNombre
            // 
            this.btnFiltrarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarNombre.Location = new System.Drawing.Point(392, 25);
            this.btnFiltrarNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrarNombre.Name = "btnFiltrarNombre";
            this.btnFiltrarNombre.Size = new System.Drawing.Size(149, 38);
            this.btnFiltrarNombre.TabIndex = 46;
            this.btnFiltrarNombre.Text = "Filtrar por nombre";
            this.btnFiltrarNombre.UseVisualStyleBackColor = true;
            this.btnFiltrarNombre.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColProd,
            this.cIdTipoArticulo,
            this.ColTipoArt,
            this.idDroga,
            this.nombreDroga,
            this.idLab,
            this.nomLab,
            this.ColPrecio,
            this.ColStock,
            this.ColModificar});
            this.dgvConsultar.Location = new System.Drawing.Point(28, 78);
            this.dgvConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.RowHeadersWidth = 62;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(1345, 270);
            this.dgvConsultar.TabIndex = 45;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 150;
            // 
            // ColProd
            // 
            this.ColProd.HeaderText = "Artículo";
            this.ColProd.MinimumWidth = 8;
            this.ColProd.Name = "ColProd";
            this.ColProd.ReadOnly = true;
            this.ColProd.Width = 210;
            // 
            // cIdTipoArticulo
            // 
            this.cIdTipoArticulo.HeaderText = "IdTipoArticulo";
            this.cIdTipoArticulo.MinimumWidth = 6;
            this.cIdTipoArticulo.Name = "cIdTipoArticulo";
            this.cIdTipoArticulo.ReadOnly = true;
            this.cIdTipoArticulo.Visible = false;
            this.cIdTipoArticulo.Width = 120;
            // 
            // ColTipoArt
            // 
            this.ColTipoArt.HeaderText = "Tipo de artículo";
            this.ColTipoArt.MinimumWidth = 6;
            this.ColTipoArt.Name = "ColTipoArt";
            this.ColTipoArt.ReadOnly = true;
            this.ColTipoArt.Width = 120;
            // 
            // idDroga
            // 
            this.idDroga.HeaderText = "id droga";
            this.idDroga.MinimumWidth = 6;
            this.idDroga.Name = "idDroga";
            this.idDroga.ReadOnly = true;
            this.idDroga.Visible = false;
            this.idDroga.Width = 105;
            // 
            // nombreDroga
            // 
            this.nombreDroga.HeaderText = "Droga";
            this.nombreDroga.MinimumWidth = 6;
            this.nombreDroga.Name = "nombreDroga";
            this.nombreDroga.ReadOnly = true;
            this.nombreDroga.Width = 125;
            // 
            // idLab
            // 
            this.idLab.HeaderText = "id laboratorio";
            this.idLab.MinimumWidth = 6;
            this.idLab.Name = "idLab";
            this.idLab.ReadOnly = true;
            this.idLab.Visible = false;
            this.idLab.Width = 125;
            // 
            // nomLab
            // 
            this.nomLab.HeaderText = "Laboratorio";
            this.nomLab.MinimumWidth = 6;
            this.nomLab.Name = "nomLab";
            this.nomLab.ReadOnly = true;
            this.nomLab.Width = 250;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 8;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 105;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 6;
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            this.ColStock.Width = 90;
            // 
            // ColModificar
            // 
            this.ColModificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColModificar.HeaderText = "Modificar";
            this.ColModificar.MinimumWidth = 6;
            this.ColModificar.Name = "ColModificar";
            this.ColModificar.ReadOnly = true;
            this.ColModificar.Text = "Modificar";
            this.ColModificar.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.BackgroundImage = global::farmatown.Properties.Resources.fondoCeleste;
            this.groupBox2.Controls.Add(this.cboLaboratorio);
            this.groupBox2.Controls.Add(this.cboDroga);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtStockInicial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboTipoArticulo);
            this.groupBox2.Controls.Add(this.btnCrearArticulo);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(501, 581);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(779, 364);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo artículo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Location = new System.Drawing.Point(325, 212);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(263, 29);
            this.cboLaboratorio.TabIndex = 12;
            // 
            // cboDroga
            // 
            this.cboDroga.FormattingEnabled = true;
            this.cboDroga.Location = new System.Drawing.Point(325, 172);
            this.cboDroga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDroga.Name = "cboDroga";
            this.cboDroga.Size = new System.Drawing.Size(263, 29);
            this.cboDroga.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(248, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Droga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(204, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Laboratorio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(325, 89);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(263, 29);
            this.txtPrecio.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(148, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio por unidad: ";
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(325, 250);
            this.txtStockInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(263, 29);
            this.txtStockInicial.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(196, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock inicial: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(167, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de artículo: ";
            // 
            // cboTipoArticulo
            // 
            this.cboTipoArticulo.FormattingEnabled = true;
            this.cboTipoArticulo.Location = new System.Drawing.Point(325, 129);
            this.cboTipoArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoArticulo.Name = "cboTipoArticulo";
            this.cboTipoArticulo.Size = new System.Drawing.Size(263, 29);
            this.cboTipoArticulo.TabIndex = 3;
            // 
            // btnCrearArticulo
            // 
            this.btnCrearArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearArticulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCrearArticulo.Location = new System.Drawing.Point(456, 300);
            this.btnCrearArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearArticulo.Name = "btnCrearArticulo";
            this.btnCrearArticulo.Size = new System.Drawing.Size(133, 37);
            this.btnCrearArticulo.TabIndex = 2;
            this.btnCrearArticulo.Text = "Crear articulo";
            this.btnCrearArticulo.UseVisualStyleBackColor = false;
            this.btnCrearArticulo.Click += new System.EventHandler(this.btnCrearArticulo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(325, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(225, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre: ";
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::farmatown.Properties.Resources.fondoBlanco2;
            this.ClientSize = new System.Drawing.Size(1445, 976);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(504, 154);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmArticulos";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.Button btnFiltrarNombre;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoArticulo;
        private System.Windows.Forms.Button btnCrearArticulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLaboratorio;
        private System.Windows.Forms.ComboBox cboDroga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDroga;
        private System.Windows.Forms.Button btnFiltrarDroga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdTipoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDroga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDroga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewButtonColumn ColModificar;
    }
}