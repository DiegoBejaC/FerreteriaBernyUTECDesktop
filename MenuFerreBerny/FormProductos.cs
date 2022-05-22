using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuFerreBerny.Models;

namespace MenuFerreBerny
{
    public partial class FormProductos : Form
    {
        Productos oProductos = null;
        public FormProductos()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            cargarMarcas();
            cargarCategorias();
            ActualizarLista();
        }

        public void ActualizarLista() {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from d in db.Productos
                          select new
                          {
                              Id = d.Id,
                              Nombre = d.Nombre,
                              Id_Marca = d.Id_Marca,
                              Id_Categoria = d.Id_Categoria,
                              StockMinimo = d.StockMinimo,
                              StockMaximo = d.StockMaximo,
                              Existencia = d.Existencia,
                              PrecioUnitario = d.PrecioUnitario
                          };
                var lst2 = from p in db.Productos join c in db.Categorias on p.Id_Categoria equals c.Id
                           join m in db.Marcas on p.Id_Marca equals m.Id select new {
                               Id = p.Id,
                               Nombre = p.Nombre,
                               Marca = m.Nombre,
                               Categoria = c.Nombre,
                               StockMinimo = p.StockMinimo,
                               StockMaximo = p.StockMaximo,
                               Existencia = p.Existencia,
                               PrecioUnitario = p.PrecioUnitario
                           };
                dgvProductos.DataSource = lst2.ToList();
            }
        }

        //Metodo para cargar el cmbCatProd
        public void cargarCategorias() {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities()) {
                var listaCategorias = (from d in db.Categorias
                                   select d).ToList();
                cmbCatProd.DataSource = listaCategorias;
                cmbCatProd.DisplayMember = "Nombre";
                cmbCatProd.ValueMember = "Id";
            }
        }

        //Metodo para cargar el cmbMarcaProd
        public void cargarMarcas()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var listaMarcas = (from d in db.Marcas
                                   select d).ToList();
                cmbMarcaProd.DataSource = listaMarcas;
                cmbMarcaProd.DisplayMember = "Nombre";
                cmbMarcaProd.ValueMember = "Id";
            }
        }

        //Para deshabilitar los controles
        private void DeshabilitarControles()
        {
            txtNombreProd.Enabled = false;
            cmbMarcaProd.Enabled = false;
            cmbCatProd.Enabled = false;
            txtStockMin.Enabled = false;
            txtStockMax.Enabled = false;
            txtExistenciaProd.Enabled = false;
            txtPrecioProd.Enabled = false;
            btnCrearProd.Enabled = false;
            btnCancelarProd.Enabled = false;
            btnModificarProd.Enabled = false;
            btnHabilitarCrearProd.Enabled = true;
            btnHabilitarModificarProd.Enabled = true;
            btnBuscarProd.Enabled = true;
            btnEliminarProd.Enabled = true;
            txtIdProd.Enabled = true;
        }

        //Activa el form mostrado a la izquierda
        private void HabilitarControles()
        {
            txtNombreProd.Enabled = true;
            cmbMarcaProd.Enabled = true;
            cmbCatProd.Enabled = true;
            txtStockMin.Enabled = true;
            txtStockMax.Enabled = true;
            txtExistenciaProd.Enabled = true;
            txtPrecioProd.Enabled = true;
            btnCrearProd.Enabled = true;
            btnCancelarProd.Enabled = true;
            btnModificarProd.Enabled = true;
            btnHabilitarCrearProd.Enabled = false;
            btnHabilitarModificarProd.Enabled = false;
            btnBuscarProd.Enabled = false;
            btnEliminarProd.Enabled = false;
            txtIdProd.Enabled = false;
        }

        //Vacia los càmpos del form una vez se deshabilta
        private void VaciarCampos()
        {
            txtIdProd.Value = 0;
            txtNombreProd.Text = "";
            cmbMarcaProd.SelectedIndex = 0;
            cmbCatProd.SelectedIndex = 0;
            txtStockMin.Value = 0;
            txtStockMax.Value = 0;
            txtExistenciaProd.Value = 0;
            txtPrecioProd.Text = "";
        }


        // AQUI HAY QUE MODIFICARLOS PARA QUE SI PUEDAN SER UTILIZADOS PARA ESTE CRUD
        // ---------------------------------------------------------------

        // Cargar el form con los datos de la tabla


        //Todos los métodos de los botones!!!
        private void btnRefrescarListaProd_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnHabilitarCrearProd_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            VaciarCampos();
            btnModificarProd.Enabled = false;
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProd.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oProductos = db.Productos.Find(id);
                if (oProductos != null)
                {
                    var lst = from d in db.Productos
                              where d.Id == id
                              select new
                              {
                                  Id = d.Id,
                                  Nombre = d.Nombre,
                                  Id_Marca = d.Id_Marca,
                                  Id_Categoria = d.Id_Categoria,
                                  StockMinimo = d.StockMinimo,
                                  StockMaximo = d.StockMaximo,
                                  Existencia = d.Existencia,
                                  PrecioUnitario = d.PrecioUnitario
                              };
                    var lst2 = from p in db.Productos
                               join c in db.Categorias on p.Id_Categoria equals c.Id
                               join m in db.Marcas on p.Id_Marca equals m.Id
                               where p.Id == id
                               select new
                               {
                                   Id = p.Id,
                                   Nombre = p.Nombre,
                                   Marca = m.Nombre,
                                   Categoria = c.Nombre,
                                   StockMinimo = p.StockMinimo,
                                   StockMaximo = p.StockMaximo,
                                   Existencia = p.Existencia,
                                   PrecioUnitario = p.PrecioUnitario
                               };
                    dgvProductos.DataSource = lst2.ToList();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro!");
                    ActualizarLista();
                }
            }
        }

        private void btnHabilitarModificarProd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProd.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oProductos = db.Productos.Find(id);
                //Determina si el form está lleno con los valores del ID que se quiere modificar y que SI
                //haya encontrado un valor para modificar
                if (oProductos != null && txtNombreProd.Text != "")
                {
                    //Determina si los valores en el form corresponden a los de ese ID y no los de otro ID
                    if (oProductos.Nombre == txtNombreProd.Text)
                    {
                        //RESULTADO
                        HabilitarControles();
                        btnCrearProd.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Los valores no corresponden. \nHaga doble clic sobre el valor a modificar");
                        ActualizarLista();
                        VaciarCampos();
                        DeshabilitarControles();
                    }
                }
                else
                {
                    MessageBox.Show("Haga doble clic sobre el valor a modificar");
                    ActualizarLista();
                    VaciarCampos();
                    DeshabilitarControles();
                }
            }
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            //Eliminando el proveedor
            int id = Convert.ToInt32(txtIdProd.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oProductos = db.Productos.Find(id);
                if (oProductos != null)
                {
                    db.Productos.Remove(oProductos);
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado con éxito");
                }
                else {
                    MessageBox.Show("No se encuentra el registro!");
                }               
            }
            ActualizarLista();
            VaciarCampos();
            DeshabilitarControles();
        }

        private void btnCrearProd_Click(object sender, EventArgs e)
        {
            int sMin = Convert.ToInt32(txtStockMin.Text);
            int sMax = Convert.ToInt32(txtStockMax.Text);
            int exis = Convert.ToInt32(txtExistenciaProd.Text);
            if (txtNombreProd.Text != "" && sMin != 0 && sMax != 0 && exis != 0 && txtPrecioProd.Text != "")
            {
                //Aquí comienzan las demás validaciones
                if (sMin < sMax)
                {
                    int diferencia = sMax - sMin;
                    if (diferencia >= 100)
                    {
                        if (exis >= sMin && exis <= sMax)
                        {
                            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                            {
                                oProductos = new Productos();
                                oProductos.Nombre = txtNombreProd.Text;
                                oProductos.Id_Marca = Convert.ToInt32(cmbMarcaProd.SelectedValue);
                                oProductos.Id_Categoria = Convert.ToInt32(cmbCatProd.SelectedValue);
                                oProductos.StockMinimo = Convert.ToInt32(txtStockMin.Text);
                                oProductos.StockMaximo = Convert.ToInt32(txtStockMax.Text);
                                oProductos.Existencia = Convert.ToInt32(txtExistenciaProd.Text);
                                oProductos.PrecioUnitario = (decimal?)Convert.ToDouble(txtPrecioProd.Text);

                                db.Productos.Add(oProductos);
                                db.SaveChanges();
                            }
                            MessageBox.Show("Registro agregado con éxito");
                            ActualizarLista();
                            VaciarCampos();
                            DeshabilitarControles();
                        }
                        else
                        {
                            MessageBox.Show("La cantidad de existencias debe estar entre el rango de stocks");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entre los stocks debe habe un intervalo de al menos 100 unidades");
                    }
                }
                else
                {
                    MessageBox.Show("El stock mínimo debe ser MENOR que el stock máximo");
                }
            }
            else {
                MessageBox.Show("Rellene TODOS los campos");
            }
        }

        private void btnModificarProd_Click(object sender, EventArgs e)
        {
            int sMin = Convert.ToInt32(txtStockMin.Text);
            int sMax = Convert.ToInt32(txtStockMax.Text);
            int exis = Convert.ToInt32(txtExistenciaProd.Text);
            if (txtNombreProd.Text != "" && sMin != 0 && sMax != 0 && exis != 0 && txtPrecioProd.Text != "")
            {
                //Aquí comienzan las demás validaciones
                if (sMin < sMax)
                {
                    int diferencia = sMax - sMin;
                    if (diferencia >= 100)
                    {
                        if (exis >= sMin && exis <= sMax)
                        {
                            int id = Convert.ToInt32(txtIdProd.Text);
                            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                            {
                                oProductos = db.Productos.Find(id);
                                oProductos.Nombre = txtNombreProd.Text;
                                oProductos.Id_Marca = Convert.ToInt32(cmbMarcaProd.SelectedValue);
                                oProductos.Id_Categoria = Convert.ToInt32(cmbCatProd.SelectedValue);
                                oProductos.StockMinimo = Convert.ToInt32(txtStockMin.Text);
                                oProductos.StockMaximo = Convert.ToInt32(txtStockMax.Text);
                                oProductos.Existencia = Convert.ToInt32(txtExistenciaProd.Text);
                                oProductos.PrecioUnitario = (decimal?)Convert.ToDouble(txtPrecioProd.Text);

                                db.Entry(oProductos).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();
                                MessageBox.Show("Registro modificado con éxito");
                            }
                            ActualizarLista();
                            VaciarCampos();
                            DeshabilitarControles();
                        }
                        else
                        {
                            MessageBox.Show("La cantidad de existencias debe estar entre el rango de stocks");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entre los stocks debe habe un intervalo de al menos 100 unidades");
                    }
                }
                else
                {
                    MessageBox.Show("El stock mínimo debe ser MENOR que el stock máximo");
                }
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos");
            }
        }

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            DeshabilitarControles();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdProd.Text = this.dgvProductos.SelectedRows[0].Cells[0].Value.ToString();
                txtNombreProd.Text = this.dgvProductos.SelectedRows[0].Cells[1].Value.ToString();
                cmbMarcaProd.Text = this.dgvProductos.SelectedRows[0].Cells[2].Value.ToString();
                cmbCatProd.Text = this.dgvProductos.SelectedRows[0].Cells[3].Value.ToString();
                txtStockMin.Text = this.dgvProductos.SelectedRows[0].Cells[4].Value.ToString();
                txtStockMax.Text = this.dgvProductos.SelectedRows[0].Cells[5].Value.ToString();
                txtExistenciaProd.Text = this.dgvProductos.SelectedRows[0].Cells[6].Value.ToString();
                txtPrecioProd.Text = this.dgvProductos.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }
        //Método para que el campo del precio unitario sólo acepte números con un punto decimal.
        private void txtPrecioProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
