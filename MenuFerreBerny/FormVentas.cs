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
    public partial class FormVentas : Form
    {
        Ventas oCompras = null;
        VentasDetalle oDetalle1 = null;
        Kardex kar = null;
        Productos oProd = null;
        Almacenes_Productos oAlmProd = null;
        public FormVentas()
        {
            InitializeComponent();
            ActualizarCompras();
            gbFormCompras2.Enabled = false;
            gbFormDetalleC2.Enabled = false;
            btnFinCompra2.Enabled = false;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        public void cargarProductos()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var listaProductos = (from d in db.Productos
                                      select d).ToList();
                cmbProd2.DataSource = listaProductos;
                cmbProd2.DisplayMember = "Nombre";
                cmbProd2.ValueMember = "Id";
            }
        }

        public void ActualizarCompras()
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst = from c in db.Ventas
                          select new
                          {
                              Id = c.Id,
                              Documento = c.Documento,
                              Fecha = c.Fecha,
                              Sumas = c.Suma,
                          };
                dgvCompras2.DataSource = lst.ToList();
            }
        }

        public void ActualizarDetalleCompra(int id)
        {
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst2 = from cd in db.VentasDetalle
                           join c in db.Ventas on cd.Id_Documento equals c.Id
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
                dgvDetalleC2.DataSource = lst2.ToList();
            }
        }

        //NUEVOS METODOS PARA LAS VENTAS
        private void btnRegCompra2_Click(object sender, EventArgs e)
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
            gbFormCompras2.Enabled = true;

            int idAnterior = 0;

            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var lst2 = db.Ventas.OrderByDescending(x => x.Id).First();
                idAnterior = lst2.Id;
            }

            txtDocumento2.Text = "VEN-" + (idAnterior + 1);
            txtDocumento2.Enabled = false;
            btnRegCompra2.Enabled = false;
            ActualizarDetalleCompra(0);
        }

        private void btnFinCompra2_Click(object sender, EventArgs e)
        {
            int idDoc = 0;
            //Modificar los valores de Sumas e IVA en la compra finalizada
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var ultimoId = db.Ventas.OrderByDescending(x => x.Id).First();
                idDoc = ultimoId.Id;

                oCompras = db.Ventas.Find(idDoc);
                oCompras.Suma = (decimal?)Convert.ToDouble(lblSumasC2.Text);

                db.Entry(oCompras).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ActualizarDetalleCompra(0);
            }

            // Ultimos pasos
            txtDocumento2.Text = "";
            lblSumasC2.Text = "0";

            cmbAlm2.SelectedIndex = 0;
            cmbProd2.SelectedIndex = 0;
            txtCantC2.Text = "";
            txtPreC2.Text = "0";

            gbCompras2.Enabled = true;
            gbFormDetalleC2.Enabled = false;
            btnFinCompra2.Enabled = false;
            btnRegCompra2.Enabled = true;

            ActualizarCompras();

            MessageBox.Show("Venta REALIZADA!");
        }

        private void btnContCompra2_Click(object sender, EventArgs e)
        {
            gbFormCompras2.Enabled = false;
            gbFormDetalleC2.Enabled = true;
            btnFinCompra2.Enabled = true;
            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                oCompras = new Ventas();
                oCompras.Documento = txtDocumento2.Text;
                oCompras.Fecha = dtpFechaCompra2.Value;
                oCompras.Suma = 0;

                db.Ventas.Add(oCompras);
                db.SaveChanges();
            }
            ActualizarCompras();
        }

        private void btnCancelarCompra2_Click(object sender, EventArgs e)
        {
            txtDocumento2.Text = "";
            lblSumasC2.Text = "0";
            gbCompras2.Enabled = true;
            gbFormCompras2.Enabled = false;
            btnRegCompra2.Enabled = true;
            ActualizarDetalleCompra(0);
        }

        private void btnGuardarDC2_Click(object sender, EventArgs e)
        {
            int nuevaCantProd = 0;
            int nuevaCantAlmProd = 0;

            int idDoc = 0;
            int idAlmacen = Convert.ToInt32(cmbAlm2.SelectedValue);
            int idProducto = Convert.ToInt32(cmbProd2.SelectedValue);
            int cantidad = Convert.ToInt32(txtCantC2.Text);
            double precio = Convert.ToDouble(txtPreC2.Text);
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
                var lst4 = db.Almacenes_Productos.Where(x => x.Id_Almacen == idAlmacen && x.Id_Producto == idProducto).First();

                int cantidadReciente = lst3.Existencia;
                int cantidadPosible = cantidadReciente - cantidad;

                int cantRecienteAlmProd = (int)lst4.Existencia;
                int cantPosibleAlmProd = cantRecienteAlmProd - cantidad;

                if (cantPosibleAlmProd >= 0) {
                    if (cantidadPosible >= lst3.StockMinimo)
                    {
                        //Agregando valor a ComprasDetalle
                        oDetalle1 = new VentasDetalle();
                        oDetalle1.Id_Documento = idDoc;
                        oDetalle1.Id_Almacen = idAlmacen;
                        oDetalle1.Id_Producto = idProducto;
                        oDetalle1.Cantidad = cantidad;
                        oDetalle1.Precio = (decimal)precio;
                        oDetalle1.PrecioTotal = (decimal)precioTotal;

                        db.VentasDetalle.Add(oDetalle1);
                        db.SaveChanges();

                        //Sumando nueva cantidad del producto en la tabla Productos
                        nuevaCantProd = lst3.Existencia - cantidad;
                        oProd = db.Productos.Find(idProducto);
                        oProd.Existencia = nuevaCantProd;

                        db.Entry(oProd).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        //Sumando nueva cantidad del producto en la tabla Almacenes_Productos

                        nuevaCantAlmProd = (int)(lst4.Existencia - cantidad);
                        oAlmProd = db.Almacenes_Productos.Find(idAlmacen, idProducto);
                        oAlmProd.Existencia = nuevaCantAlmProd;

                        db.Entry(oAlmProd).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();


                        //Agregando valor a Kardex
                        kar = new Kardex();
                        kar.Id_Compra = 0; //NO ES UNA COMPRA, por ello se coloca Cero
                        kar.Id_Venta = idDoc;
                        kar.Id_almacen = idAlmacen;
                        kar.Id_Producto = idProducto;
                        kar.Cantidad = cantidad;
                        kar.Precio = (decimal)precio;
                        kar.PrecioTotal = (decimal)precioTotal;
                        kar.Fecha = dtpFechaCompra2.Value;
                        kar.CantidadNueva = nuevaCantProd; // arreglar

                        db.Kardex.Add(kar);
                        db.SaveChanges();

                        double labelSumas = Convert.ToDouble(lblSumasC2.Text);
                        labelSumas = labelSumas + precioTotal;
                        lblSumasC2.Text = labelSumas.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No puede exceder del stock mínimo para este producto.");
                    }
                }
                else {
                    MessageBox.Show("No hay suficientes unidades del producto en este almacén.");
                }
            }
            ActualizarDetalleCompra(idDoc);
            cmbAlm2.SelectedIndex = 0;
            cmbProd2.SelectedIndex = 0;
        }

        private void btnEliminarDC2_Click(object sender, EventArgs e)
        {
            int nuevaCantProd = 0;
            int nuevaCantAlmProd = 0;
            int idKar = 0;
            int idDetalle = (int)this.dgvDetalleC2.SelectedRows[0].Cells[0].Value;
            double precioTotal = 0;

            using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
            {
                var detalleEliminar = db.VentasDetalle.Where(x => x.Id == idDetalle).First();

                idDetalle = detalleEliminar.Id;
                int idDoc = detalleEliminar.Id_Documento;
                int idAlmacen = detalleEliminar.Id_Almacen;
                int idProducto = detalleEliminar.Id_Producto;
                int cantidad = (int)detalleEliminar.Cantidad;
                double precio = (double)detalleEliminar.Precio;
                precioTotal = (double)detalleEliminar.PrecioTotal;

                var lst3 = db.Productos.Where(x => x.Id == idProducto).First();
                nuevaCantProd = lst3.Existencia + cantidad;
                var lst4 = db.Almacenes_Productos.Where(x => x.Id_Almacen == idAlmacen && x.Id_Producto == idProducto).First();
                nuevaCantAlmProd = (int)(lst4.Existencia + cantidad);

                //Eliminando valor de ComprasDetalle
                oDetalle1 = db.VentasDetalle.Find(idDetalle, idAlmacen, idProducto);
                if (oDetalle1 != null)
                {
                    db.VentasDetalle.Remove(oDetalle1);
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

            double labelSumas = Convert.ToDouble(lblSumasC2.Text);
            labelSumas = labelSumas - precioTotal;
            lblSumasC2.Text = labelSumas.ToString();
            //dgvDetalleC.Rows.Remove(dgvDetalleC.CurrentRow);
        }

        private void dgvCompras2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)this.dgvCompras2.SelectedRows[0].Cells[0].Value;
                ActualizarDetalleCompra(id);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void cmbProd2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(cmbProd2.SelectedValue);
                using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                {
                    var listaAlmacenes = db.Productos.Where(x => x.Id == valor).First();
                    txtPreC2.Text = listaAlmacenes.PrecioUnitario.ToString();

                    var listaAlmacenes2 = (from d in db.Almacenes
                                          join ap in db.Almacenes_Productos on d.Id equals ap.Id_Almacen
                                          where ap.Id_Producto == valor
                                          select new
                                          {
                                              Id = d.Id,
                                              Nombre = d.Nombre
                                          }).ToList();
                    cmbAlm2.DataSource = listaAlmacenes2;
                    cmbAlm2.DisplayMember = "Nombre";
                    cmbAlm2.ValueMember = "Id";
                }
            }
            catch (InvalidCastException ex)
            {
                txtPreC2.Text = "0";
            }
        }
    }
}
