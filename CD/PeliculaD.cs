using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialN1.CD
{
    public class PeliculaD
    {
        public static void SeleccionarCliente(string Nombre, string Correo, string Pago, int Cantidad)
        {
            try
            {

                SqlConnection conexion = new SqlConnection("server=DESKTOP-PH45P1N;database=cine;integrated security = true");

                SqlCommand comando = new SqlCommand("INSERT INTO cine (Nombre,Correo,Pago,Cantidad) VALUES (@nombre,@correo,@metodo_pago,@cantidad)", conexion);

                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@correo", Correo);
                comando.Parameters.AddWithValue("@metodo_pago", Pago);
                comando.Parameters.AddWithValue("@cantidad", Cantidad);
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("error");
            }

        }
    }
}
