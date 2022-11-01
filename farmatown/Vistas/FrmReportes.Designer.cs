
namespace farmatown.Vistas
{
    partial class FrmReportes
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
            this.facturasObraSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataVistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.articulosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmatown3DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosVendidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesfrecuentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.clientes_frecuentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.clientesfrecuentesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataVistaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            
            this.farmatown3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_vendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturasObraSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVistaBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.articulosMasVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_frecuentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVistaBindingSource1)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpClientes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // facturasObraSocialBindingSource
            // 
            this.facturasObraSocialBindingSource.DataMember = "facturasObraSocial";
            this.facturasObraSocialBindingSource.DataSource = this.dataVistaBindingSource;
            // 
            // dataVistaBindingSource
            // 
            
            this.dataVistaBindingSource.Position = 0;
            
            // 
            // articulosMasVendidosBindingSource
            // 
            this.articulosMasVendidosBindingSource.DataMember = "articulosMasVendidos";
            // 
            // articulosVendidosBindingSource1
            // 
            this.articulosVendidosBindingSource1.DataMember = "articulosVendidos";
            this.articulosVendidosBindingSource1.DataSource = this.dataVistaBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImage = global::farmatown.Properties.Resources.fondoBlanco2;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "farmatown.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 4);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1285, 580);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // clientesfrecuentesBindingSource
            // 
            this.clientesfrecuentesBindingSource.DataMember = "clientes_frecuentes";
            
            // 
            // articulosVendidosBindingSource
            // 
            this.articulosVendidosBindingSource.DataMember = "articulosVendidos";
            
            // 
            // articulosVendidosTableAdapter
            // 
            
            // 
            // clientes_frecuentesBindingSource
            // 
            this.clientes_frecuentesBindingSource.DataMember = "clientes_frecuentes";
            
            // 
            // clientes_frecuentesTableAdapter
            // 
            
            // 
            // clientesfrecuentesBindingSource1
            // 
            this.clientesfrecuentesBindingSource1.DataMember = "clientes_frecuentes";
            
            // 
            // dataVistaBindingSource1
            // 
            
            this.dataVistaBindingSource1.Position = 0;
            // 
            // facturasObraSocialTableAdapter
            // 
            
            // 
            // farmatown3DataSet
            // 
           
            // 
            // farmatown3DataSetBindingSource
            // 
            
            this.farmatown3DataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpClientes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1301, 622);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1293, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas según Obra Social";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::farmatown.Properties.Resources.fondoBlanco2;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1293, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artículos más vendidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::farmatown.Properties.Resources.fondoCeleste;
            this.groupBox3.Controls.Add(this.dgvArticulos);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Location = new System.Drawing.Point(240, 91);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1111, 484);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Artículos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulo,
            this.cantidad_vendida,
            this.mes,
            this.anio});
            this.dgvArticulos.Location = new System.Drawing.Point(219, 94);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(739, 358);
            this.dgvArticulos.TabIndex = 2;
            // 
            // articulo
            // 
            this.articulo.HeaderText = "Artículo";
            this.articulo.MinimumWidth = 6;
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            this.articulo.Width = 125;
            // 
            // cantidad_vendida
            // 
            this.cantidad_vendida.HeaderText = "Cantidad Vendida";
            this.cantidad_vendida.MinimumWidth = 6;
            this.cantidad_vendida.Name = "cantidad_vendida";
            this.cantidad_vendida.ReadOnly = true;
            this.cantidad_vendida.Width = 125;
            // 
            // mes
            // 
            this.mes.HeaderText = "Mes";
            this.mes.MinimumWidth = 6;
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 125;
            // 
            // anio
            // 
            this.anio.HeaderText = "Año";
            this.anio.MinimumWidth = 6;
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Location = new System.Drawing.Point(207, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(245, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes";
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMes.Location = new System.Drawing.Point(8, 26);
            this.cboMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(224, 29);
            this.cboMes.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAceptar.Location = new System.Drawing.Point(460, 52);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 36);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "REPORTE DE ARTÍCULOS MÁS VENDIDOS";
            // 
            // tpClientes
            // 
            this.tpClientes.BackgroundImage = global::farmatown.Properties.Resources.fondoBlanco2;
            this.tpClientes.Controls.Add(this.groupBox2);
            this.tpClientes.Controls.Add(this.label2);
            this.tpClientes.Location = new System.Drawing.Point(4, 30);
            this.tpClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpClientes.Size = new System.Drawing.Size(1293, 588);
            this.tpClientes.TabIndex = 2;
            this.tpClientes.Text = "Clientes frecuentes";
            this.tpClientes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::farmatown.Properties.Resources.fondoCeleste;
            this.groupBox2.Controls.Add(this.dgvClientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(400, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(880, 482);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.ventas});
            this.dgvClientes.Location = new System.Drawing.Point(193, 25);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(519, 450);
            this.dgvClientes.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // ventas
            // 
            this.ventas.HeaderText = "Ventas";
            this.ventas.MinimumWidth = 6;
            this.ventas.Name = "ventas";
            this.ventas.ReadOnly = true;
            this.ventas.Width = 211;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "REPORTE DE CLIENTES MÁS FRECUENTES";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 622);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmReportes";
            this.Text = "FromReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasObraSocialBindingSource)).EndInit();
            
            
            ((System.ComponentModel.ISupportInitialize)(this.articulosMasVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_frecuentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesfrecuentesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVistaBindingSource1)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            this.tpClientes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource farmatown3DataSet1BindingSource;

        private System.Windows.Forms.BindingSource articulosMasVendidosBindingSource;
        
        private System.Windows.Forms.BindingSource articulosVendidosBindingSource;
  
        private System.Windows.Forms.BindingSource clientes_frecuentesBindingSource;
        private System.Windows.Forms.BindingSource clientesfrecuentesBindingSource;
  
        private System.Windows.Forms.BindingSource clientesfrecuentesBindingSource1;
        private System.Windows.Forms.BindingSource articulosVendidosBindingSource1;
        private System.Windows.Forms.BindingSource dataVistaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource farmatown3DataSetBindingSource;
       
        private System.Windows.Forms.BindingSource dataVistaBindingSource1;
        private System.Windows.Forms.BindingSource facturasObraSocialBindingSource;
       
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_vendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventas;
    }
}