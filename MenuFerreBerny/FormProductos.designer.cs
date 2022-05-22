
namespace MenuFerreBerny
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.btnRefrescarListaProd = new System.Windows.Forms.Button();
            this.txtIdProd = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExistenciaProd = new System.Windows.Forms.NumericUpDown();
            this.txtStockMax = new System.Windows.Forms.NumericUpDown();
            this.txtStockMin = new System.Windows.Forms.NumericUpDown();
            this.cmbCatProd = new System.Windows.Forms.ComboBox();
            this.cmbMarcaProd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarProd = new System.Windows.Forms.Button();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.btnCrearProd = new System.Windows.Forms.Button();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHabilitarCrearProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnHabilitarModificarProd = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescarListaProd
            // 
            this.btnRefrescarListaProd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRefrescarListaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarListaProd.Location = new System.Drawing.Point(620, 450);
            this.btnRefrescarListaProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefrescarListaProd.Name = "btnRefrescarListaProd";
            this.btnRefrescarListaProd.Size = new System.Drawing.Size(140, 30);
            this.btnRefrescarListaProd.TabIndex = 44;
            this.btnRefrescarListaProd.Text = "Refrescar lista";
            this.btnRefrescarListaProd.UseVisualStyleBackColor = false;
            this.btnRefrescarListaProd.Click += new System.EventHandler(this.btnRefrescarListaProd_Click);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(356, 73);
            this.txtIdProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdProd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(112, 20);
            this.txtIdProd.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.txtPrecioProd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtExistenciaProd);
            this.groupBox1.Controls.Add(this.txtStockMax);
            this.groupBox1.Controls.Add(this.txtStockMin);
            this.groupBox1.Controls.Add(this.cmbCatProd);
            this.groupBox1.Controls.Add(this.cmbMarcaProd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnModificarProd);
            this.groupBox1.Controls.Add(this.btnCancelarProd);
            this.groupBox1.Controls.Add(this.btnCrearProd);
            this.groupBox1.Controls.Add(this.txtNombreProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(262, 390);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(106, 209);
            this.txtPrecioProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrecioProd.MaxLength = 150;
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(139, 20);
            this.txtPrecioProd.TabIndex = 52;
            this.txtPrecioProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProd_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Precio Unidad:";
            // 
            // txtExistenciaProd
            // 
            this.txtExistenciaProd.Location = new System.Drawing.Point(106, 182);
            this.txtExistenciaProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExistenciaProd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtExistenciaProd.Name = "txtExistenciaProd";
            this.txtExistenciaProd.Size = new System.Drawing.Size(138, 20);
            this.txtExistenciaProd.TabIndex = 50;
            // 
            // txtStockMax
            // 
            this.txtStockMax.Location = new System.Drawing.Point(106, 154);
            this.txtStockMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStockMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtStockMax.Name = "txtStockMax";
            this.txtStockMax.Size = new System.Drawing.Size(138, 20);
            this.txtStockMax.TabIndex = 49;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(106, 127);
            this.txtStockMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStockMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(138, 20);
            this.txtStockMin.TabIndex = 48;
            // 
            // cmbCatProd
            // 
            this.cmbCatProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatProd.FormattingEnabled = true;
            this.cmbCatProd.Location = new System.Drawing.Point(106, 98);
            this.cmbCatProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCatProd.Name = "cmbCatProd";
            this.cmbCatProd.Size = new System.Drawing.Size(139, 21);
            this.cmbCatProd.TabIndex = 30;
            // 
            // cmbMarcaProd
            // 
            this.cmbMarcaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaProd.FormattingEnabled = true;
            this.cmbMarcaProd.Location = new System.Drawing.Point(106, 67);
            this.cmbMarcaProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMarcaProd.Name = "cmbMarcaProd";
            this.cmbMarcaProd.Size = new System.Drawing.Size(139, 21);
            this.cmbMarcaProd.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Stock Min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Existencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Stock Max:";
            // 
            // btnModificarProd
            // 
            this.btnModificarProd.BackColor = System.Drawing.Color.Aqua;
            this.btnModificarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProd.Location = new System.Drawing.Point(80, 293);
            this.btnModificarProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificarProd.Name = "btnModificarProd";
            this.btnModificarProd.Size = new System.Drawing.Size(104, 30);
            this.btnModificarProd.TabIndex = 22;
            this.btnModificarProd.Text = "Modificar";
            this.btnModificarProd.UseVisualStyleBackColor = false;
            this.btnModificarProd.Click += new System.EventHandler(this.btnModificarProd_Click);
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProd.Location = new System.Drawing.Point(80, 342);
            this.btnCancelarProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(104, 30);
            this.btnCancelarProd.TabIndex = 13;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = false;
            this.btnCancelarProd.Click += new System.EventHandler(this.btnCancelarProd_Click);
            // 
            // btnCrearProd
            // 
            this.btnCrearProd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCrearProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProd.Location = new System.Drawing.Point(80, 248);
            this.btnCrearProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCrearProd.Name = "btnCrearProd";
            this.btnCrearProd.Size = new System.Drawing.Size(104, 30);
            this.btnCrearProd.TabIndex = 1;
            this.btnCrearProd.Text = "Crear";
            this.btnCrearProd.UseVisualStyleBackColor = false;
            this.btnCrearProd.Click += new System.EventHandler(this.btnCrearProd_Click);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(106, 41);
            this.txtNombreProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreProd.MaxLength = 150;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(139, 20);
            this.txtNombreProd.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoría:";
            // 
            // btnHabilitarCrearProd
            // 
            this.btnHabilitarCrearProd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHabilitarCrearProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarCrearProd.Location = new System.Drawing.Point(686, 68);
            this.btnHabilitarCrearProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHabilitarCrearProd.Name = "btnHabilitarCrearProd";
            this.btnHabilitarCrearProd.Size = new System.Drawing.Size(140, 30);
            this.btnHabilitarCrearProd.TabIndex = 41;
            this.btnHabilitarCrearProd.Text = "Agregar Producto";
            this.btnHabilitarCrearProd.UseVisualStyleBackColor = false;
            this.btnHabilitarCrearProd.Click += new System.EventHandler(this.btnHabilitarCrearProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(615, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 30);
            this.label7.TabIndex = 40;
            this.label7.Text = "PRODUCTOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightYellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "ID:";
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.Location = new System.Drawing.Point(960, 69);
            this.btnEliminarProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(82, 30);
            this.btnEliminarProd.TabIndex = 38;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnHabilitarModificarProd
            // 
            this.btnHabilitarModificarProd.BackColor = System.Drawing.Color.Aqua;
            this.btnHabilitarModificarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarModificarProd.Location = new System.Drawing.Point(848, 68);
            this.btnHabilitarModificarProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHabilitarModificarProd.Name = "btnHabilitarModificarProd";
            this.btnHabilitarModificarProd.Size = new System.Drawing.Size(89, 30);
            this.btnHabilitarModificarProd.TabIndex = 37;
            this.btnHabilitarModificarProd.Text = "Modificar";
            this.btnHabilitarModificarProd.UseVisualStyleBackColor = false;
            this.btnHabilitarModificarProd.Click += new System.EventHandler(this.btnHabilitarModificarProd_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(481, 69);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(82, 30);
            this.btnBuscarProd.TabIndex = 36;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(300, 116);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(779, 308);
            this.dgvProductos.TabIndex = 35;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(290, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 390);
            this.panel1.TabIndex = 47;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1103, 500);
            this.Controls.Add(this.btnRefrescarListaProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHabilitarCrearProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.btnHabilitarModificarProd);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(680, 400);
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescarListaProd;
        private System.Windows.Forms.NumericUpDown txtIdProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarProd;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.Button btnCrearProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHabilitarCrearProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnHabilitarModificarProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMarcaProd;
        private System.Windows.Forms.NumericUpDown txtExistenciaProd;
        private System.Windows.Forms.NumericUpDown txtStockMax;
        private System.Windows.Forms.NumericUpDown txtStockMin;
        private System.Windows.Forms.ComboBox cmbCatProd;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label9;
    }
}