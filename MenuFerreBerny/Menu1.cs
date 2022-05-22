using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuFerreBerny
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        //Constructor
        /*public Menu()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }*/

        //Haciendo el formulario más interactivo...
        //Metodo que redirecciona y cambia tmaño a formulario en ejecucion
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //Dibujando rectangulo y excluyendolo a la esquina
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //Este es el cuadrito donde podemos ajustar el tamaño de la pantalla le cambiamos color y grip (cambiar de cuadro a lineas).
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Obteniendo la posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        /*private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            //Para que se haga el cambio de botones cuando maximizamos o restauramos pantalla
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //Para que se haga el cambio de botones cuando maximizamos o restauramos pantalla
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }*/

        public void adaptarFormulario(Form formulario)
        {
            lx = formulario.Location.X;
            ly = formulario.Location.Y;
            sw = formulario.Size.Width;
            sh = formulario.Size.Height;

            formulario.Location = Screen.PrimaryScreen.WorkingArea.Location;
            formulario.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Para poder arrastrar el formulario por toda la pantalla.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormInicio>();
            //Para que mientras el formulario este abierto el boton este de otro color
            btnInicio.BackColor = Color.FromArgb(115, 179, 218);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormProductos>();
            btnProductos.BackColor = Color.FromArgb(115, 179, 218);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormProveedores>();
            btnProveedores.BackColor = Color.FromArgb(115, 179, 218);
        }
        private void btnMarcasCategorias_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormMarcasCategorias>();
            btnMarcasCategorias.BackColor = Color.FromArgb(115, 179, 218);
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormAlmacenes>();
            btnAlmacenes.BackColor = Color.FromArgb(115, 179, 218);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormCompras>();
            btnCompras.BackColor = Color.FromArgb(115, 179, 218);
        }

        private void btnSalidaProductos_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormVentas>();
            btnSalidaProductos.BackColor = Color.FromArgb(115, 179, 218);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormUsuarios>();
            btnUsuarios.BackColor = Color.FromArgb(115, 179, 218);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginBerny.LoginForm login = new LoginBerny.LoginForm();
            login.Show();
            this.Close();
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormReportes>();
            btnReportes.BackColor = Color.FromArgb(115, 179, 218);
        }



        //Aqui terminan las modificaciones del formulario

        //Metodo que nos permite abrir los formularios adentro del panel que creamos. Para que sea generico se le agrega: <MiForm> y aplicar restricciones donde miForm herede de tipo form y tenga contructor vacio.
        private void AbriendoFormulario<MiForm>() where MiForm : Form, new() {
            Form formulario;
            //Asignandole al formulario el panel de formulario. Y lo que le sigue es para buscar el la coleccion el formulario.
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe...
            if (formulario == null)
            {
                //Creamos una instancia
                formulario = new MiForm();
                //Esto es para indicar que no es un formulario de nivel superior
                formulario.TopLevel = false;
                //Quitando borde a los formularios...
                formulario.FormBorderStyle = FormBorderStyle.None;
                //Y ahora haremos que este formulario que se abra se adapte al panel.
                formulario.Dock = DockStyle.Fill;
                //Agregamos el formulario a la coleccion de controles del panel.
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //Llamamos al metodo que hace que cambie los colores al seleccionar otro boton del menu
                formulario.FormClosed += new FormClosedEventHandler(ColorBotonForms);
                //Para que al maximizar la pantalla los formularios se adapten
                adaptarFormulario(formulario);
            }
            //Si el formulario si existe...
            else {
                formulario.BringToFront();
            }
        }

        //Metodo para que cuando se seleccione otro boton del menu vuelva a su color.
        private void ColorBotonForms(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms["FormInicio"] == null)
            {
                btnInicio.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormProductos"] == null)
            {
                btnProductos.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormProveedores"] == null)
            {
                btnProveedores.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormMarcasCategorias"] == null)
            {
                btnMarcasCategorias.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormAlmacenes"] == null)
            {
                btnAlmacenes.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormCompras"] == null)
            {
                btnCompras.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormSalidaProductos"] == null)
            {
                btnSalidaProductos.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormUsuarios"] == null)
            {
                btnUsuarios.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormCerrarSesion"] == null)
            {
                btnCerrarSesion.BackColor = Color.FromArgb(9, 255, 25);
            }
        }


    }
}
