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
    public partial class FormCompras : Form
    {
        Compras oCompras = null;
        ComprasDetalle oDetalle1 = null;
        Kardex kar = null;
        Productos oProd = null;
        Almacenes_Productos oAlmProd = null;

        //No se habilita el formulario de agregación de la compra
        public FormCompras()
        {
            InitializeComponent();
            ActualizarCompras();
            gbFormCompras.Enabled = false;
            gbFormDetalleC.Enabled = false;
            btnFinCompra.Enabled = false;
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            cargarProveedores();
            cargarProductos();
            cargarAlmacenes();
        }

        public void cargarAlmacenes()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var listaAlmacenes = (from d in db.Almacenes
                                      select d).ToList();
                cmbAlm.DataSource = listaAlmacenes;
                cmbAlm.DisplayMember = "Nombre";
                cmbAlm.ValueMember = "Id";
            }
        }

        public void cargarProductos()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var listaProductos = (from d in db.Productos
                                      select d).ToList();
                cmbProd.DataSource = listaProductos;
                cmbProd.DisplayMember = "Nombre";
                cmbProd.ValueMember = "Id";
            }
        }

        //Para el combobox de proveedores
        public void cargarProveedores()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var listaProveedores = (from d in db.Proveedores
                                      select d).ToList();
                cmbProveedor.DataSource = listaProveedores;
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "Id";
            }
        }

        public void ActualizarCompras()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from c in db.Compras
                          join p in db.Proveedores on c.Id_Proveedor equals p.Id
                          select new
                          {
                              Id = c.Id,
                              Documento = c.Documento,
                              Proveedores = p.Nombre,
                              Fecha = c.Fecha,
                              Sumas = c.Sumas,
                              IVA = c.Iva
                          };
                dgvCompras.DataSource = lst.ToList();
            }
        }

        public void ActualizarDetalleCompra(int id)
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst2 = from cd in db.ComprasDetalle
                           join c in db.Compras on cd.Id_Documento equals c.Id
                           join a in db.Almacenes on cd.Id_Almacen equals a.Id
                           join p in db.Productos on cd.Id_Producto equals p.Id
                           where cd.Id_Documento == id
                           select new
                          {
                              Id = cd.Id,
                              Documento = c.Documento,
                              Almacen = a.Nombre,
                              Producto = p.Nombre,
                              Cantidad = cd.Cantidad,
                              Precio = cd.Precio,
                              PrecioTotal = cd.PrecioTotal
                          };
                dgvDetalleC.DataSource = lst2.ToList();
            }
        }
        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)this.dgvCompras.SelectedRows[0].Cells[0].Value;
                ActualizarDetalleCompra(id);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnRegCompra_Click(object sender, EventArgs e)
        {
            /*dgvDetalleC.DataSource = null;
            dgvDetalleC.Columns.Add("Id", "Id");
            dgvDetalleC.Columns.Add("Id_documento", "Id_documento");
            dgvDetalleC.Columns.Add("Id_almacen", "Id_almacen");
            dgvDetalleC.Columns.Add("Id_Productos", "Id_Productos");
            dgvDetalleC.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleC.Columns.Add("Precio", "Precio");
            dgvDetalleC.Columns.Add("PrecioTotal", "PrecioTotal");
            dgvDetalleC.Columns[0].ReadOnly = true;
            dgvDetalleC.Columns[1].ReadOnly = true;
            dgvDetalleC.Columns[2].ReadOnly = true;
            dgvDetalleC.Columns[3].ReadOnly = true;
            dgvDetalleC.Columns[4].ReadOnly = true;
            dgvDetalleC.Columns[5].ReadOnly = true;
            dgvDetalleC.Columns[6].ReadOnly = true;*/
            //gbCompras.Enabled = false;
            gbFormCompras.Enabled = true;

            int idAnterior = 0;

            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst2 = db.Compras.OrderByDescending(x => x.Id).First();
                idAnterior = lst2.Id;
            }

            txtDocumento.Text = "DOC-" + (idAnterior + 1);
            txtDocumento.Enabled = false;
            ActualizarDetalleCompra(0);
            btnRegCompra.Enabled = false;
        }

        private void btnContCompra_Click(object sender, EventArgs e)
        {
            gbFormCompras.Enabled = false;
            gbFormDetalleC.Enabled = true;
            btnFinCompra.Enabled = true;
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oCompras = new Compras();
                oCompras.Documento = txtDocumento.Text;
                oCompras.Id_Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                oCompras.Fecha = dtpFechaCompra.Value;
                oCompras.Sumas = 0;
                oCompras.Iva = 0;

                db.Compras.Add(oCompras);
                db.SaveChanges();
            }
            ActualizarCompras();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cmbProveedor.SelectedIndex = 0;
            lblSumasC.Text = "0";
            lblIVAC.Text = "0";
            gbCompras.Enabled = true;
            gbFormCompras.Enabled = false;
            btnRegCompra.Enabled = true;
            ActualizarDetalleCompra(0);
        }



        private void btnFinCompra_Click(object sender, EventArgs e)
        {
            int idDoc = 0;
            //Modificar los valores de Sumas e IVA en la compra finalizada
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var ultimoId = db.Compras.OrderByDescending(x => x.Id).First();
                idDoc = ultimoId.Id;

                oCompras = db.Compras.Find(idDoc);
                oCompras.Sumas = (decimal?)Convert.ToDouble(lblSumasC.Text);
                oCompras.Iva = (decimal?)Convert.ToDouble(lblIVAC.Text);

                db.Entry(oCompras).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ActualizarDetalleCompra(0);
            }

            // Ultimos pasos
            txtDocumento.Text = "";
            cmbProveedor.SelectedIndex = 0;
            lblSumasC.Text = "0";
            lblIVAC.Text = "0";

            cmbAlm.SelectedIndex = 0;
            cmbProd.SelectedIndex = 0;
            txtCantC.Text = "";
            txtPreC.Text = "0";

            gbCompras.Enabled = true;
            gbFormDetalleC.Enabled = false;
            btnFinCompra.Enabled = false;
            btnRegCompra.Enabled = true;

            ActualizarCompras();

            MessageBox.Show("Compra REALIZADA!");
        }

        private void btnGuardarDC_Click(object sender, EventArgs e)
        {
            int nuevaCantProd = 0;
            int nuevaCantAlmProd = 0;
            
            int idDoc = 0;
            int idAlmacen = Convert.ToInt32(cmbAlm.SelectedValue);
            int idProducto = Convert.ToInt32(cmbProd.SelectedValue);
            int cantidad = Convert.ToInt32(txtCantC.Text);
            double precio = Convert.ToDouble(txtPreC.Text);
            double precioTotal = (cantidad * precio);
            //dgvDetalleC.Rows.Add(0,idDoc,idAlmacen,idProducto,cantidad,precio,precioTotal);

            //Agregar funciones para colocar el dato nuevo en la base directamente
            //Debe agregarse en ComprasDetalle y Kardex, además de cambiar algunos valores en Almacenes_Productos
            //y Productos.
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst2 = db.Compras.OrderByDescending(x => x.Id).First();
                idDoc = lst2.Id;
                var lst3 = db.Productos.Where(x => x.Id == idProducto).First();

                int cantidadReciente = lst3.Existencia;
                int cantidadPosible = cantidadReciente + cantidad;

                if (cantidadPosible <= lst3.StockMaximo)
                {
                    //Sumando nueva cantidad del producto en la tabla Almacenes_Productos

                    var lst4 = db.Almacenes_Productos.Find(idAlmacen, idProducto);

                    if (lst4 != null)
                    {
                        nuevaCantAlmProd = (int)(lst4.Existencia + cantidad);
                        oAlmProd = db.Almacenes_Productos.Find(idAlmacen, idProducto);
                        oAlmProd.Existencia = nuevaCantAlmProd;

                        db.Entry(oAlmProd).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        oAlmProd = new Almacenes_Productos();
                        oAlmProd.Id_Almacen = idAlmacen;
                        oAlmProd.Id_Producto = idProducto;
                        oAlmProd.Existencia = cantidad;

                        db.Almacenes_Productos.Add(oAlmProd);
                        db.SaveChanges();
                    }

                    //Agregando valor a ComprasDetalle
                    oDetalle1 = new ComprasDetalle();
                    oDetalle1.Id_Documento = idDoc;
                    oDetalle1.Id_Almacen = idAlmacen;
                    oDetalle1.Id_Producto = idProducto;
                    oDetalle1.Cantidad = cantidad;
                    oDetalle1.Precio = (decimal)precio;
                    oDetalle1.PrecioTotal = (decimal)precioTotal;

                    db.ComprasDetalle.Add(oDetalle1);
                    db.SaveChanges();

                    //Sumando nueva cantidad del producto en la tabla Productos
                    nuevaCantProd = lst3.Existencia + cantidad;
                    oProd = db.Productos.Find(idProducto);
                    oProd.Existencia = nuevaCantProd;

                    db.Entry(oProd).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    //Agregando valor a Kardex
                    kar = new Kardex();
                    kar.Id_Compra = idDoc;
                    kar.Id_Venta = 0; //NO ES UNA VENTA, por ello se coloca Cero
                    kar.Id_almacen = idAlmacen;
                    kar.Id_Producto = idProducto;
                    kar.Cantidad = cantidad;
                    kar.Precio = (decimal)precio;
                    kar.PrecioTotal = (decimal)precioTotal;
                    kar.Fecha = dtpFechaCompra.Value;
                    kar.CantidadNueva = nuevaCantProd; // arreglar

                    db.Kardex.Add(kar);
                    db.SaveChanges();

                    double labelSumas = Convert.ToDouble(lblSumasC.Text);
                    labelSumas = labelSumas + precioTotal;
                    lblSumasC.Text = labelSumas.ToString();
                    double labelIVA = Convert.ToDouble(lblIVAC.Text);
                    labelIVA = labelSumas * 0.16;
                    lblIVAC.Text = labelIVA.ToString();
                }
                else {
                    MessageBox.Show("No puede exceder el stock máximo para este producto.");
                }  
            }
            ActualizarDetalleCompra(idDoc);
            cmbAlm.SelectedIndex = 0;
            cmbProd.SelectedIndex = 0;
        }

        private void btnEliminarDC_Click(object sender, EventArgs e)
        {
            int nuevaCantProd = 0;
            int nuevaCantAlmProd = 0;
            int idKar = 0;
            int idDetalle = (int)this.dgvDetalleC.SelectedRows[0].Cells[0].Value;
            double precioTotal = 0;

            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var detalleEliminar = db.ComprasDetalle.Where(x => x.Id == idDetalle).First();

                idDetalle = detalleEliminar.Id;
                int idDoc = detalleEliminar.Id_Documento;
                int idAlmacen = detalleEliminar.Id_Almacen;
                int idProducto = detalleEliminar.Id_Producto;
                int cantidad = (int)detalleEliminar.Cantidad;
                double precio = (double)detalleEliminar.Precio;
                precioTotal = (double)detalleEliminar.PrecioTotal;

                var lst3 = db.Productos.Where(x => x.Id == idProducto).First();
                nuevaCantProd = lst3.Existencia - cantidad;
                var lst4 = db.Almacenes_Productos.Where(x => x.Id_Almacen == idAlmacen && x.Id_Producto == idProducto).First();
                nuevaCantAlmProd = (int)(lst4.Existencia - cantidad);

                //Eliminando valor de ComprasDetalle
                oDetalle1 = db.ComprasDetalle.Find(idDetalle, idAlmacen, idProducto);
                if (oDetalle1 != null)
                {
                    db.ComprasDetalle.Remove(oDetalle1);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro del detalle");
                }

                //Restando nueva cantidad del producto en la tabla Productos
                oProd = db.Productos.Find(idProducto);
                oProd.Existencia = nuevaCantProd;

                db.Entry(oProd).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //Restando nueva cantidad del producto en la tabla Almacenes_Productos
                oAlmProd = db.Almacenes_Productos.Find(idAlmacen, idProducto);
                oAlmProd.Existencia = nuevaCantAlmProd;

                db.Entry(oAlmProd).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //Agregando valor a Kardex
                var eliminarKar = db.Kardex.Where(x => x.Id_Compra == idDoc && x.Id_almacen == idAlmacen && x.Id_Producto == idProducto).First();
                idKar = eliminarKar.Id_Kardex;

                //Eliminando valor de Kardex
                kar = db.Kardex.Find(idKar, idDoc, 0, idAlmacen, idProducto);
                if (kar != null)
                {
                    db.Kardex.Remove(kar);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("No se encuentra el registro del reporte");
                }
                ActualizarDetalleCompra(idDoc);
            }

            double labelSumas = Convert.ToDouble(lblSumasC.Text);
            labelSumas = labelSumas - precioTotal;
            lblSumasC.Text = labelSumas.ToString();
            double labelIVA = Convert.ToDouble(lblIVAC.Text);
            labelIVA = labelSumas * 0.16;
            lblIVAC.Text = labelIVA.ToString();
            //dgvDetalleC.Rows.Remove(dgvDetalleC.CurrentRow);
            

            //Mandar a eliminar el dato de ComprasDetalle y Kardex a partir del ID principal,
            //así como también actualizar las cantidades en Almacenes_Productos y Productos


        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(cmbProd.SelectedValue);
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    var listaAlmacenes = db.Productos.Where(x => x.Id == valor).First();
                    txtPreC.Text = listaAlmacenes.PrecioUnitario.ToString();
                }
            }
            catch (InvalidCastException ex)
            {
                txtPreC.Text = "0";
            }
        }

        //RESERVAR ESTA FUNCIÓN PARA EL PROCESO DE VENTAS

        /*private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idAnterior = Convert.ToInt32(cmbProd.SelectedValue);
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    var listaAlmacenes = (from d in db.Almacenes
                                          join ap in db.Almacenes_Productos on d.Id equals ap.Id_Almacen
                                          where ap.Id_Producto == idAnterior
                                          select new
                                          {
                                              Id = d.Id,
                                              Nombre = d.Nombre
                                          }).ToList();
                    cmbAlm.DataSource = listaAlmacenes;
                    cmbAlm.DisplayMember = "Nombre";
                    cmbAlm.ValueMember = "Id";
                }
            }
            catch (InvalidCastException ex) { 
            
            }
        }*/
    }
}
