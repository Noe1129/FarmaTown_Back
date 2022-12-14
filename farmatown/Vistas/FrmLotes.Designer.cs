
namespace farmatown.Vistas
{
    partial class FrmLotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotes));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.cNroPresup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "LOTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(272, 64);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(182, 29);
            this.dtpFechaHasta.TabIndex = 34;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(46, 64);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(193, 29);
            this.dtpFechaDesde.TabIndex = 33;
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFiltro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(864, 690);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(120, 33);
            this.btnEliminarFiltro.TabIndex = 32;
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrar.Location = new System.Drawing.Point(478, 61);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 35);
            this.btnFiltrar.TabIndex = 31;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNroPresup,
            this.cFecha,
            this.cCliente,
            this.cTotal,
            this.ColAcciones,
            this.btnImprimir});
            this.dgvConsultar.Location = new System.Drawing.Point(45, 98);
            this.dgvConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.RowHeadersWidth = 62;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(939, 584);
            this.dgvConsultar.TabIndex = 30;
            // 
            // cNroPresup
            // 
            this.cNroPresup.HeaderText = "Factura Nº:";
            this.cNroPresup.MinimumWidth = 8;
            this.cNroPresup.Name = "cNroPresup";
            this.cNroPresup.ReadOnly = true;
            this.cNroPresup.Width = 150;
            // 
            // cFecha
            // 
            this.cFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cFecha.FillWeight = 160F;
            this.cFecha.HeaderText = "Cliente";
            this.cFecha.MinimumWidth = 8;
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "Fecha";
            this.cCliente.MinimumWidth = 8;
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            this.cCliente.Width = 120;
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.MinimumWidth = 8;
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            this.cTotal.Width = 120;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Detalles";
            this.ColAcciones.MinimumWidth = 8;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "ver";
            this.ColAcciones.UseColumnTextForButtonValue = true;
            this.ColAcciones.Width = 150;
            // 
            // btnImprimir
            // 
            this.btnImprimir.HeaderText = "Imprimir";
            this.btnImprimir.MinimumWidth = 6;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.ToolTipText = "imprimir";
            this.btnImprimir.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::farmatown.Properties.Resources.fondoCeleste;
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.dgvConsultar);
            this.groupBox1.Controls.Add(this.btnEliminarFiltro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 734);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lote";
            // 
            // FrmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::farmatown.Properties.Resources.fondoBlanco2;
            this.ClientSize = new System.Drawing.Size(1240, 858);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLotes";
            this.Text = "Lotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroPresup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.DataGridViewButtonColumn btnImprimir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}