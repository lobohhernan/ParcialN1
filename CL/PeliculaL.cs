using ParcialN1.CD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace ParcialN1.CL
{
    public class PeliculaL
    {
        private PeliculaD peliculaD = new PeliculaD();

        private string nombre;
        private string correo;
        private string metodoPago;
        private int cantidad;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public bool GuardarVenta()
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo)||
        string.IsNullOrWhiteSpace(metodoPago) || cantidad <= 0)
            {
                throw new ArgumentException("Todos los campos son obligatorios y la cantidad debe ser mayor a 0.");
            }

            // Validación: Comprobar formato de correo
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                throw new ArgumentException("El formato del correo electrónico no es válido.");
            }
            
            return peliculaD.GuardarVenta(nombre, correo, metodoPago, cantidad);
        }
    }
}
