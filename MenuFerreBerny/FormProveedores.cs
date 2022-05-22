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
using MenuFerreBerny;
using MenuFerreBerny.Models;

namespace MenuFerreBerny
{
    public partial class FormProveedores : Form
    {
        Proveedores oProveedores = null;
        public FormProveedores()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        public void ActualizarLista()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from d in db.Proveedores
                          select new {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Telefono = d.Telefono,
                            Direccion = d.Direccion
                          };
                dgvProveedores.DataSource = lst.ToList();
            }
        }

        private void DeshabilitarControles()
        {
            txtNombreProv.Enabled = false;
            txtTelefonoProv.Enabled = false;
            txtDireccionProv.Enabled = false;
            btnCrearProv.Enabled = false;
            btnCancelarProv.Enabled = false;
            btnModificarProv.Enabled = false;
            btnHabilitarCrearProv.Enabled = true;
            btnHabilitarModificarProv.Enabled = true;
            btnBuscarProv.Enabled = true;
            btnEliminarProv.Enabled = true;
            txtIdProv.Enabled = true;
        }

        //Activa el form mostrado a la izquierda
        private void HabilitarControles()
        {
            txtNombreProv.Enabled = true;
            txtTelefonoProv.Enabled = true;
            txtDireccionProv.Enabled = true;
            btnCrearProv.Enabled = true;
            btnCancelarProv.Enabled = true;
            btnModificarProv.Enabled = true;
            btnHabilitarCrearProv.Enabled = false;
            btnHabilitarModificarProv.Enabled = false;
            btnBuscarProv.Enabled = false;
            btnEliminarProv.Enabled = false;
            txtIdProv.Enabled = false;
        }

        //Vacia los càmpos del form una vez se deshabilta
        private void VaciarCampos()
        {
            txtNombreProv.Text = "";
            txtTelefonoProv.Text = "";
            txtDireccionProv.Text = "";
        }

        //PARA poder extraer datos de una fila del dgv
        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdProv.Text = this.dgvProveedores.SelectedRows[0].Cells[0].Value.ToString();
                txtNombreProv.Text = this.dgvProveedores.SelectedRows[0].Cells[1].Value.ToString();
                txtTelefonoProv.Text = this.dgvProveedores.SelectedRows[0].Cells[2].Value.ToString();
                txtDireccionProv.Text = this.dgvProveedores.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }



        //TODOS LOS MÈTODOS DE LOS BOTONES

        private void btnRefrescarListaProv_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnHabilitarCrearProv_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            HabilitarControles();
            btnModificarProv.Enabled = false;
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProv.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oProveedores = db.Proveedores.Find(id);
                if (oProveedores != null)
                {
                    var lst = from d in db.Proveedores
                              where d.Id == id
                              select new
                              {
                                  Id = d.Id,
                                  Nombre = d.Nombre,
                                  Telefono = d.Telefono,
                                  Direccion = d.Direccion
                              };
                    dgvProveedores.DataSource = lst.ToList();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                    ActualizarLista();
                }
            }
        }

        private void btnHabilitarModificarProv_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProv.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oProveedores = db.Proveedores.Find(id);
                //Determina si el form está lleno con los valores del ID que se quiere modificar y que SI
                //haya encontrado un valor para modificar
                if (oProveedores != null && txtNombreProv.Text != "")
                {
                    //Determina si los valores en el form corresponden a los de ese ID y no los de otro ID
                    if (oProveedores.Nombre == txtNombreProv.Text)
                    {
                        //Resultado
                        HabilitarControles();
                        btnCrearProv.Enabled = false;
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

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProv.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oProveedores = db.Proveedores.Find(id);
                if (oProveedores != null)
                {
                    db.Proveedores.Remove(oProveedores);
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                }
            }
            ActualizarLista();
            VaciarCampos();
            DeshabilitarControles();
        }

        private void btnCrearProv_Click(object sender, EventArgs e)
        {
            if (txtNombreProv.Text != "" && txtTelefonoProv.Text != "" && txtDireccionProv.Text != "") {
                //Creando el nuevo proveedor
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oProveedores = new Proveedores();
                    oProveedores.Nombre = txtNombreProv.Text;
                    oProveedores.Telefono = txtTelefonoProv.Text;
                    oProveedores.Direccion = txtDireccionProv.Text;

                    db.Proveedores.Add(oProveedores);
                    db.SaveChanges();
                }
                MessageBox.Show("Registro agregado con éxito");
                ActualizarLista();
                VaciarCampos();
                DeshabilitarControles();
            }
            else {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            if (txtNombreProv.Text != "" && txtTelefonoProv.Text != "" && txtDireccionProv.Text != "")
            {
                //Modificando el proveedor
                int id = Convert.ToInt32(txtIdProv.Text);
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oProveedores = db.Proveedores.Find(id);
                    oProveedores.Nombre = txtNombreProv.Text;
                    oProveedores.Telefono = txtTelefonoProv.Text;
                    oProveedores.Direccion = txtDireccionProv.Text;

                    db.Entry(oProveedores).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                MessageBox.Show("Registro modificado con éxito");
                ActualizarLista();
                VaciarCampos();
                DeshabilitarControles();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnCancelarProv_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            DeshabilitarControles();
        }

        private void txtTelefonoProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoProv_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
