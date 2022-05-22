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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            FormKardex formKardex = new FormKardex();
            formKardex.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReporteVentas frmRVentas = new FormReporteVentas();
            frmRVentas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReporteProductos frmRepProd = new FormReporteProductos();
            frmRepProd.Show();
        }
    }
}
