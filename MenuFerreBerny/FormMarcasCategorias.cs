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
    public partial class FormMarcasCategorias : Form
    {
        Marcas oMarcas = null;
        Categorias oCategorias = null;
        public FormMarcasCategorias()
        {
            InitializeComponent();
            ActualizarCategorias();
            ActualizarMarcas();
        }

        private void FormMarcasCategorias_Load(object sender, EventArgs e)
        {
            OnControlesMarcas();
            OnControlesCategorias();
        }

        public void ActualizarMarcas() {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from d in db.Marcas
                          select new
                          {
                              Id = d.Id,
                              Nombre = d.Nombre,
                          };
                dgvMarcas.DataSource = lst.ToList();
            }
        }
        public void ActualizarCategorias()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from d in db.Categorias
                          select new
                          {
                              Id = d.Id,
                              Nombre = d.Nombre,
                          };
                dgvCategorias.DataSource = lst.ToList();
            }
        }

        private void OnControlesMarcas()
        {
            txtNombreMarca.Enabled = false;
            btnGuardarMarca.Enabled = false;
            btnActualizarMarca.Enabled = false;
            btnCancelarMarca.Enabled = false;

            txtBuscarMarca.Enabled = true;
            btnBuscarMarca.Enabled = true;
            btnHabilitarNuevaMarca.Enabled = true;
            btnHabilitarModificarMarca.Enabled = true;
            btnEliminarMarca.Enabled = true;
        }

        private void OnControlesCategorias()
        {
            txtNombreCat.Enabled = false;
            btnGuardarCat.Enabled = false;
            btnActualizarCat.Enabled = false;
            btnCancelarCat.Enabled = false;

            txtBuscarCat.Enabled = true;
            btnBuscarCat.Enabled = true;
            btnHabilitarNuevaCat.Enabled = true;
            btnHabilitarModificarCat.Enabled = true;
            btnEliminarCat.Enabled = true;
        }

        private void OffControlesMarcas()
        {
            txtNombreMarca.Enabled = true;
            btnGuardarMarca.Enabled = true;
            btnActualizarMarca.Enabled = true;
            btnCancelarMarca.Enabled = true;

            txtBuscarMarca.Enabled = false;
            btnBuscarMarca.Enabled = false;
            btnHabilitarNuevaMarca.Enabled = false;
            btnHabilitarModificarMarca.Enabled = false;
            btnEliminarMarca.Enabled = false;
        }

        private void OffControlesCategorias()
        {
            txtNombreCat.Enabled = true;
            btnGuardarCat.Enabled = true;
            btnActualizarCat.Enabled = true;
            btnCancelarCat.Enabled = true;

            txtBuscarCat.Enabled = false;
            btnBuscarCat.Enabled = false;
            btnHabilitarNuevaCat.Enabled = false;
            btnHabilitarModificarCat.Enabled = false;
            btnEliminarCat.Enabled = false;
        }

        private void VaciarCamposMarcas()
        {
            txtNombreMarca.Text = "";
        }

        private void VaciarCamposCategorias()
        {
            txtNombreCat.Text = "";
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarMarca.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oMarcas = db.Marcas.Find(id);
                if (oMarcas != null)
                {
                    var lst = from d in db.Marcas
                              where d.Id == id
                              select new
                              {
                                  Id = d.Id,
                                  Nombre = d.Nombre,
                              };
                    dgvMarcas.DataSource = lst.ToList();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                    ActualizarMarcas();
                }
            }
        }

        private void btnBuscarCat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarCat.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oCategorias = db.Categorias.Find(id);
                if (oCategorias != null)
                {
                    var lst = from d in db.Categorias
                              where d.Id == id
                              select new
                              {
                                  Id = d.Id,
                                  Nombre = d.Nombre,
                              };
                    dgvCategorias.DataSource = lst.ToList();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                    ActualizarCategorias();
                }
            }
        }

        private void btnRefrescarTablas_Click(object sender, EventArgs e)
        {
            ActualizarMarcas();
            ActualizarCategorias();
        }

        private void btnHabilitarNuevaMarca_Click(object sender, EventArgs e)
        {
            VaciarCamposMarcas();
            OffControlesMarcas();
            btnActualizarMarca.Enabled = false;
        }

        private void btnHabilitarNuevaCat_Click(object sender, EventArgs e)
        {
            VaciarCamposCategorias();
            OffControlesCategorias();
            btnActualizarCat.Enabled = false;
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarMarca.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oMarcas = db.Marcas.Find(id);
                if (oMarcas != null)
                {
                    db.Marcas.Remove(oMarcas);
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                }
            }
            ActualizarMarcas();
            VaciarCamposMarcas();
            OnControlesMarcas();
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarCat.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oCategorias = db.Categorias.Find(id);
                if (oCategorias != null)
                {
                    db.Categorias.Remove(oCategorias);
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                }
            }
            ActualizarCategorias();
            VaciarCamposCategorias();
            OnControlesCategorias();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            VaciarCamposMarcas();
            OnControlesMarcas();
        }

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            VaciarCamposCategorias();
            OnControlesCategorias();
        }

        private void btnHabilitarModificarMarca_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarMarca.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oMarcas = db.Marcas.Find(id);
                //Determina si el form está lleno con los valores del ID que se quiere modificar y que SI
                //haya encontrado un valor para modificar
                if (oMarcas != null && txtNombreMarca.Text != "")
                {
                    //Determina si los valores en el form corresponden a los de ese ID y no los de otro ID
                    if (oMarcas.Nombre == txtNombreMarca.Text)
                    {
                        //Resultado
                        OffControlesMarcas();
                        btnGuardarMarca.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Los valores no corresponden. \nHaga doble clic sobre el valor a modificar");
                        ActualizarMarcas();
                        VaciarCamposMarcas();
                        OnControlesMarcas();
                    }
                }
                else
                {
                    MessageBox.Show("Haga doble clic sobre el valor a modificar");
                    ActualizarMarcas();
                    VaciarCamposMarcas();
                    OnControlesMarcas();
                }
            }
        }

        private void btnHabilitarModificarCat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarCat.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oCategorias = db.Categorias.Find(id);
                //Determina si el form está lleno con los valores del ID que se quiere modificar y que SI
                //haya encontrado un valor para modificar
                if (oCategorias != null && txtNombreCat.Text != "")
                {
                    //Determina si los valores en el form corresponden a los de ese ID y no los de otro ID
                    if (oCategorias.Nombre == txtNombreCat.Text)
                    {
                        //Resultado
                        OffControlesCategorias();
                        btnGuardarCat.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Los valores no corresponden. \nHaga doble clic sobre el valor a modificar");
                        ActualizarCategorias();
                        VaciarCamposCategorias();
                        OnControlesCategorias();
                    }
                }
                else
                {
                    MessageBox.Show("Haga doble clic sobre el valor a modificar");
                    ActualizarCategorias();
                    VaciarCamposCategorias();
                    OnControlesCategorias();
                }
            }
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (txtNombreMarca.Text != "")
            {
                //Creando el nuevo proveedor
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oMarcas = new Marcas();
                    oMarcas.Nombre = txtNombreMarca.Text;

                    db.Marcas.Add(oMarcas);
                    db.SaveChanges();
                }
                MessageBox.Show("Registro agregado con éxito");
                ActualizarMarcas();
                VaciarCamposMarcas();
                OnControlesMarcas();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            if (txtNombreCat.Text != "")
            {
                //Creando el nuevo proveedor
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oCategorias = new Categorias();
                    oCategorias.Nombre = txtNombreCat.Text;

                    db.Categorias.Add(oCategorias);
                    db.SaveChanges();
                }
                MessageBox.Show("Registro agregado con éxito");
                ActualizarCategorias();
                VaciarCamposCategorias();
                OnControlesCategorias();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnActualizarMarca_Click(object sender, EventArgs e)
        {
            if (txtNombreMarca.Text != "")
            {
                //Modificando el proveedor
                int id = Convert.ToInt32(txtBuscarMarca.Text);
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oMarcas = db.Marcas.Find(id);
                    oMarcas.Nombre = txtNombreMarca.Text;

                    db.Entry(oMarcas).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                MessageBox.Show("Registro modificado con éxito");
                ActualizarMarcas();
                VaciarCamposMarcas();
                OnControlesMarcas();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnActualizarCat_Click(object sender, EventArgs e)
        {
            if (txtNombreCat.Text != "")
            {
                //Modificando el proveedor
                int id = Convert.ToInt32(txtBuscarCat.Text);
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oCategorias = db.Categorias.Find(id);
                    oCategorias.Nombre = txtNombreCat.Text;

                    db.Entry(oCategorias).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                MessageBox.Show("Registro modificado con éxito");
                ActualizarCategorias();
                VaciarCamposCategorias();
                OnControlesCategorias();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBuscarMarca.Text = this.dgvMarcas.SelectedRows[0].Cells[0].Value.ToString();
                txtNombreMarca.Text = this.dgvMarcas.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBuscarCat.Text = this.dgvCategorias.SelectedRows[0].Cells[0].Value.ToString();
                txtNombreCat.Text = this.dgvCategorias.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
