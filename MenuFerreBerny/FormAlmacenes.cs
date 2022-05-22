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
    public partial class FormAlmacenes : Form
    {
        public bool guardarAP = true;
        public bool modificarAP = true;
        Almacenes oAlmacenes = null;
        Almacenes_Productos oAlmProd = null;
        Productos oProd = null;
        public FormAlmacenes()
        {
            InitializeComponent();
            ActualizarAlmacenes();
            ActualizarAlmProd();
            cargarAlmacenes();
            cargarProductos();
            txtCantidad.Text = "";
        }

        private void FormAlmacenes_Load(object sender, EventArgs e)
        {
            OnControlesAlmacenes();
            OnControlesAlmProd();
        }

        public void textoBotones() {
            btnGuardarAlmProd.Text = "Nuevo";
            btnActualizarAlmProd.Text = "Actualizar";
        }

        public void cargarAlmacenes()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var listaAlmacenes = (from d in db.Almacenes
                                      select d).ToList();
                cmbAlmacen.DataSource = listaAlmacenes;
                cmbAlmacen.DisplayMember = "Nombre";
                cmbAlmacen.ValueMember = "Id";
            }
        }

        public void cargarProductos()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var listaProductos = (from d in db.Productos
                                      select d).ToList();
                cmbProducto.DataSource = listaProductos;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "Id";
            }
        }

        public void ActualizarAlmProd()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst2 = from ap in db.Almacenes_Productos
                           join a in db.Almacenes on ap.Id_Almacen equals a.Id
                           join p in db.Productos on ap.Id_Producto equals p.Id
                           select new
                           {
                               Id = ap.Id,
                               Almacen = a.Nombre,
                               Producto = p.Nombre,
                               Existencia = ap.Existencia
                           };
                dgvAlmProd.DataSource = lst2.ToList();
            }
        }

        public void ActualizarAlmacenes() {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from d in db.Almacenes
                          select new
                          {
                              Id = d.Id,
                              Nombre = d.Nombre,
                          };
                dgvAlmacenes.DataSource = lst.ToList();
            }
        }
        private void OnControlesAlmacenes()
        {
            txtNombreAlmacen.Enabled = false;
            btnGuardarAlm.Enabled = false;
            btnActualizarAlm.Enabled = false;
            btnCancelarAlm.Enabled = false;

            txtBuscarAlmacen.Enabled = true;
            btnBuscarAlm.Enabled = true;
            btnHabilitarNuevoAlm.Enabled = true;
            btnHabilitarModificarAlm.Enabled = true;
            btnEliminarAlm.Enabled = true;
        }

        private void OnControlesAlmProd()
        {
            txtCantidad.Enabled = false;
        }

        private void OffControlesAlmacenes()
        {
            txtNombreAlmacen.Enabled = true;
            btnGuardarAlm.Enabled = true;
            btnActualizarAlm.Enabled = true;
            btnCancelarAlm.Enabled = true;

            txtBuscarAlmacen.Enabled = false;
            btnBuscarAlm.Enabled = false;
            btnHabilitarNuevoAlm.Enabled = false;
            btnHabilitarModificarAlm.Enabled = false;
            btnEliminarAlm.Enabled = false;
        }

        private void OffControlesAlmProd()
        {
            txtCantidad.Enabled = true;
        }

        //Vacia los càmpos del form una vez se deshabilta
        private void VaciarCamposAlmacenes()
        {
            txtNombreAlmacen.Text = "";
        }

        private void VaciarCamposAlmProd()
        {
            cmbAlmacen.SelectedIndex = 0;
            cmbProducto.SelectedIndex = 0;
            txtCantidad.Text = "";
        }

        //Métodos para los botones...
        private void btnBuscarAlm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarAlmacen.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oAlmacenes = db.Almacenes.Find(id);
                if (oAlmacenes != null)
                {
                    var lst = from d in db.Almacenes
                              where d.Id == id
                              select new
                              {
                                  Id = d.Id,
                                  Nombre = d.Nombre,
                              };
                    dgvAlmacenes.DataSource = lst.ToList();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                    ActualizarAlmacenes();
                }
            }
        }

        private void btnCancelarAlm_Click(object sender, EventArgs e)
        {
            VaciarCamposAlmacenes();
            OnControlesAlmacenes();
        }

        private void btnCancelarAlmProd_Click(object sender, EventArgs e)
        {
            VaciarCamposAlmProd();
            OnControlesAlmProd();
            textoBotones();
            cmbAlmacen.Enabled = true;
            cmbProducto.Enabled = true;
            btnGuardarAlmProd.Enabled = true;
            btnActualizarAlmProd.Enabled = true;
            btnEliminarAP.Enabled = true;
            btnBuscarAlmProd.Enabled = true;
            guardarAP = true;
            modificarAP = true;
        }

        private void btnEliminarAlm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarAlmacen.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oAlmacenes = db.Almacenes.Find(id);
                if (oAlmacenes != null)
                {
                    db.Almacenes.Remove(oAlmacenes);
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro");
                }
            }
            ActualizarAlmacenes();
            VaciarCamposAlmacenes();
            OnControlesAlmacenes();
            cargarAlmacenes();
        }

        private void btnEliminarAlmProd_Click(object sender, EventArgs e)
        {
            int idAlm = Convert.ToInt32(cmbAlmacen.SelectedValue);
            int idProd = Convert.ToInt32(cmbProducto.SelectedValue);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oAlmProd = db.Almacenes_Productos.Find(idAlm, idProd);
                if (oAlmProd != null)
                {
                    db.Almacenes_Productos.Remove(oAlmProd);
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado con éxito");
                    ActualizarAlmProd();
                    VaciarCamposAlmProd();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro!");
                    ActualizarAlmProd();
                }
            }
        }

        private void btnHabilitarNuevoAlm_Click(object sender, EventArgs e)
        {
            VaciarCamposAlmacenes();
            OffControlesAlmacenes();
            btnActualizarAlm.Enabled = false;
        }

        private void btnHabilitarNuevoAlmProd_Click(object sender, EventArgs e)
        {
            VaciarCamposAlmProd();
            OffControlesAlmProd();
            btnActualizarAlmProd.Enabled = false;
        }

        private void btnHabilitarModificarAlm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarAlmacen.Text);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oAlmacenes = db.Almacenes.Find(id);
                //Determina si el form está lleno con los valores del ID que se quiere modificar y que SI
                //haya encontrado un valor para modificar
                if (oAlmacenes != null && txtNombreAlmacen.Text != "")
                {
                    //Determina si los valores en el form corresponden a los de ese ID y no los de otro ID
                    if (oAlmacenes.Nombre == txtNombreAlmacen.Text)
                    {
                        //Resultado
                        OffControlesAlmacenes();
                        btnGuardarAlm.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Los valores no corresponden. \nHaga doble clic sobre el valor a modificar");
                        ActualizarAlmacenes();
                        VaciarCamposAlmacenes();
                        OnControlesAlmacenes();
                    }
                }
                else
                {
                    MessageBox.Show("Haga doble clic sobre el valor a modificar");
                    ActualizarAlmacenes();
                    VaciarCamposAlmacenes();
                    OnControlesAlmacenes();
                }
            }
        }

        private void btnHabilitarModificarAlmProd_Click(object sender, EventArgs e)
        {
            OffControlesAlmProd();
            cmbAlmacen.Enabled = false;
            cmbProducto.Enabled = false;
            btnGuardarAlmProd.Enabled = false;
        }

        private void btnGuardarAlm_Click(object sender, EventArgs e)
        {
            if (txtNombreAlmacen.Text != "")
            {
                //Creando el nuevo proveedor
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oAlmacenes = new Almacenes();
                    oAlmacenes.Nombre = txtNombreAlmacen.Text;

                    db.Almacenes.Add(oAlmacenes);
                    db.SaveChanges();
                }
                MessageBox.Show("Registro agregado con éxito");
                ActualizarAlmacenes();
                VaciarCamposAlmacenes();
                OnControlesAlmacenes();
                cargarAlmacenes();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnGuardarAlmProd_Click(object sender, EventArgs e)
        {
            if (guardarAP)
            {
                habilitarGuardarAP();
                cmbAlmacen.Enabled = true;
                cmbProducto.Enabled = true;
                guardarAP = false;
                btnActualizarAlmProd.Enabled = false;
                btnEliminarAP.Enabled = false;
                btnBuscarAlmProd.Enabled = false;
            }
            else {
                CrearAP();
            }
        }

        public void habilitarGuardarAP() {
            VaciarCamposAlmProd();
            OffControlesAlmProd();
            btnGuardarAlmProd.Text = "GUARDAR";
        }

        public void CrearAP() {
            if (txtCantidad.Text != "")
            {
                if (txtCantidad.Value != 0)
                {
                    if (CantidadRestante() == 0.1)
                    {
                        //Creando el nuevo proveedor
                        using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                        {
                            oAlmProd = new Almacenes_Productos();
                            oAlmProd.Id_Almacen = Convert.ToInt32(cmbAlmacen.SelectedValue);
                            oAlmProd.Id_Producto = Convert.ToInt32(cmbProducto.SelectedValue);
                            oAlmProd.Existencia = Convert.ToInt32(txtCantidad.Text);

                            db.Almacenes_Productos.Add(oAlmProd);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Registro agregado con éxito");
                        ActualizarAlmProd();
                        VaciarCamposAlmProd();
                        OnControlesAlmProd();
                        textoBotones();
                        guardarAP = true;
                        btnActualizarAlmProd.Enabled = true;
                        btnEliminarAP.Enabled = true;
                        btnBuscarAlmProd.Enabled = true;
                    }
                    else {
                        if (CantidadRestante() == 0)
                        {
                            MessageBox.Show("TODAS LAS UNIDADES DEL PRODUCTO YA HAN SIDO ALMACENADAS!");
                        }
                        else
                        {
                            MessageBox.Show("Cantidad de existencias sobrepasa el límite! \nSólo puede almacenar " +
                            CantidadRestante() + " unidades más del producto seleccionado!");
                        }
                    }
                }
                else {
                    MessageBox.Show("Ingrese una cantidad de productos!");
                }
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnActualizarAlm_Click(object sender, EventArgs e)
        {
            if (txtNombreAlmacen.Text != "")
            {
                //Modificando el proveedor
                int id = Convert.ToInt32(txtBuscarAlmacen.Text);
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    oAlmacenes = db.Almacenes.Find(id);
                    oAlmacenes.Nombre = txtNombreAlmacen.Text;

                    db.Entry(oAlmacenes).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                MessageBox.Show("Registro modificado con éxito");
                ActualizarAlmacenes();
                VaciarCamposAlmacenes();
                OnControlesAlmacenes();
                cargarAlmacenes();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        private void btnActualizarAlmProd_Click(object sender, EventArgs e)
        {
            if (modificarAP)
            {
                if (txtCantidad.Text != "")
                {
                    int idAlm = Convert.ToInt32(cmbAlmacen.SelectedValue);
                    int idProd = Convert.ToInt32(cmbProducto.SelectedValue);
                    //Modificando el proveedor
                    using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                    {
                        oAlmProd = db.Almacenes_Productos.Find(idAlm, idProd);
                        if (oAlmProd != null) {
                            if (oAlmProd.Id_Almacen == Convert.ToInt32(cmbAlmacen.SelectedValue) && oAlmProd.Id_Producto == Convert.ToInt32(cmbProducto.SelectedValue))
                            {
                                habilitarActualizarAP();
                                modificarAP = false;
                                btnGuardarAlmProd.Enabled = false;
                                btnEliminarAP.Enabled = false;
                                btnBuscarAlmProd.Enabled = false;
                            }
                            else {
                                MessageBox.Show("Los valores no corresponden. \nHaga doble clic sobre el valor a modificar");
                                ActualizarAlmacenes();
                                VaciarCamposAlmacenes();
                                OnControlesAlmacenes();
                            }
                        }
                        else {
                            MessageBox.Show("Haga doble clic sobre el registro a modificar.");
                            ActualizarAlmacenes();
                            VaciarCamposAlmacenes();
                            OnControlesAlmacenes();
                        }
                    }
                }
                else {
                    MessageBox.Show("Haga doble clic sobre el registro a modificar.");
                }
            }
            else
            {
                ActualizarAP();
            }
        }

        public void ActualizarAP() {
            if (txtCantidad.Text != "")
            {
                if (txtCantidad.Value != 0)
                {
                    if (CantidadRestante() == 0.1)
                    {
                        int idAlm = Convert.ToInt32(cmbAlmacen.SelectedValue);
                        int idProd = Convert.ToInt32(cmbProducto.SelectedValue);
                        //Modificando el proveedor
                        using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                        {
                            oAlmProd = db.Almacenes_Productos.Find(idAlm, idProd);

                            oAlmProd.Id_Almacen = Convert.ToInt32(cmbAlmacen.SelectedValue);
                            oAlmProd.Id_Producto = Convert.ToInt32(cmbProducto.SelectedValue);
                            oAlmProd.Existencia = Convert.ToInt32(txtCantidad.Text);

                            db.Entry(oAlmProd).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            MessageBox.Show("Registro modificado con éxito");
                            ActualizarAlmProd();
                            VaciarCamposAlmProd();
                            OnControlesAlmProd();
                            textoBotones();
                            modificarAP = true;
                            btnGuardarAlmProd.Enabled = true;
                            btnEliminarAP.Enabled = true;
                            btnBuscarAlmProd.Enabled = true;
                        } 
                    }
                    else
                    {
                        if (CantidadRestante() == 0)
                        {
                            MessageBox.Show("TODAS LAS UNIDADES DEL PRODUCTO YA HAN SIDO ALMACENADAS!");
                        }
                        else {
                            MessageBox.Show("Cantidad de existencias sobrepasa el límite! \nPuede almacenar un total de " +
                            CantidadRestante() + " unidades en el presente registro!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad de productos!");
                }
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos!");
            }
        }

        public void habilitarActualizarAP()
        {
            OffControlesAlmProd();
            cmbAlmacen.Enabled = false;
            cmbProducto.Enabled = false;
            btnActualizarAlmProd.Text = "GUARDAR";
        }

        public double CantidadRestante() {
            int idAlm = Convert.ToInt32(cmbAlmacen.SelectedValue);
            int idProd = Convert.ToInt32(cmbProducto.SelectedValue);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities()) {
                var prod1 = (from p in db.Productos
                             where p.Id == idProd
                             select p).ToList();
                int exisP = prod1.Sum(x => x.Existencia);

                var SumAlm = (from a in db.Almacenes_Productos
                              where a.Id_Producto == idProd
                              select a).ToList();
                int exisA = (int)SumAlm.Sum(x => x.Existencia);

                double restante = (double)(exisP - exisA);

                if (btnActualizarAlmProd.Text == "GUARDAR")
                {
                    oAlmProd = db.Almacenes_Productos.Find(idAlm, idProd);
                    int exisAnterior = 0 + (int)oAlmProd.Existencia;
                    restante = restante + exisAnterior;
                }

                if ((double)txtCantidad.Value <= restante)
                {
                    return 0.1; // Si se puede agregar la cantidad restante
                }
                else {
                    return restante; // No se puede porque sobrepasa la cantidad real de unidades del producto.
                }
            }
        }
        private void dgvAlmacenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBuscarAlmacen.Text = this.dgvAlmacenes.SelectedRows[0].Cells[0].Value.ToString();
                txtNombreAlmacen.Text = this.dgvAlmacenes.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvAlmProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbAlmacen.Text = this.dgvAlmProd.SelectedRows[0].Cells[1].Value.ToString();
                cmbProducto.Text = this.dgvAlmProd.SelectedRows[0].Cells[2].Value.ToString();
                txtCantidad.Text = this.dgvAlmProd.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarAlmacenes();
            ActualizarAlmProd();
        }

        //NUEVO MÉTODO PARA EL BOTON PARA BUSCAR REGISTROS EN ALMACENES_PRODUCTOS
        private void btnBuscarAlmProd_Click_2(object sender, EventArgs e)
        {
            int idAlm = Convert.ToInt32(cmbAlmacen.SelectedValue);
            int idProd = Convert.ToInt32(cmbProducto.SelectedValue);
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oAlmProd = db.Almacenes_Productos.Find(idAlm, idProd);
                if (oAlmProd != null)
                {
                    var lst2 = from ap in db.Almacenes_Productos
                               join a in db.Almacenes on ap.Id_Almacen equals a.Id
                               join p in db.Productos on ap.Id_Producto equals p.Id
                               where a.Id == idAlm && p.Id == idProd
                               select new
                               {
                                   Id = ap.Id,
                                   Almacen = a.Nombre,
                                   Producto = p.Nombre,
                                   Existencia = ap.Existencia
                               };
                    dgvAlmProd.DataSource = lst2.ToList();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro!");
                    ActualizarAlmProd();
                }
            }
        }
    }
}
