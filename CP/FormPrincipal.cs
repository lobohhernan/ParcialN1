using ParcialN1.CD;
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
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private PeliculaL Pelicula = new PeliculaL();
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
            pnlIngresar.Visible = false;
            pnlEstrenos.Visible = false;
            pnlPromos.Visible = false;
            pnlNosotros.Visible = false;
            pnlPeliculas.Visible = false;
            pnlPeliEntr1.Visible = false;
            pnlPeliEntr2.Visible = false;
            pnlPeliEntr3.Visible = false;

            string usuarioCorrecto = "admin1234";
            string contraseñaCorrecta = "1234";
            
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;
            
            if (usuarioIngresado == usuarioCorrecto && contraseñaIngresada == contraseñaCorrecta)
            {
                pnlAdministrador.Visible = true;
                MessageBox.Show("Bienvenido al panel administrador");
            }
            else
            {
                pnlIngresar.Visible = true;
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FORM Ventas";
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection("server=.;database=cine;integrated security = true");
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void btnPagar2_Click_1(object sender, EventArgs e)
        {
            Pelicula.Nombre = txtNombre2.Text;
            Pelicula.Correo = txtCorreo2.Text;
            Pelicula.MetodoPago = ComboBoxPagos2.SelectedItem?.ToString() ?? ""; // Maneja caso donde no haya selección
            Pelicula.Cantidad = Convert.ToInt32(numboxEntradas2.Text);

            try
            {
                // Llamar a GuardarVenta sin parámetros, ya que usa las propiedades de la clase
                bool ventaGuardada = Pelicula.GuardarVenta();

                if (ventaGuardada)
                {
                    MessageBox.Show("Venta guardada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al guardar la venta.");
                }
            }
            catch (ArgumentException ex)
            {
                // Manejo de excepciones en caso de datos inválidos
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void numboxEntradas2_ValueChanged(object sender, EventArgs e)
        {
            int precioEntrada = 3000;

            decimal total = precioEntrada * numboxEntradas2.Value;
            lblTotal2.Text = $"Total: ${total:0.00}"; 
        }

        private void btnPagar3_Click_1(object sender, EventArgs e)
        {
            Pelicula.Nombre = txtNombre3.Text;
            Pelicula.Correo = txtCorreo3.Text;
            Pelicula.MetodoPago = ComboBoxPagos3.SelectedItem?.ToString() ?? ""; // Maneja caso donde no haya selección
            Pelicula.Cantidad = Convert.ToInt32(numboxEntradas3.Text);

            try
            {
                // Llamar a GuardarVenta sin parámetros, ya que usa las propiedades de la clase
                bool ventaGuardada = Pelicula.GuardarVenta();

                if (ventaGuardada)
                {
                    MessageBox.Show("Venta guardada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al guardar la venta.");
                }
            }
            catch (ArgumentException ex)
            {
                // Manejo de excepciones en caso de datos inválidos
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void numboxEntradas3_ValueChanged(object sender, EventArgs e)
        {
            int precioEntrada = 3000;

            decimal total = precioEntrada * numboxEntradas3.Value;
            lblTotal3.Text = $"Total: ${total:0.00}";
        }

        private void numboxEntradas1_ValueChanged(object sender, EventArgs e)
        {
            int precioEntrada = 3000;

            decimal total = precioEntrada * numboxEntradas1.Value;
            lblTotal1.Text = $"Total: ${total:0.00}";
        }

        private void btnPagar1_Click_1(object sender, EventArgs e)
        {
            Pelicula.Nombre = txtNombre1.Text;
            Pelicula.Correo = txtCorreo1.Text;
            Pelicula.MetodoPago = ComboBoxPagos1.SelectedItem?.ToString() ?? ""; // Maneja caso donde no haya selección
            Pelicula.Cantidad = Convert.ToInt32(numboxEntradas1.Text);

            try
            {
                // Llamar a GuardarVenta sin parámetros, ya que usa las propiedades de la clase
                bool ventaGuardada = Pelicula.GuardarVenta();

                if (ventaGuardada)
                {
                    MessageBox.Show("Venta guardada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al guardar la venta.");
                }
            }
            catch (ArgumentException ex)
            {
                // Manejo de excepciones en caso de datos inválidos
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
