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
    public partial class FormUsuarios : Form
    {
        Usuarios oUsuarios = null;
        public FormUsuarios()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        // Cargar el form con los datos de la tabla
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        public void ActualizarLista() {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from d in db.Usuarios
                          select d;
                dgvUsuarios.DataSource = lst.ToList();
            }
        }

        //Desactiva el form mostrado a la izquierda
        private void DeshabilitarControles()
        {
            txtUsuario.Enabled = false;
            txtClave.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtNivel.Enabled = false;
            btnCrearUser.Enabled = false;
            btnCancelarUser.Enabled = false;
            btnModificarUser.Enabled = false;
            btnHabilitarCrear.Enabled = true;
            btnHabilitarModificar.Enabled = true;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = true;
            txtId.Enabled = true;
        }

        //Activa el form mostrado a la izquierda
        private void HabilitarControles() {
            txtUsuario.Enabled = true;
            txtClave.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtNivel.Enabled = true;
            btnCrearUser.Enabled = true;
            btnCancelarUser.Enabled = true;
            btnHabilitarCrear.Enabled = false;
            btnModificarUser.Enabled = true;
            btnHabilitarModificar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            txtId.Enabled = false;
        }

        //Vacia los càmpos del form una vez se deshabilta
        private void VaciarCampos() {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtNivel.Text = "";
        }
        
        // TODOS LOS MÉTODOS PARA CUANDO SE PRESIONAN LOS BOTONES
        // Para el botón "Buscar"

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oUsuarios = db.Usuarios.Find(id);
                if (oUsuarios != null)
                {
                    var lst = from d in db.Usuarios
                              where d.Id == id
                              select d;
                    dgvUsuarios.DataSource = lst.ToList();
                }
                else {
                    MessageBox.Show("No se encuentra el registro");
                    ActualizarLista();
                }  
            }
        }

        // Para el botón "Eliminar"

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminando el usuario
            int id = Convert.ToInt32(txtId.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oUsuarios = db.Usuarios.Find(id);
                if (oUsuarios != null)
                {
                    db.Usuarios.Remove(oUsuarios);
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado con éxito");
                }
                else {
                    MessageBox.Show("No se encuentra el registro");
                }
            }
            ActualizarLista();
            VaciarCampos();
            DeshabilitarControles();
        }

        //Para el botón que habilita el form para Crear
        private void btnHabilitarCrear_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            HabilitarControles();
            btnModificarUser.Enabled = false;
        }

        //Para cancelar el uso del form izquierdo
        private void btnCancelarUser_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            DeshabilitarControles();
        }

        //Para MODIFICAR el usuario
        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtClave.Text != "" && txtNombres.Text != "" && txtApellidos.Text != "" && txtNivel.Value != 0)
            {
                if (txtNivel.Value == 1 || txtNivel.Value == 2 || txtNivel.Value == 3)
                {
                    //Modificando el usuario
                    int id = Convert.ToInt32(txtId.Text);
                    using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                    {
                        oUsuarios = db.Usuarios.Find(id);
                        oUsuarios.Usuario = txtUsuario.Text;
                        oUsuarios.Clave = txtClave.Text;
                        oUsuarios.Nombres = txtNombres.Text;
                        oUsuarios.Apellidos = txtApellidos.Text;
                        oUsuarios.Nivel = Convert.ToInt32(txtNivel.Text);

                        db.Entry(oUsuarios).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Registro modificado con éxito");
                    ActualizarLista();
                    VaciarCampos();
                    DeshabilitarControles();
                }
                else
                {
                    MessageBox.Show("Sólo permiten los siguientes niveles: " +
                    "\n 1 - Gerente(Admin) \n 2 - Bodeguero \n 3 - Encargado de compras \n\n Agregue el nivel");
                }
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        //Para habilitar el form para modificar
        private void btnHabilitarModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oUsuarios = db.Usuarios.Find(id);
                //Determina si el form está lleno con los valores del ID que se quiere modificar y que SI
                //haya encontrado un valor para modificar
                if (oUsuarios != null && txtNombres.Text != "")
                {
                    //Determina si los valores en el form corresponden a los de ese ID y no los de otro ID
                    if (oUsuarios.Nombres == txtNombres.Text)
                    {
                        //Resultado
                        HabilitarControles();
                        btnCrearUser.Enabled = false;
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

        //Para CREAR el usuario
        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtClave.Text != "" && txtNombres.Text != "" && txtApellidos.Text != "" && txtNivel.Value != 0)
            {
                if (txtNivel.Value == 1 || txtNivel.Value == 2 || txtNivel.Value == 3)
                {
                    //Creando el nuevo usuario
                    using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                    {
                        oUsuarios = new Usuarios();
                        oUsuarios.Usuario = txtUsuario.Text;
                        oUsuarios.Clave = txtClave.Text;
                        oUsuarios.Nombres = txtNombres.Text;
                        oUsuarios.Apellidos = txtApellidos.Text;
                        oUsuarios.Nivel = Convert.ToInt32(txtNivel.Text);

                        db.Usuarios.Add(oUsuarios);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Registro agregado con éxito");
                    ActualizarLista();
                    VaciarCampos();
                    DeshabilitarControles();
                }
                else
                {
                    MessageBox.Show("Sólo permiten los siguientes niveles: " +
                    "\n 1 - Gerente(Admin) \n 2 - Bodeguero \n 3 - Encargado de compras \n\n Agregue el nivel");
                }
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        // Para el botón "Refrescar lista" (refrescar la tabla y volver a cargar los datos)
        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        //Al dar doble clic a alguna fila del datagridview, se mostrarán los datos del registro en el form de la izquierda
        //Lo que permitirá más comodamente modificarlo luego.
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txtId.Text = this.dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                txtUsuario.Text = this.dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                txtClave.Text = this.dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
                txtNombres.Text = this.dgvUsuarios.SelectedRows[0].Cells[3].Value.ToString();
                txtApellidos.Text = this.dgvUsuarios.SelectedRows[0].Cells[4].Value.ToString();
                txtNivel.Text = this.dgvUsuarios.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception) {
                return;
            }
        }
    }
}
