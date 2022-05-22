
namespace MenuFerreBerny
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.gbCompras = new System.Windows.Forms.GroupBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.gbDetalleC = new System.Windows.Forms.GroupBox();
            this.dgvDetalleC = new System.Windows.Forms.DataGridView();
            this.btnFinCompra = new System.Windows.Forms.Button();
            this.btnRegCompra = new System.Windows.Forms.Button();
            this.gbFormCompras = new System.Windows.Forms.GroupBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblIVAC = new System.Windows.Forms.Label();
            this.lblSumasC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnContCompra = new System.Windows.Forms.Button();
            this.gbFormDetalleC = new System.Windows.Forms.GroupBox();
            this.txtPreC = new System.Windows.Forms.Label();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.cmbAlm = new System.Windows.Forms.ComboBox();
            this.btnEliminarDC = new System.Windows.Forms.Button();
            this.btnGuardarDC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantC = new System.Windows.Forms.NumericUpDown();
            this.gbCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.gbDetalleC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleC)).BeginInit();
            this.gbFormCompras.SuspendLayout();
            this.gbFormDetalleC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantC)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompras
            // 
            this.gbCompras.BackColor = System.Drawing.Color.LightYellow;
            this.gbCompras.Controls.Add(this.dgvCompras);
            this.gbCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompras.Location = new System.Drawing.Point(26, 21);
            this.gbCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCompras.Name = "gbCompras";
            this.gbCompras.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCompras.Size = new System.Drawing.Size(881, 271);
            this.gbCompras.TabIndex = 0;
            this.gbCompras.TabStop = false;
            this.gbCompras.Text = "COMPRAS";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompras.Location = new System.Drawing.Point(31, 31);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 29;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(814, 214);
            this.dgvCompras.TabIndex = 0;
            this.dgvCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellDoubleClick);
            // 
            // gbDetalleC
            // 
            this.gbDetalleC.BackColor = System.Drawing.Color.LightYellow;
            this.gbDetalleC.Controls.Add(this.dgvDetalleC);
            this.gbDetalleC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleC.Location = new System.Drawing.Point(26, 337);
            this.gbDetalleC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleC.Name = "gbDetalleC";
            this.gbDetalleC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleC.Size = new System.Drawing.Size(1015, 243);
            this.gbDetalleC.TabIndex = 1;
            this.gbDetalleC.TabStop = false;
            this.gbDetalleC.Text = "DETALLES DE LA COMPRA";
            // 
            // dgvDetalleC
            // 
            this.dgvDetalleC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalleC.Location = new System.Drawing.Point(31, 27);
            this.dgvDetalleC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalleC.Name = "dgvDetalleC";
            this.dgvDetalleC.RowHeadersWidth = 51;
            this.dgvDetalleC.RowTemplate.Height = 29;
            this.dgvDetalleC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleC.Size = new System.Drawing.Size(949, 192);
            this.dgvDetalleC.TabIndex = 0;
            // 
            // btnFinCompra
            // 
            this.btnFinCompra.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFinCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinCompra.Location = new System.Drawing.Point(538, 296);
            this.btnFinCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinCompra.Name = "btnFinCompra";
            this.btnFinCompra.Size = new System.Drawing.Size(191, 37);
            this.btnFinCompra.TabIndex = 2;
            this.btnFinCompra.Text = "FINALIZAR COMPRA";
            this.btnFinCompra.UseVisualStyleBackColor = false;
            this.btnFinCompra.Click += new System.EventHandler(this.btnFinCompra_Click);
            // 
            // btnRegCompra
            // 
            this.btnRegCompra.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRegCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCompra.Location = new System.Drawing.Point(310, 296);
            this.btnRegCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegCompra.Name = "btnRegCompra";
            this.btnRegCompra.Size = new System.Drawing.Size(191, 37);
            this.btnRegCompra.TabIndex = 3;
            this.btnRegCompra.Text = "REGISTRAR COMPRA";
            this.btnRegCompra.UseVisualStyleBackColor = false;
            this.btnRegCompra.Click += new System.EventHandler(this.btnRegCompra_Click);
            // 
            // gbFormCompras
            // 
            this.gbFormCompras.BackColor = System.Drawing.Color.LightYellow;
            this.gbFormCompras.Controls.Add(this.dtpFechaCompra);
            this.gbFormCompras.Controls.Add(this.label3);
            this.gbFormCompras.Controls.Add(this.cmbProveedor);
            this.gbFormCompras.Controls.Add(this.lblIVAC);
            this.gbFormCompras.Controls.Add(this.lblSumasC);
            this.gbFormCompras.Controls.Add(this.label5);
            this.gbFormCompras.Controls.Add(this.label4);
            this.gbFormCompras.Controls.Add(this.label2);
            this.gbFormCompras.Controls.Add(this.txtDocumento);
            this.gbFormCompras.Controls.Add(this.label1);
            this.gbFormCompras.Controls.Add(this.btnCancelarCompra);
            this.gbFormCompras.Controls.Add(this.btnContCompra);
            this.gbFormCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormCompras.Location = new System.Drawing.Point(924, 21);
            this.gbFormCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormCompras.MaximumSize = new System.Drawing.Size(1467, 751);
            this.gbFormCompras.Name = "gbFormCompras";
            this.gbFormCompras.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormCompras.Size = new System.Drawing.Size(508, 271);
            this.gbFormCompras.TabIndex = 4;
            this.gbFormCompras.TabStop = false;
            this.gbFormCompras.Text = "REGISTRAR COMPRA";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Location = new System.Drawing.Point(160, 127);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(317, 23);
            this.dtpFechaCompra.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(160, 78);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(317, 25);
            this.cmbProveedor.TabIndex = 13;
            // 
            // lblIVAC
            // 
            this.lblIVAC.AutoSize = true;
            this.lblIVAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVAC.Location = new System.Drawing.Point(351, 174);
            this.lblIVAC.Name = "lblIVAC";
            this.lblIVAC.Size = new System.Drawing.Size(19, 20);
            this.lblIVAC.TabIndex = 12;
            this.lblIVAC.Text = "0";
            this.lblIVAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumasC
            // 
            this.lblSumasC.AutoSize = true;
            this.lblSumasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumasC.Location = new System.Drawing.Point(133, 176);
            this.lblSumasC.Name = "lblSumasC";
            this.lblSumasC.Size = new System.Drawing.Size(19, 20);
            this.lblSumasC.TabIndex = 11;
            this.lblSumasC.Text = "0";
            this.lblSumasC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "IVA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sumas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Proveedor:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(160, 38);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.MaxLength = 20;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(317, 23);
            this.txtDocumento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento:";
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.Location = new System.Drawing.Point(272, 218);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(109, 37);
            this.btnCancelarCompra.TabIndex = 1;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnContCompra
            // 
            this.btnContCompra.BackColor = System.Drawing.Color.Aqua;
            this.btnContCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContCompra.Location = new System.Drawing.Point(123, 218);
            this.btnContCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContCompra.Name = "btnContCompra";
            this.btnContCompra.Size = new System.Drawing.Size(127, 37);
            this.btnContCompra.TabIndex = 0;
            this.btnContCompra.Text = "Continuar";
            this.btnContCompra.UseVisualStyleBackColor = false;
            this.btnContCompra.Click += new System.EventHandler(this.btnContCompra_Click);
            // 
            // gbFormDetalleC
            // 
            this.gbFormDetalleC.BackColor = System.Drawing.Color.LightYellow;
            this.gbFormDetalleC.Controls.Add(this.txtCantC);
            this.gbFormDetalleC.Controls.Add(this.txtPreC);
            this.gbFormDetalleC.Controls.Add(this.cmbProd);
            this.gbFormDetalleC.Controls.Add(this.cmbAlm);
            this.gbFormDetalleC.Controls.Add(this.btnEliminarDC);
            this.gbFormDetalleC.Controls.Add(this.btnGuardarDC);
            this.gbFormDetalleC.Controls.Add(this.label11);
            this.gbFormDetalleC.Controls.Add(this.label10);
            this.gbFormDetalleC.Controls.Add(this.label9);
            this.gbFormDetalleC.Controls.Add(this.label8);
            this.gbFormDetalleC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormDetalleC.Location = new System.Drawing.Point(1084, 315);
            this.gbFormDetalleC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormDetalleC.Name = "gbFormDetalleC";
            this.gbFormDetalleC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFormDetalleC.Size = new System.Drawing.Size(348, 265);
            this.gbFormDetalleC.TabIndex = 5;
            this.gbFormDetalleC.TabStop = false;
            this.gbFormDetalleC.Text = "REGISTRAR DETALLE";
            // 
            // txtPreC
            // 
            this.txtPreC.AutoSize = true;
            this.txtPreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreC.Location = new System.Drawing.Point(156, 159);
            this.txtPreC.Name = "txtPreC";
            this.txtPreC.Size = new System.Drawing.Size(19, 20);
            this.txtPreC.TabIndex = 24;
            this.txtPreC.Text = "0";
            // 
            // cmbProd
            // 
            this.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(160, 38);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(157, 25);
            this.cmbProd.TabIndex = 23;
            this.cmbProd.SelectedValueChanged += new System.EventHandler(this.cmbProd_SelectedValueChanged);
            // 
            // cmbAlm
            // 
            this.cmbAlm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlm.FormattingEnabled = true;
            this.cmbAlm.Location = new System.Drawing.Point(160, 77);
            this.cmbAlm.Name = "cmbAlm";
            this.cmbAlm.Size = new System.Drawing.Size(157, 25);
            this.cmbAlm.TabIndex = 14;
            // 
            // btnEliminarDC
            // 
            this.btnEliminarDC.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDC.Location = new System.Drawing.Point(208, 204);
            this.btnEliminarDC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarDC.Name = "btnEliminarDC";
            this.btnEliminarDC.Size = new System.Drawing.Size(109, 37);
            this.btnEliminarDC.TabIndex = 16;
            this.btnEliminarDC.Text = "Eliminar";
            this.btnEliminarDC.UseVisualStyleBackColor = false;
            this.btnEliminarDC.Click += new System.EventHandler(this.btnEliminarDC_Click);
            // 
            // btnGuardarDC
            // 
            this.btnGuardarDC.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardarDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDC.Location = new System.Drawing.Point(59, 204);
            this.btnGuardarDC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarDC.Name = "btnGuardarDC";
            this.btnGuardarDC.Size = new System.Drawing.Size(127, 37);
            this.btnGuardarDC.TabIndex = 15;
            this.btnGuardarDC.Text = "Guardar";
            this.btnGuardarDC.UseVisualStyleBackColor = false;
            this.btnGuardarDC.Click += new System.EventHandler(this.btnGuardarDC_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID Almacen:";
            // 
            // txtCantC
            // 
            this.txtCantC.Location = new System.Drawing.Point(160, 118);
            this.txtCantC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantC.Name = "txtCantC";
            this.txtCantC.Size = new System.Drawing.Size(157, 23);
            this.txtCantC.TabIndex = 25;
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1467, 615);
            this.Controls.Add(this.gbFormDetalleC);
            this.Controls.Add(this.gbFormCompras);
            this.Controls.Add(this.btnRegCompra);
            this.Controls.Add(this.btnFinCompra);
            this.Controls.Add(this.gbDetalleC);
            this.Controls.Add(this.gbCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(907, 492);
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.gbCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.gbDetalleC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleC)).EndInit();
            this.gbFormCompras.ResumeLayout(false);
            this.gbFormCompras.PerformLayout();
            this.gbFormDetalleC.ResumeLayout(false);
            this.gbFormDetalleC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.GroupBox gbDetalleC;
        private System.Windows.Forms.DataGridView dgvDetalleC;
        private System.Windows.Forms.Button btnFinCompra;
        private System.Windows.Forms.Button btnRegCompra;
        private System.Windows.Forms.GroupBox gbFormCompras;
        private System.Windows.Forms.Label lblIVAC;
        private System.Windows.Forms.Label lblSumasC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnContCompra;
        private System.Windows.Forms.GroupBox gbFormDetalleC;
        private System.Windows.Forms.Button btnEliminarDC;
        private System.Windows.Forms.Button btnGuardarDC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.ComboBox cmbAlm;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtPreC;
        private System.Windows.Forms.NumericUpDown txtCantC;
    }
}