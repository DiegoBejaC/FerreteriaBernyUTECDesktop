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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();
        }

        private void FormReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ProductosMarcasCategorias' Puede moverla o quitarla según sea necesario.
            this.ProductosMarcasCategoriasTableAdapter.FillProductos(this.DataSet1.ProductosMarcasCategorias);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String cateogia = Convert.ToString(txtCategoria.Text);
            this.ProductosMarcasCategoriasTableAdapter.FillByCategoria(this.DataSet1.ProductosMarcasCategorias, cateogia);
            this.reportViewer1.RefreshReport();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            String marca = Convert.ToString(txtMarca.Text);
            this.ProductosMarcasCategoriasTableAdapter.FillByMarca(this.DataSet1.ProductosMarcasCategorias, marca);
            this.reportViewer1.RefreshReport();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            String nombreProd = Convert.ToString(txtNombre.Text);
            this.ProductosMarcasCategoriasTableAdapter.FillByNombreProd(this.DataSet1.ProductosMarcasCategorias, nombreProd);
            this.reportViewer1.RefreshReport();
        }
    }
}
