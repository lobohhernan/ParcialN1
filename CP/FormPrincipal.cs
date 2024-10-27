using ParcialN1.CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialN1
{
    public partial class FormPrincipal : Form
    {
        string AdminUser = "admin";
        string AdminPass = "admin1234";
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            IzqIcono.Height = btnPeliculas.Height;
            IzqIcono.Top = btnPeliculas.Top;
            pnlPeliculas.Visible=true;
            pnlEstrenos.Visible=false;
            pnlPromos.Visible=false;
            pnlNosotros.Visible=false;
            pnlIngresar.Visible=false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;
            pnlAdministrador.Visible = false;
        }

        private void btnEstrenos_Click(object sender, EventArgs e)
        {
            IzqIcono.Height = btnEstrenos.Height;
            IzqIcono.Top = btnEstrenos.Top;
            pnlEstrenos.Visible=true;
            pnlPeliculas.Visible = false;
            pnlPromos.Visible = false;
            pnlNosotros.Visible = false;
            pnlIngresar.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;
            pnlAdministrador.Visible = false;
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            IzqIcono.Height = btnPromo.Height;
            IzqIcono.Top = btnPromo.Top;
            pnlPromos.Visible=true;
            pnlEstrenos.Visible = false;
            pnlPeliculas.Visible = false;
            pnlNosotros.Visible = false;
            pnlIngresar.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;
            pnlAdministrador.Visible = false;
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            IzqIcono.Height = btnNosotros.Height;
            IzqIcono.Top = btnNosotros.Top;
            pnlNosotros.Visible=true;  
            pnlEstrenos.Visible = false;
            pnlPromos.Visible = false;
            pnlPeliculas.Visible = false;
            pnlIngresar.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;
            pnlAdministrador.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IzqIcono.Height = btnIngresar.Height;
            IzqIcono.Top = btnIngresar.Top;
            pnlIngresar.Visible=true;
            pnlEstrenos.Visible = false;
            pnlPromos.Visible = false;
            pnlNosotros.Visible = false;
            pnlPeliculas.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;
            pnlAdministrador.Visible = false;
        }

        private void btnComprar1_Click(object sender, EventArgs e)
        {
            pnlIngresar.Visible = false;
            pnlEstrenos.Visible = false;
            pnlPromos.Visible = false;
            pnlNosotros.Visible = false;
            pnlPeliculas.Visible = false;
            pnlPeliEntr1.Visible = true;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;
            pnlAdministrador.Visible = false;
        }

        private void btnComprar2_Click(object sender, EventArgs e)
        {
            pnlIngresar.Visible = false;
            pnlEstrenos.Visible = false;
            pnlPromos.Visible = false;
            pnlNosotros.Visible = false;
            pnlPeliculas.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = true;
            pnlPeliEntr3.Visible = false;
            pnlAdministrador.Visible = false;
        }

        private void btnComprar3_Click(object sender, EventArgs e)
        {
            pnlIngresar.Visible = false;
            pnlEstrenos.Visible = false;
            pnlPromos.Visible = false;
            pnlNosotros.Visible = false;
            pnlPeliculas.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = true;
            pnlAdministrador.Visible = false;
        }

        private void btnIngresarAdmin_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtUsuario.Text;

            if (username != AdminUser && password != AdminPass)
            {
                //pnlAdministrador.Visible = true;
            }


            pnlIngresar.Visible = false;
            pnlEstrenos.Visible = false;
            pnlPromos.Visible = false;
            pnlNosotros.Visible = false;
            pnlPeliculas.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;

            string usuarioCorrecto = "Admin1234";
            string contraseñaCorrecta = "12345";

            // Obtener valores de los TextBox
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;

            // Verificar credenciales
            if (usuarioIngresado == usuarioCorrecto && contraseñaIngresada == contraseñaCorrecta)
            {
                // Credenciales correctas, mostrar panel administrador
                pnlAdministrador.Visible = true;
                MessageBox.Show("Bienvenido al panel administrador");
            }
            else
            {
                // Credenciales incorrectas, mostrar mensaje de error
                pnlIngresar.Visible = true;
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPagar1_Click(object sender, EventArgs e)
        {
            PeliculaL pelicula = new PeliculaL();
            pelicula.Nombre = txtNombre1.Text;
            pelicula.Correo = txtCorreo1.Text;
            pelicula.Pago = ComboBoxPagos1.Text;
            pelicula.Cantidad = Convert.ToInt32(numboxEntradas1.Text);
            pelicula.AgregarDatos(pelicula.Nombre, pelicula.Correo, pelicula.Pago, pelicula.Cantidad);

        }

        private void btnPagar2_Click(object sender, EventArgs e)
        {
            PeliculaL pelicula = new PeliculaL();
            pelicula.Nombre = txtNombre1.Text;
            pelicula.Correo = txtCorreo1.Text;
            pelicula.Pago = ComboBoxPagos1.Text;
            pelicula.Cantidad = Convert.ToInt32(numboxEntradas1.Text);
            pelicula.AgregarDatos(pelicula.Nombre, pelicula.Correo, pelicula.Pago, pelicula.Cantidad);
        }

        private void btnPagar3_Click(object sender, EventArgs e)
        {
            PeliculaL pelicula = new PeliculaL();
            pelicula.Nombre = txtNombre1.Text;
            pelicula.Correo = txtCorreo1.Text;
            pelicula.Pago = ComboBoxPagos1.Text;
            pelicula.Cantidad = Convert.ToInt32(numboxEntradas1.Text);
            pelicula.AgregarDatos(pelicula.Nombre, pelicula.Correo, pelicula.Pago, pelicula.Cantidad);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FORM venta";
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection("server=DESKTOP-PH45P1N;database=cine;integrated security = true");
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }
    }
}
