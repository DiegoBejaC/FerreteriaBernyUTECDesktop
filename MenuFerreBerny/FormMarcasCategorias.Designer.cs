
namespace MenuFerreBerny
{
    partial class FormMarcasCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcasCategorias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarMarca = new System.Windows.Forms.NumericUpDown();
            this.gbMarcas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.btnActualizarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnHabilitarModificarMarca = new System.Windows.Forms.Button();
            this.btnHabilitarNuevaMarca = new System.Windows.Forms.Button();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCat = new System.Windows.Forms.NumericUpDown();
            this.gbCat = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.btnActualizarCat = new System.Windows.Forms.Button();
            this.btnGuardarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnHabilitarModificarCat = new System.Windows.Forms.Button();
            this.btnHabilitarNuevaCat = new System.Windows.Forms.Button();
            this.btnBuscarCat = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnRefrescarTablas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarMarca)).BeginInit();
            this.gbMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarCat)).BeginInit();
            this.gbCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.txtBuscarMarca);
            this.groupBox1.Controls.Add(this.gbMarcas);
            this.groupBox1.Controls.Add(this.btnEliminarMarca);
            this.groupBox1.Controls.Add(this.btnHabilitarModificarMarca);
            this.groupBox1.Controls.Add(this.btnHabilitarNuevaMarca);
            this.groupBox1.Controls.Add(this.btnBuscarMarca);
            this.groupBox1.Controls.Add(this.dgvMarcas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(154, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(555, 502);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MARCAS";
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Location = new System.Drawing.Point(68, 29);
            this.txtBuscarMarca.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(299, 27);
            this.txtBuscarMarca.TabIndex = 23;
            // 
            // gbMarcas
            // 
            this.gbMarcas.Controls.Add(this.label1);
            this.gbMarcas.Controls.Add(this.btnCancelarMarca);
            this.gbMarcas.Controls.Add(this.txtNombreMarca);
            this.gbMarcas.Controls.Add(this.btnActualizarMarca);
            this.gbMarcas.Controls.Add(this.btnGuardarMarca);
            this.gbMarcas.Location = new System.Drawing.Point(19, 116);
            this.gbMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMarcas.Name = "gbMarcas";
            this.gbMarcas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMarcas.Size = new System.Drawing.Size(516, 131);
            this.gbMarcas.TabIndex = 7;
            this.gbMarcas.TabStop = false;
            this.gbMarcas.Text = "Datos de Marca";
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
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarMarca.Location = new System.Drawing.Point(369, 72);
            this.btnCancelarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(93, 34);
            this.btnCancelarMarca.TabIndex = 18;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(128, 27);
            this.txtNombreMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreMarca.MaxLength = 50;
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(333, 27);
            this.txtNombreMarca.TabIndex = 8;
            // 
            // btnActualizarMarca
            // 
            this.btnActualizarMarca.BackColor = System.Drawing.Color.Chartreuse;
            this.btnActualizarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarMarca.Location = new System.Drawing.Point(212, 72);
            this.btnActualizarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarMarca.Name = "btnActualizarMarca";
            this.btnActualizarMarca.Size = new System.Drawing.Size(93, 34);
            this.btnActualizarMarca.TabIndex = 17;
            this.btnActualizarMarca.Text = "Actualizar";
            this.btnActualizarMarca.UseVisualStyleBackColor = false;
            this.btnActualizarMarca.Click += new System.EventHandler(this.btnActualizarMarca_Click);
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarMarca.Location = new System.Drawing.Point(49, 71);
            this.btnGuardarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(93, 37);
            this.btnGuardarMarca.TabIndex = 16;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = false;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarMarca.Location = new System.Drawing.Point(388, 69);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(93, 37);
            this.btnEliminarMarca.TabIndex = 6;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnHabilitarModificarMarca
            // 
            this.btnHabilitarModificarMarca.BackColor = System.Drawing.Color.Aqua;
            this.btnHabilitarModificarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnHabilitarModificarMarca.Location = new System.Drawing.Point(231, 69);
            this.btnHabilitarModificarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabilitarModificarMarca.Name = "btnHabilitarModificarMarca";
            this.btnHabilitarModificarMarca.Size = new System.Drawing.Size(93, 37);
            this.btnHabilitarModificarMarca.TabIndex = 5;
            this.btnHabilitarModificarMarca.Text = "Modificar";
            this.btnHabilitarModificarMarca.UseVisualStyleBackColor = false;
            this.btnHabilitarModificarMarca.Click += new System.EventHandler(this.btnHabilitarModificarMarca_Click);
            // 
            // btnHabilitarNuevaMarca
            // 
            this.btnHabilitarNuevaMarca.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHabilitarNuevaMarca.ForeColor = System.Drawing.Color.Black;
            this.btnHabilitarNuevaMarca.Location = new System.Drawing.Point(68, 69);
            this.btnHabilitarNuevaMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabilitarNuevaMarca.Name = "btnHabilitarNuevaMarca";
            this.btnHabilitarNuevaMarca.Size = new System.Drawing.Size(93, 37);
            this.btnHabilitarNuevaMarca.TabIndex = 4;
            this.btnHabilitarNuevaMarca.Text = "Nuevo";
            this.btnHabilitarNuevaMarca.UseVisualStyleBackColor = false;
            this.btnHabilitarNuevaMarca.Click += new System.EventHandler(this.btnHabilitarNuevaMarca_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarMarca.Location = new System.Drawing.Point(388, 23);
            this.btnBuscarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(93, 37);
            this.btnBuscarMarca.TabIndex = 2;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(19, 251);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 29;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(516, 222);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.txtBuscarCat);
            this.groupBox2.Controls.Add(this.gbCat);
            this.groupBox2.Controls.Add(this.btnEliminarCat);
            this.groupBox2.Controls.Add(this.btnHabilitarModificarCat);
            this.groupBox2.Controls.Add(this.btnHabilitarNuevaCat);
            this.groupBox2.Controls.Add(this.btnBuscarCat);
            this.groupBox2.Controls.Add(this.dgvCategorias);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(753, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(555, 502);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CATEGORÍAS";
            // 
            // txtBuscarCat
            // 
            this.txtBuscarCat.Location = new System.Drawing.Point(68, 29);
            this.txtBuscarCat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtBuscarCat.Name = "txtBuscarCat";
            this.txtBuscarCat.Size = new System.Drawing.Size(299, 27);
            this.txtBuscarCat.TabIndex = 23;
            // 
            // gbCat
            // 
            this.gbCat.Controls.Add(this.label2);
            this.gbCat.Controls.Add(this.btnCancelarCat);
            this.gbCat.Controls.Add(this.txtNombreCat);
            this.gbCat.Controls.Add(this.btnActualizarCat);
            this.gbCat.Controls.Add(this.btnGuardarCat);
            this.gbCat.Location = new System.Drawing.Point(19, 116);
            this.gbCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCat.Name = "gbCat";
            this.gbCat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCat.Size = new System.Drawing.Size(516, 131);
            this.gbCat.TabIndex = 7;
            this.gbCat.TabStop = false;
            this.gbCat.Text = "Datos de Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarCat.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCat.Location = new System.Drawing.Point(369, 72);
            this.btnCancelarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(93, 34);
            this.btnCancelarCat.TabIndex = 18;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = false;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(128, 27);
            this.txtNombreCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCat.MaxLength = 50;
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(333, 27);
            this.txtNombreCat.TabIndex = 8;
            // 
            // btnActualizarCat
            // 
            this.btnActualizarCat.BackColor = System.Drawing.Color.Chartreuse;
            this.btnActualizarCat.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarCat.Location = new System.Drawing.Point(212, 72);
            this.btnActualizarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarCat.Name = "btnActualizarCat";
            this.btnActualizarCat.Size = new System.Drawing.Size(93, 34);
            this.btnActualizarCat.TabIndex = 17;
            this.btnActualizarCat.Text = "Actualizar";
            this.btnActualizarCat.UseVisualStyleBackColor = false;
            this.btnActualizarCat.Click += new System.EventHandler(this.btnActualizarCat_Click);
            // 
            // btnGuardarCat
            // 
            this.btnGuardarCat.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardarCat.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarCat.Location = new System.Drawing.Point(49, 71);
            this.btnGuardarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCat.Name = "btnGuardarCat";
            this.btnGuardarCat.Size = new System.Drawing.Size(93, 37);
            this.btnGuardarCat.TabIndex = 16;
            this.btnGuardarCat.Text = "Guardar";
            this.btnGuardarCat.UseVisualStyleBackColor = false;
            this.btnGuardarCat.Click += new System.EventHandler(this.btnGuardarCat_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarCat.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCat.Location = new System.Drawing.Point(388, 69);
            this.btnEliminarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(93, 37);
            this.btnEliminarCat.TabIndex = 6;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnHabilitarModificarCat
            // 
            this.btnHabilitarModificarCat.BackColor = System.Drawing.Color.Aqua;
            this.btnHabilitarModificarCat.ForeColor = System.Drawing.Color.Black;
            this.btnHabilitarModificarCat.Location = new System.Drawing.Point(231, 69);
            this.btnHabilitarModificarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabilitarModificarCat.Name = "btnHabilitarModificarCat";
            this.btnHabilitarModificarCat.Size = new System.Drawing.Size(93, 37);
            this.btnHabilitarModificarCat.TabIndex = 5;
            this.btnHabilitarModificarCat.Text = "Modificar";
            this.btnHabilitarModificarCat.UseVisualStyleBackColor = false;
            this.btnHabilitarModificarCat.Click += new System.EventHandler(this.btnHabilitarModificarCat_Click);
            // 
            // btnHabilitarNuevaCat
            // 
            this.btnHabilitarNuevaCat.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHabilitarNuevaCat.ForeColor = System.Drawing.Color.Black;
            this.btnHabilitarNuevaCat.Location = new System.Drawing.Point(68, 69);
            this.btnHabilitarNuevaCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabilitarNuevaCat.Name = "btnHabilitarNuevaCat";
            this.btnHabilitarNuevaCat.Size = new System.Drawing.Size(93, 37);
            this.btnHabilitarNuevaCat.TabIndex = 4;
            this.btnHabilitarNuevaCat.Text = "Nuevo";
            this.btnHabilitarNuevaCat.UseVisualStyleBackColor = false;
            this.btnHabilitarNuevaCat.Click += new System.EventHandler(this.btnHabilitarNuevaCat_Click);
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCat.Location = new System.Drawing.Point(388, 23);
            this.btnBuscarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(93, 37);
            this.btnBuscarCat.TabIndex = 2;
            this.btnBuscarCat.Text = "Buscar";
            this.btnBuscarCat.UseVisualStyleBackColor = true;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscarCat_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(19, 251);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 29;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(516, 222);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellDoubleClick);
            // 
            // btnRefrescarTablas
            // 
            this.btnRefrescarTablas.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRefrescarTablas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescarTablas.Location = new System.Drawing.Point(542, 551);
            this.btnRefrescarTablas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefrescarTablas.Name = "btnRefrescarTablas";
            this.btnRefrescarTablas.Size = new System.Drawing.Size(373, 37);
            this.btnRefrescarTablas.TabIndex = 25;
            this.btnRefrescarTablas.Text = "REFRESCAR TODO";
            this.btnRefrescarTablas.UseVisualStyleBackColor = false;
            this.btnRefrescarTablas.Click += new System.EventHandler(this.btnRefrescarTablas_Click);
            // 
            // FormMarcasCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1467, 615);
            this.Controls.Add(this.btnRefrescarTablas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1467, 985);
            this.MinimumSize = new System.Drawing.Size(907, 492);
            this.Name = "FormMarcasCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMarcasCategorias";
            this.Load += new System.EventHandler(this.FormMarcasCategorias_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarMarca)).EndInit();
            this.gbMarcas.ResumeLayout(false);
            this.gbMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarCat)).EndInit();
            this.gbCat.ResumeLayout(false);
            this.gbCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtBuscarMarca;
        private System.Windows.Forms.GroupBox gbMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Button btnActualizarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnHabilitarModificarMarca;
        private System.Windows.Forms.Button btnHabilitarNuevaMarca;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtBuscarCat;
        private System.Windows.Forms.GroupBox gbCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarCat;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Button btnActualizarCat;
        private System.Windows.Forms.Button btnGuardarCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnHabilitarModificarCat;
        private System.Windows.Forms.Button btnHabilitarNuevaCat;
        private System.Windows.Forms.Button btnBuscarCat;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnRefrescarTablas;
    }
}