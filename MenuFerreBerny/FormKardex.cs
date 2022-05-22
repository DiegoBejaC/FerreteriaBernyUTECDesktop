using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuFerreBerny
{
    public partial class FormKardex : Form
    {
        public FormKardex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int codigoProducto = Convert.ToInt32(txtCodigoProducto.Text);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.ComprasProductosParametrizado(this.DataSet1.DataTable1, codigoProducto);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Productos' Puede moverla o quitarla según sea necesario.
            //  this.ProductosTableAdapter.Fill(this.DataSet1.Productos);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
