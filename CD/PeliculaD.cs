using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable ObtenerVentas(out int totalEntradas)
        {
            DataTable dtVentas = new DataTable();
            
            using (SqlConnection connection = new SqlConnection("server =.; database = cine; integrated security = true"))
            {
                string query = "SELECT Nombre, Correo, MetodoPago, Cantidad FROM ventas"; // Ajusta los campos según tu tabla
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtVentas);
                    }
                }
                string querySumarEntradas = "SELECT SUM(Cantidad) FROM ventas";
                using (SqlCommand commandSumar = new SqlCommand(querySumarEntradas, connection))
                {
                    object result = commandSumar.ExecuteScalar();
                    totalEntradas = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }

            return dtVentas;
        }
    }
}
    
    

