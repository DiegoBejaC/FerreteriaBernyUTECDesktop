//using Newtonsoft.Json;
using MenuFerreBerny;
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
using System.Data.SqlClient;
using Menu = MenuFerreBerny.Menu;
using MenuFerreBerny.Models;

namespace LoginBerny
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=localhost;database=Ferre_Berny_Desktop;User ID=sa;Password=123;integrated security=true");
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                conn.Open();
                string consulta = "select * from Usuarios where Usuario = '" + txtUser.Text + "' COLLATE Latin1_General_CS_AS and Clave = '" + txtPass.Text + "' COLLATE Latin1_General_CS_AS";
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {
                    string elNivel = "";
                    using (Ferre_Berny_DesktopEntities db = new Ferre_Berny_DesktopEntities())
                    {
                        var nivel = (from d in db.Usuarios
                                     where d.Usuario == txtUser.Text
                                     select d).First().Nivel;
                        elNivel = nivel.ToString();
                        MessageBox.Show("Nivel: " + elNivel);
                    }
                    if (elNivel == "1")
                    {
                        Menu form1 = new Menu();
                        form1.Show();
                        this.Hide();
                    }
                    else if (elNivel == "2")
                    {
                        Menu2 form2 = new Menu2();
                        form2.Show();
                        this.Hide();
                    }
                    else if (elNivel == "3")
                    {
                        Menu3 form3 = new Menu3();
                        form3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("¡USUARIO NO VALIDO!");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Rellene TODOS los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}