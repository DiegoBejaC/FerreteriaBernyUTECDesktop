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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }

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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Obteniendo la posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        public void adaptarFormulario(Form formulario)
        {
            lx = formulario.Location.X;
            ly = formulario.Location.Y;
            sw = formulario.Size.Width;
            sh = formulario.Size.Height;

            formulario.Location = Screen.PrimaryScreen.WorkingArea.Location;
            formulario.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Para poder arrastrar el formulario por toda la pantalla.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnInicio_Click(object sender, EventArgs e)
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

        private void btnSalidaProductos_Click(object sender, EventArgs e)
        {
            AbriendoFormulario<FormVentas>();
            btnSalidaProductos.BackColor = Color.FromArgb(115, 179, 218);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginBerny.LoginForm login = new LoginBerny.LoginForm();
            login.Show();
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        //Aqui terminan las modificaciones del formulario

        //Metodo que nos permite abrir los formularios adentro del panel que creamos. Para que sea generico se le agrega: <MiForm> y aplicar restricciones donde miForm herede de tipo form y tenga contructor vacio.
        private void AbriendoFormulario<MiForm>() where MiForm : Form, new()
        {
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
            else
            {
                formulario.BringToFront();
            }
        }

        private void ColorBotonForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormInicio"] == null)
            {
                btnInicio.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormProductos"] == null)
            {
                btnProductos.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormMarcasCategorias"] == null)
            {
                btnMarcasCategorias.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormAlmacenes"] == null)
            {
                btnAlmacenes.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormSalidaProductos"] == null)
            {
                btnSalidaProductos.BackColor = Color.FromArgb(9, 255, 25);
            }
            if (Application.OpenForms["FormCerrarSesion"] == null)
            {
                btnCerrarSesion.BackColor = Color.FromArgb(9, 255, 25);
            }
        }

    }
}
