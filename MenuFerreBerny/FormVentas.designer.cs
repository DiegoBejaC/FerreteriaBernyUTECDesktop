
namespace MenuFerreBerny
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.gbFormDetalleC2 = new System.Windows.Forms.GroupBox();
            this.cmbProd2 = new System.Windows.Forms.ComboBox();
            this.cmbAlm2 = new System.Windows.Forms.ComboBox();
            this.txtPreC2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEliminarDC2 = new System.Windows.Forms.Button();
            this.btnGuardarDC2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbFormCompras2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaCompra2 = new System.Windows.Forms.DateTimePicker();
            this.lblSumasC2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarCompra2 = new System.Windows.Forms.Button();
            this.txtDocumento2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContCompra2 = new System.Windows.Forms.Button();
            this.btnRegCompra2 = new System.Windows.Forms.Button();
            this.btnFinCompra2 = new System.Windows.Forms.Button();
            this.gbDetalleC2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleC2 = new System.Windows.Forms.DataGridView();
            this.gbCompras2 = new System.Windows.Forms.GroupBox();
            this.dgvCompras2 = new System.Windows.Forms.DataGridView();
            this.txtCantC2 = new System.Windows.Forms.NumericUpDown();
            this.gbFormDetalleC2.SuspendLayout();
            this.gbFormCompras2.SuspendLayout();
            this.gbDetalleC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleC2)).BeginInit();
            this.gbCompras2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantC2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFormDetalleC2
            // 
            this.gbFormDetalleC2.BackColor = System.Drawing.Color.LightYellow;
            this.gbFormDetalleC2.Controls.Add(this.txtCantC2);
            this.gbFormDetalleC2.Controls.Add(this.cmbProd2);
            this.gbFormDetalleC2.Controls.Add(this.cmbAlm2);
            this.gbFormDetalleC2.Controls.Add(this.txtPreC2);
            this.gbFormDetalleC2.Controls.Add(this.label11);
            this.gbFormDetalleC2.Controls.Add(this.btnEliminarDC2);
            this.gbFormDetalleC2.Controls.Add(this.btnGuardarDC2);
            this.gbFormDetalleC2.Controls.Add(this.label10);
            this.gbFormDetalleC2.Controls.Add(this.label9);
            this.gbFormDetalleC2.Controls.Add(this.label8);
            this.gbFormDetalleC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormDetalleC2.Location = new System.Drawing.Point(955, 316);
            this.gbFormDetalleC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormDetalleC2.Name = "gbFormDetalleC2";
            this.gbFormDetalleC2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormDetalleC2.Size = new System.Drawing.Size(474, 272);
            this.gbFormDetalleC2.TabIndex = 11;
            this.gbFormDetalleC2.TabStop = false;
            this.gbFormDetalleC2.Text = "REGISTRAR DETALLE";
            // 
            // cmbProd2
            // 
            this.cmbProd2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProd2.FormattingEnabled = true;
            this.cmbProd2.Location = new System.Drawing.Point(172, 48);
            this.cmbProd2.Name = "cmbProd2";
            this.cmbProd2.Size = new System.Drawing.Size(255, 25);
            this.cmbProd2.TabIndex = 26;
            this.cmbProd2.SelectedValueChanged += new System.EventHandler(this.cmbProd2_SelectedValueChanged);
            // 
            // cmbAlm2
            // 
            this.cmbAlm2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlm2.FormattingEnabled = true;
            this.cmbAlm2.Location = new System.Drawing.Point(172, 87);
            this.cmbAlm2.Name = "cmbAlm2";
            this.cmbAlm2.Size = new System.Drawing.Size(255, 25);
            this.cmbAlm2.TabIndex = 25;
            // 
            // txtPreC2
            // 
            this.txtPreC2.AutoSize = true;
            this.txtPreC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreC2.Location = new System.Drawing.Point(171, 167);
            this.txtPreC2.Name = "txtPreC2";
            this.txtPreC2.Size = new System.Drawing.Size(19, 20);
            this.txtPreC2.TabIndex = 24;
            this.txtPreC2.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio:";
            // 
            // btnEliminarDC2
            // 
            this.btnEliminarDC2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarDC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDC2.Location = new System.Drawing.Point(277, 212);
            this.btnEliminarDC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarDC2.Name = "btnEliminarDC2";
            this.btnEliminarDC2.Size = new System.Drawing.Size(93, 37);
            this.btnEliminarDC2.TabIndex = 16;
            this.btnEliminarDC2.Text = "Eliminar";
            this.btnEliminarDC2.UseVisualStyleBackColor = false;
            this.btnEliminarDC2.Click += new System.EventHandler(this.btnEliminarDC2_Click);
            // 
            // btnGuardarDC2
            // 
            this.btnGuardarDC2.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardarDC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDC2.Location = new System.Drawing.Point(136, 212);
            this.btnGuardarDC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarDC2.Name = "btnGuardarDC2";
            this.btnGuardarDC2.Size = new System.Drawing.Size(93, 37);
            this.btnGuardarDC2.TabIndex = 15;
            this.btnGuardarDC2.Text = "Guardar";
            this.btnGuardarDC2.UseVisualStyleBackColor = false;
            this.btnGuardarDC2.Click += new System.EventHandler(this.btnGuardarDC2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID Almacen:";
            // 
            // gbFormCompras2
            // 
            this.gbFormCompras2.BackColor = System.Drawing.Color.LightYellow;
            this.gbFormCompras2.Controls.Add(this.dtpFechaCompra2);
            this.gbFormCompras2.Controls.Add(this.lblSumasC2);
            this.gbFormCompras2.Controls.Add(this.label4);
            this.gbFormCompras2.Controls.Add(this.label3);
            this.gbFormCompras2.Controls.Add(this.btnCancelarCompra2);
            this.gbFormCompras2.Controls.Add(this.txtDocumento2);
            this.gbFormCompras2.Controls.Add(this.label1);
            this.gbFormCompras2.Controls.Add(this.btnContCompra2);
            this.gbFormCompras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormCompras2.Location = new System.Drawing.Point(955, 14);
            this.gbFormCompras2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormCompras2.Name = "gbFormCompras2";
            this.gbFormCompras2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormCompras2.Size = new System.Drawing.Size(474, 244);
            this.gbFormCompras2.TabIndex = 10;
            this.gbFormCompras2.TabStop = false;
            this.gbFormCompras2.Text = "REGISTRAR VENTA";
            // 
            // dtpFechaCompra2
            // 
            this.dtpFechaCompra2.Location = new System.Drawing.Point(136, 88);
            this.dtpFechaCompra2.Name = "dtpFechaCompra2";
            this.dtpFechaCompra2.Size = new System.Drawing.Size(317, 23);
            this.dtpFechaCompra2.TabIndex = 19;
            // 
            // lblSumasC2
            // 
            this.lblSumasC2.AutoSize = true;
            this.lblSumasC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumasC2.Location = new System.Drawing.Point(138, 128);
            this.lblSumasC2.Name = "lblSumasC2";
            this.lblSumasC2.Size = new System.Drawing.Size(19, 20);
            this.lblSumasC2.TabIndex = 11;
            this.lblSumasC2.Text = "0";
            this.lblSumasC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sumas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha:";
            // 
            // btnCancelarCompra2
            // 
            this.btnCancelarCompra2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarCompra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra2.Location = new System.Drawing.Point(277, 177);
            this.btnCancelarCompra2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCompra2.Name = "btnCancelarCompra2";
            this.btnCancelarCompra2.Size = new System.Drawing.Size(93, 37);
            this.btnCancelarCompra2.TabIndex = 1;
            this.btnCancelarCompra2.Text = "Cancelar";
            this.btnCancelarCompra2.UseVisualStyleBackColor = false;
            this.btnCancelarCompra2.Click += new System.EventHandler(this.btnCancelarCompra2_Click);
            // 
            // txtDocumento2
            // 
            this.txtDocumento2.Location = new System.Drawing.Point(136, 50);
            this.txtDocumento2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento2.MaxLength = 20;
            this.txtDocumento2.Name = "txtDocumento2";
            this.txtDocumento2.Size = new System.Drawing.Size(317, 23);
            this.txtDocumento2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Documento:";
            // 
            // btnContCompra2
            // 
            this.btnContCompra2.BackColor = System.Drawing.Color.Aqua;
            this.btnContCompra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContCompra2.Location = new System.Drawing.Point(136, 177);
            this.btnContCompra2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContCompra2.Name = "btnContCompra2";
            this.btnContCompra2.Size = new System.Drawing.Size(93, 37);
            this.btnContCompra2.TabIndex = 0;
            this.btnContCompra2.Text = "Continuar";
            this.btnContCompra2.UseVisualStyleBackColor = false;
            this.btnContCompra2.Click += new System.EventHandler(this.btnContCompra2_Click);
            // 
            // btnRegCompra2
            // 
            this.btnRegCompra2.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRegCompra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCompra2.Location = new System.Drawing.Point(259, 268);
            this.btnRegCompra2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegCompra2.Name = "btnRegCompra2";
            this.btnRegCompra2.Size = new System.Drawing.Size(191, 37);
            this.btnRegCompra2.TabIndex = 9;
            this.btnRegCompra2.Text = "REGISTRAR VENTA";
            this.btnRegCompra2.UseVisualStyleBackColor = false;
            this.btnRegCompra2.Click += new System.EventHandler(this.btnRegCompra2_Click);
            // 
            // btnFinCompra2
            // 
            this.btnFinCompra2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFinCompra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinCompra2.Location = new System.Drawing.Point(508, 268);
            this.btnFinCompra2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinCompra2.Name = "btnFinCompra2";
            this.btnFinCompra2.Size = new System.Drawing.Size(191, 37);
            this.btnFinCompra2.TabIndex = 8;
            this.btnFinCompra2.Text = "FINALIZAR VENTA";
            this.btnFinCompra2.UseVisualStyleBackColor = false;
            this.btnFinCompra2.Click += new System.EventHandler(this.btnFinCompra2_Click);
            // 
            // gbDetalleC2
            // 
            this.gbDetalleC2.BackColor = System.Drawing.Color.LightYellow;
            this.gbDetalleC2.Controls.Add(this.dgvDetalleC2);
            this.gbDetalleC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleC2.Location = new System.Drawing.Point(33, 316);
            this.gbDetalleC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleC2.Name = "gbDetalleC2";
            this.gbDetalleC2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleC2.Size = new System.Drawing.Size(860, 272);
            this.gbDetalleC2.TabIndex = 7;
            this.gbDetalleC2.TabStop = false;
            this.gbDetalleC2.Text = "DETALLES DE LA VENTA";
            // 
            // dgvDetalleC2
            // 
            this.dgvDetalleC2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleC2.Location = new System.Drawing.Point(32, 26);
            this.dgvDetalleC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalleC2.Name = "dgvDetalleC2";
            this.dgvDetalleC2.RowHeadersWidth = 51;
            this.dgvDetalleC2.RowTemplate.Height = 29;
            this.dgvDetalleC2.Size = new System.Drawing.Size(797, 213);
            this.dgvDetalleC2.TabIndex = 0;
            // 
            // gbCompras2
            // 
            this.gbCompras2.BackColor = System.Drawing.Color.LightYellow;
            this.gbCompras2.Controls.Add(this.dgvCompras2);
            this.gbCompras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompras2.Location = new System.Drawing.Point(33, 14);
            this.gbCompras2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCompras2.Name = "gbCompras2";
            this.gbCompras2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCompras2.Size = new System.Drawing.Size(860, 244);
            this.gbCompras2.TabIndex = 6;
            this.gbCompras2.TabStop = false;
            this.gbCompras2.Text = "VENTAS";
            // 
            // dgvCompras2
            // 
            this.dgvCompras2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras2.Location = new System.Drawing.Point(32, 32);
            this.dgvCompras2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompras2.Name = "dgvCompras2";
            this.dgvCompras2.RowHeadersWidth = 51;
            this.dgvCompras2.RowTemplate.Height = 29;
            this.dgvCompras2.Size = new System.Drawing.Size(797, 182);
            this.dgvCompras2.TabIndex = 0;
            this.dgvCompras2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras2_CellDoubleClick);
            // 
            // txtCantC2
            // 
            this.txtCantC2.Location = new System.Drawing.Point(172, 127);
            this.txtCantC2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantC2.Name = "txtCantC2";
            this.txtCantC2.Size = new System.Drawing.Size(255, 23);
            this.txtCantC2.TabIndex = 27;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1467, 615);
            this.Controls.Add(this.gbFormDetalleC2);
            this.Controls.Add(this.gbFormCompras2);
            this.Controls.Add(this.btnRegCompra2);
            this.Controls.Add(this.btnFinCompra2);
            this.Controls.Add(this.gbDetalleC2);
            this.Controls.Add(this.gbCompras2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(907, 492);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.gbFormDetalleC2.ResumeLayout(false);
            this.gbFormDetalleC2.PerformLayout();
            this.gbFormCompras2.ResumeLayout(false);
            this.gbFormCompras2.PerformLayout();
            this.gbDetalleC2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleC2)).EndInit();
            this.gbCompras2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantC2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormDetalleC2;
        private System.Windows.Forms.Button btnEliminarDC2;
        private System.Windows.Forms.Button btnGuardarDC2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbFormCompras2;
        private System.Windows.Forms.Label lblSumasC2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarCompra2;
        private System.Windows.Forms.Button btnContCompra2;
        private System.Windows.Forms.Button btnRegCompra2;
        private System.Windows.Forms.Button btnFinCompra2;
        private System.Windows.Forms.GroupBox gbDetalleC2;
        private System.Windows.Forms.DataGridView dgvDetalleC2;
        private System.Windows.Forms.GroupBox gbCompras2;
        private System.Windows.Forms.DataGridView dgvCompras2;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPreC2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProd2;
        private System.Windows.Forms.ComboBox cmbAlm2;
        private System.Windows.Forms.NumericUpDown txtCantC2;
    }
}