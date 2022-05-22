
namespace MenuFerreBerny
{
    partial class FormProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.btnRefrescarListaProv = new System.Windows.Forms.Button();
            this.txtIdProv = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificarProv = new System.Windows.Forms.Button();
            this.txtDireccionProv = new System.Windows.Forms.TextBox();
            this.btnCancelarProv = new System.Windows.Forms.Button();
            this.btnCrearProv = new System.Windows.Forms.Button();
            this.txtNombreProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHabilitarCrearProv = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarProv = new System.Windows.Forms.Button();
            this.btnHabilitarModificarProv = new System.Windows.Forms.Button();
            this.btnBuscarProv = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefonoProv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescarListaProv
            // 
            this.btnRefrescarListaProv.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRefrescarListaProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarListaProv.Location = new System.Drawing.Point(796, 548);
            this.btnRefrescarListaProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarListaProv.Name = "btnRefrescarListaProv";
            this.btnRefrescarListaProv.Size = new System.Drawing.Size(217, 37);
            this.btnRefrescarListaProv.TabIndex = 34;
            this.btnRefrescarListaProv.Text = "Refrescar lista";
            this.btnRefrescarListaProv.UseVisualStyleBackColor = false;
            this.btnRefrescarListaProv.Click += new System.EventHandler(this.btnRefrescarListaProv_Click);
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(492, 108);
            this.txtIdProv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProv.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(149, 22);
            this.txtIdProv.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.txtTelefonoProv);
            this.groupBox1.Controls.Add(this.btnModificarProv);
            this.groupBox1.Controls.Add(this.txtDireccionProv);
            this.groupBox1.Controls.Add(this.btnCancelarProv);
            this.groupBox1.Controls.Add(this.btnCrearProv);
            this.groupBox1.Controls.Add(this.txtNombreProv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(332, 331);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnModificarProv
            // 
            this.btnModificarProv.BackColor = System.Drawing.Color.Aqua;
            this.btnModificarProv.Location = new System.Drawing.Point(179, 197);
            this.btnModificarProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarProv.Name = "btnModificarProv";
            this.btnModificarProv.Size = new System.Drawing.Size(139, 37);
            this.btnModificarProv.TabIndex = 22;
            this.btnModificarProv.Text = "Modificar";
            this.btnModificarProv.UseVisualStyleBackColor = false;
            this.btnModificarProv.Click += new System.EventHandler(this.btnModificarProv_Click);
            // 
            // txtDireccionProv
            // 
            this.txtDireccionProv.Location = new System.Drawing.Point(123, 127);
            this.txtDireccionProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccionProv.MaxLength = 250;
            this.txtDireccionProv.Name = "txtDireccionProv";
            this.txtDireccionProv.Size = new System.Drawing.Size(184, 26);
            this.txtDireccionProv.TabIndex = 9;
            // 
            // btnCancelarProv
            // 
            this.btnCancelarProv.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarProv.Location = new System.Drawing.Point(101, 252);
            this.btnCancelarProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarProv.Name = "btnCancelarProv";
            this.btnCancelarProv.Size = new System.Drawing.Size(139, 37);
            this.btnCancelarProv.TabIndex = 13;
            this.btnCancelarProv.Text = "Cancelar";
            this.btnCancelarProv.UseVisualStyleBackColor = false;
            this.btnCancelarProv.Click += new System.EventHandler(this.btnCancelarProv_Click);
            // 
            // btnCrearProv
            // 
            this.btnCrearProv.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCrearProv.Location = new System.Drawing.Point(19, 197);
            this.btnCrearProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearProv.Name = "btnCrearProv";
            this.btnCrearProv.Size = new System.Drawing.Size(139, 37);
            this.btnCrearProv.TabIndex = 1;
            this.btnCrearProv.Text = "Crear";
            this.btnCrearProv.UseVisualStyleBackColor = false;
            this.btnCrearProv.Click += new System.EventHandler(this.btnCrearProv_Click);
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.Location = new System.Drawing.Point(123, 44);
            this.txtNombreProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreProv.MaxLength = 150;
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.Size = new System.Drawing.Size(184, 26);
            this.txtNombreProv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección:";
            // 
            // btnHabilitarCrearProv
            // 
            this.btnHabilitarCrearProv.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHabilitarCrearProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarCrearProv.Location = new System.Drawing.Point(889, 101);
            this.btnHabilitarCrearProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHabilitarCrearProv.Name = "btnHabilitarCrearProv";
            this.btnHabilitarCrearProv.Size = new System.Drawing.Size(200, 37);
            this.btnHabilitarCrearProv.TabIndex = 31;
            this.btnHabilitarCrearProv.Text = "Agregar Proveedor";
            this.btnHabilitarCrearProv.UseVisualStyleBackColor = false;
            this.btnHabilitarCrearProv.Click += new System.EventHandler(this.btnHabilitarCrearProv_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(789, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 38);
            this.label7.TabIndex = 30;
            this.label7.Text = "PROVEEDORES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightYellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID:";
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProv.Location = new System.Drawing.Point(1280, 101);
            this.btnEliminarProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Size = new System.Drawing.Size(109, 37);
            this.btnEliminarProv.TabIndex = 28;
            this.btnEliminarProv.Text = "Eliminar";
            this.btnEliminarProv.UseVisualStyleBackColor = false;
            this.btnEliminarProv.Click += new System.EventHandler(this.btnEliminarProv_Click);
            // 
            // btnHabilitarModificarProv
            // 
            this.btnHabilitarModificarProv.BackColor = System.Drawing.Color.Aqua;
            this.btnHabilitarModificarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarModificarProv.Location = new System.Drawing.Point(1125, 101);
            this.btnHabilitarModificarProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHabilitarModificarProv.Name = "btnHabilitarModificarProv";
            this.btnHabilitarModificarProv.Size = new System.Drawing.Size(119, 37);
            this.btnHabilitarModificarProv.TabIndex = 27;
            this.btnHabilitarModificarProv.Text = "Modificar";
            this.btnHabilitarModificarProv.UseVisualStyleBackColor = false;
            this.btnHabilitarModificarProv.Click += new System.EventHandler(this.btnHabilitarModificarProv_Click);
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProv.Location = new System.Drawing.Point(651, 101);
            this.btnBuscarProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(109, 37);
            this.btnBuscarProv.TabIndex = 26;
            this.btnBuscarProv.Text = "Buscar";
            this.btnBuscarProv.UseVisualStyleBackColor = true;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(392, 161);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 25;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(1039, 354);
            this.dgvProveedores.TabIndex = 25;
            this.dgvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Location = new System.Drawing.Point(375, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 464);
            this.panel1.TabIndex = 35;
            // 
            // txtTelefonoProv
            // 
            this.txtTelefonoProv.Location = new System.Drawing.Point(123, 84);
            this.txtTelefonoProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoProv.MaxLength = 8;
            this.txtTelefonoProv.Name = "txtTelefonoProv";
            this.txtTelefonoProv.Size = new System.Drawing.Size(184, 26);
            this.txtTelefonoProv.TabIndex = 23;
            this.txtTelefonoProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoProv_KeyPress_1);
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1467, 615);
            this.Controls.Add(this.btnRefrescarListaProv);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHabilitarCrearProv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminarProv);
            this.Controls.Add(this.btnHabilitarModificarProv);
            this.Controls.Add(this.btnBuscarProv);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(907, 492);
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescarListaProv;
        private System.Windows.Forms.NumericUpDown txtIdProv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificarProv;
        private System.Windows.Forms.TextBox txtDireccionProv;
        private System.Windows.Forms.Button btnCancelarProv;
        private System.Windows.Forms.Button btnCrearProv;
        private System.Windows.Forms.TextBox txtNombreProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHabilitarCrearProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarProv;
        private System.Windows.Forms.Button btnHabilitarModificarProv;
        private System.Windows.Forms.Button btnBuscarProv;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTelefonoProv;
    }
}