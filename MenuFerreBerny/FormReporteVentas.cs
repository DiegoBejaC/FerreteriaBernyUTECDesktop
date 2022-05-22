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
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();
        }

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigoProducto = Convert.ToInt32(txtCodigoProducto.Text);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ventasProducto' Puede moverla o quitarla según sea necesario.
            this.ventasProductoTableAdapter.verVentasProducto(this.DataSet1.ventasProducto, codigoProducto);

            this.reportViewer1.RefreshReport();
        }
    }
}
