
namespace MenuFerreBerny
{
    partial class FormAlmacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacenes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarAlmacen = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarAlm = new System.Windows.Forms.Button();
            this.txtNombreAlmacen = new System.Windows.Forms.TextBox();
            this.btnActualizarAlm = new System.Windows.Forms.Button();
            this.btnGuardarAlm = new System.Windows.Forms.Button();
            this.btnEliminarAlm = new System.Windows.Forms.Button();
            this.btnHabilitarModificarAlm = new System.Windows.Forms.Button();
            this.btnHabilitarNuevoAlm = new System.Windows.Forms.Button();
            this.btnBuscarAlm = new System.Windows.Forms.Button();
            this.dgvAlmacenes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarAlmProd = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarAP = new System.Windows.Forms.Button();
            this.btnCancelarAlmProd = new System.Windows.Forms.Button();
            this.btnActualizarAlmProd = new System.Windows.Forms.Button();
            this.btnGuardarAlmProd = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvAlmProd = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarAlmacen)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmProd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.txtBuscarAlmacen);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnEliminarAlm);
            this.groupBox1.Controls.Add(this.btnHabilitarModificarAlm);
            this.groupBox1.Controls.Add(this.btnHabilitarNuevoAlm);
            this.groupBox1.Controls.Add(this.btnBuscarAlm);
            this.groupBox1.Controls.Add(this.dgvAlmacenes);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(555, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALMACENES";
            // 
            // txtBuscarAlmacen
            // 
            this.txtBuscarAlmacen.Location = new System.Drawing.Point(68, 29);
            this.txtBuscarAlmacen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtBuscarAlmacen.Name = "txtBuscarAlmacen";
            this.txtBuscarAlmacen.Size = new System.Drawing.Size(299, 27);
            this.txtBuscarAlmacen.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnCancelarAlm);
            this.groupBox5.Controls.Add(this.txtNombreAlmacen);
            this.groupBox5.Controls.Add(this.btnActualizarAlm);
            this.groupBox5.Controls.Add(this.btnGuardarAlm);
            this.groupBox5.Location = new System.Drawing.Point(19, 116);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(516, 131);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos de Almacén";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // btnCancelarAlm
            // 
            this.btnCancelarAlm.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarAlm.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarAlm.Location = new System.Drawing.Point(369, 72);
            this.btnCancelarAlm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarAlm.Name = "btnCancelarAlm";
            this.btnCancelarAlm.Size = new System.Drawing.Size(93, 34);
            this.btnCancelarAlm.TabIndex = 18;
            this.btnCancelarAlm.Text = "Cancelar";
            this.btnCancelarAlm.UseVisualStyleBackColor = false;
            this.btnCancelarAlm.Click += new System.EventHandler(this.btnCancelarAlm_Click);
            // 
            // txtNombreAlmacen
            // 
            this.txtNombreAlmacen.Location = new System.Drawing.Point(128, 27);
            this.txtNombreAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreAlmacen.MaxLength = 50;
            this.txtNombreAlmacen.Name = "txtNombreAlmacen";
            this.txtNombreAlmacen.Size = new System.Drawing.Size(333, 27);
            this.txtNombreAlmacen.TabIndex = 8;
            // 
            // btnActualizarAlm
            // 
            this.btnActualizarAlm.BackColor = System.Drawing.Color.Chartreuse;
            this.btnActualizarAlm.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarAlm.Location = new System.Drawing.Point(212, 72);
            this.btnActualizarAlm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarAlm.Name = "btnActualizarAlm";
            this.btnActualizarAlm.Size = new System.Drawing.Size(93, 34);
            this.btnActualizarAlm.TabIndex = 17;
            this.btnActualizarAlm.Text = "Actualizar";
            this.btnActualizarAlm.UseVisualStyleBackColor = false;
            this.btnActualizarAlm.Click += new System.EventHandler(this.btnActualizarAlm_Click);
            // 
            // btnGuardarAlm
            // 
            this.btnGuardarAlm.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardarAlm.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarAlm.Location = new System.Drawing.Point(49, 71);
            this.btnGuardarAlm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarAlm.Name = "btnGuardarAlm";
            this.btnGuardarAlm.Size = new System.Drawing.Size(93, 37);
            this.btnGuardarAlm.TabIndex = 16;
            this.btnGuardarAlm.Text = "Guardar";
            this.btnGuardarAlm.UseVisualStyleBackColor = false;
            this.btnGuardarAlm.Click += new System.EventHandler(this.btnGuardarAlm_Click);
            // 
            // btnEliminarAlm
            // 
            this.btnEliminarAlm.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarAlm.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarAlm.Location = new System.Drawing.Point(388, 69);
            this.btnEliminarAlm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAlm.Name = "btnEliminarAlm";
            this.btnEliminarAlm.Size = new System.Drawing.Size(93, 37);
            this.btnEliminarAlm.TabIndex = 6;
            this.btnEliminarAlm.Text = "Eliminar";
            this.btnEliminarAlm.UseVisualStyleBackColor = false;
            this.btnEliminarAlm.Click += new System.EventHandler(this.btnEliminarAlm_Click);
            // 
            // btnHabilitarModificarAlm
            // 
            this.btnHabilitarModificarAlm.BackColor = System.Drawing.Color.Aqua;
            this.btnHabilitarModificarAlm.ForeColor = System.Drawing.Color.Black;
            this.btnHabilitarModificarAlm.Location = new System.Drawing.Point(231, 69);
            this.btnHabilitarModificarAlm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabilitarModificarAlm.Name = "btnHabilitarModificarAlm";
            this.btnHabilitarModificarAlm.Size = new System.Drawing.Size(93, 37);
            this.btnHabilitarModificarAlm.TabIndex = 5;
            this.btnHabilitarModificarAlm.Text = "Modificar";
            this.btnHabilitarModificarAlm.UseVisualStyleBackColor = false;
            this.btnHabilitarModificarAlm.Click += new System.EventHandler(this.btnHabilitarModificarAlm_Click);
            // 
            // btnHabilitarNuevoAlm
            // 
            this.btnHabilitarNuevoAlm.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHabilitarNuevoAlm.ForeColor = System.Drawing.Color.Black;
            this.btnHabilitarNuevoAlm.Location = new System.Drawing.Point(68, 69);
            this.btnHabilitarNuevoAlm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabilitarNuevoAlm.Name = "btnHabilitarNuevoAlm";
            this.btnHabilitarNuevoAlm.Size = new System.Drawing.Size(93, 37);
            this.btnHabilitarNuevoAlm.TabIndex = 4;
            this.btnHabilitarNuevoAlm.Text = "Nuevo";
            this.btnHabilitarNuevoAlm.UseVisualStyleBackColor = false;
            this.btnHabilitarNuevoAlm.Click += new System.EventHandler(this.btnHabilitarNuevoAlm_Click);
            // 
            // btnBuscarAlm
            // 
            this.btnBuscarAlm.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarAlm.Location = new System.Drawing.Point(388, 23);
            this.btnBuscarAlm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAlm.Name = "btnBuscarAlm";
            this.btnBuscarAlm.Size = new System.Drawing.Size(93, 37);
            this.btnBuscarAlm.TabIndex = 2;
            this.btnBuscarAlm.Text = "Buscar";
            this.btnBuscarAlm.UseVisualStyleBackColor = true;
            this.btnBuscarAlm.Click += new System.EventHandler(this.btnBuscarAlm_Click);
            // 
            // dgvAlmacenes
            // 
            this.dgvAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacenes.Location = new System.Drawing.Point(19, 251);
            this.dgvAlmacenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlmacenes.Name = "dgvAlmacenes";
            this.dgvAlmacenes.ReadOnly = true;
            this.dgvAlmacenes.RowHeadersWidth = 51;
            this.dgvAlmacenes.RowTemplate.Height = 29;
            this.dgvAlmacenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmacenes.Size = new System.Drawing.Size(516, 222);
            this.dgvAlmacenes.TabIndex = 0;
            this.dgvAlmacenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlmacenes_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dgvAlmProd);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(585, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(858, 502);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CANTIDADES ALMACENADAS DE PRODUCTOS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarAlmProd);
            this.groupBox4.Controls.Add(this.cmbProducto);
            this.groupBox4.Controls.Add(this.cmbAlmacen);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnEliminarAP);
            this.groupBox4.Controls.Add(this.btnCancelarAlmProd);
            this.groupBox4.Controls.Add(this.btnActualizarAlmProd);
            this.groupBox4.Controls.Add(this.btnGuardarAlmProd);
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(808, 169);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // btnBuscarAlmProd
            // 
            this.btnBuscarAlmProd.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarAlmProd.Location = new System.Drawing.Point(559, 24);
            this.btnBuscarAlmProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAlmProd.Name = "btnBuscarAlmProd";
            this.btnBuscarAlmProd.Size = new System.Drawing.Size(214, 37);
            this.btnBuscarAlmProd.TabIndex = 24;
            this.btnBuscarAlmProd.Text = "Buscar";
            this.btnBuscarAlmProd.UseVisualStyleBackColor = true;
            this.btnBuscarAlmProd.Click += new System.EventHandler(this.btnBuscarAlmProd_Click_2);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(166, 74);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(358, 28);
            this.cmbProducto.TabIndex = 26;
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmacen.FormattingEnabled = true;
            this.cmbAlmacen.Location = new System.Drawing.Point(166, 38);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(358, 28);
            this.cmbAlmacen.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cantidad existente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID del producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID del almacen:";
            // 
            // btnEliminarAP
            // 
            this.btnEliminarAP.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarAP.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAP.Location = new System.Drawing.Point(545, 117);
            this.btnEliminarAP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAP.Name = "btnEliminarAP";
            this.btnEliminarAP.Size = new System.Drawing.Size(106, 37);
            this.btnEliminarAP.TabIndex = 15;
            this.btnEliminarAP.Text = "ELIMINAR";
            this.btnEliminarAP.UseVisualStyleBackColor = false;
            this.btnEliminarAP.Click += new System.EventHandler(this.btnEliminarAlmProd_Click);
            // 
            // btnCancelarAlmProd
            // 
            this.btnCancelarAlmProd.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelarAlmProd.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarAlmProd.Location = new System.Drawing.Point(667, 117);
            this.btnCancelarAlmProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarAlmProd.Name = "btnCancelarAlmProd";
            this.btnCancelarAlmProd.Size = new System.Drawing.Size(118, 37);
            this.btnCancelarAlmProd.TabIndex = 15;
            this.btnCancelarAlmProd.Text = "Cancelar";
            this.btnCancelarAlmProd.UseVisualStyleBackColor = false;
            this.btnCancelarAlmProd.Click += new System.EventHandler(this.btnCancelarAlmProd_Click);
            // 
            // btnActualizarAlmProd
            // 
            this.btnActualizarAlmProd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnActualizarAlmProd.Location = new System.Drawing.Point(667, 69);
            this.btnActualizarAlmProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarAlmProd.Name = "btnActualizarAlmProd";
            this.btnActualizarAlmProd.Size = new System.Drawing.Size(118, 37);
            this.btnActualizarAlmProd.TabIndex = 14;
            this.btnActualizarAlmProd.Text = "Actualizar";
            this.btnActualizarAlmProd.UseVisualStyleBackColor = false;
            this.btnActualizarAlmProd.Click += new System.EventHandler(this.btnActualizarAlmProd_Click);
            // 
            // btnGuardarAlmProd
            // 
            this.btnGuardarAlmProd.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardarAlmProd.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarAlmProd.Location = new System.Drawing.Point(545, 69);
            this.btnGuardarAlmProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarAlmProd.Name = "btnGuardarAlmProd";
            this.btnGuardarAlmProd.Size = new System.Drawing.Size(106, 37);
            this.btnGuardarAlmProd.TabIndex = 13;
            this.btnGuardarAlmProd.Text = "Nuevo";
            this.btnGuardarAlmProd.UseVisualStyleBackColor = false;
            this.btnGuardarAlmProd.Click += new System.EventHandler(this.btnGuardarAlmProd_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(166, 110);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 27);
            this.txtCantidad.TabIndex = 2;
            // 
            // dgvAlmProd
            // 
            this.dgvAlmProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlmProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmProd.Location = new System.Drawing.Point(21, 202);
            this.dgvAlmProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlmProd.Name = "dgvAlmProd";
            this.dgvAlmProd.ReadOnly = true;
            this.dgvAlmProd.RowHeadersWidth = 51;
            this.dgvAlmProd.RowTemplate.Height = 29;
            this.dgvAlmProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmProd.Size = new System.Drawing.Size(808, 271);
            this.dgvAlmProd.TabIndex = 7;
            this.dgvAlmProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlmProd_CellDoubleClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(549, 542);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(373, 37);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "REFRESCAR TODO";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // FormAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1467, 615);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1467, 985);
            this.MinimumSize = new System.Drawing.Size(907, 492);
            this.Name = "FormAlmacenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlmacenes";
            this.Load += new System.EventHandler(this.FormAlmacenes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarAlmacen)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAlmacenes;
        private System.Windows.Forms.Button btnBuscarAlm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarAlm;
        private System.Windows.Forms.Button btnHabilitarModificarAlm;
        private System.Windows.Forms.Button btnHabilitarNuevoAlm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridView dgvAlmProd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCancelarAlm;
        private System.Windows.Forms.TextBox txtNombreAlmacen;
        private System.Windows.Forms.Button btnActualizarAlm;
        private System.Windows.Forms.Button btnGuardarAlm;
        private System.Windows.Forms.Button btnCancelarAlmProd;
        private System.Windows.Forms.Button btnActualizarAlmProd;
        private System.Windows.Forms.Button btnGuardarAlmProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.NumericUpDown txtBuscarAlmacen;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.Button btnBuscarAlmProd;
        private System.Windows.Forms.Button btnEliminarAP;
    }
}