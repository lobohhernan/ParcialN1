using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ParcialN1.CD
{
    public class PeliculaD
    {

        public bool GuardarVenta(string nombre, string correo, string metodoPago, int cantidad)
        {
            using (SqlConnection connection = new SqlConnection("server =.; database = cine; integrated security = true"))
            {
                string query = "INSERT INTO Ventas (Nombre, Correo, MetodoPago, Cantidad) VALUES (@Nombre, @Correo, @MetodoPago, @Cantidad)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@MetodoPago", metodoPago);
                command.Parameters.AddWithValue("@Cantidad", cantidad);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
    
    

