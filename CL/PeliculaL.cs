using ParcialN1.CD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialN1.CL
{
    public class PeliculaL
    {

        private string nombre;
        private string correo;
        private string pago;
        private int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pago { get => pago; set => pago = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public void AgregarDatos(string nombre, string correo, string pago, int cantidad)
        {
            PeliculaD.SeleccionarCliente(nombre, correo, pago, cantidad);
        }
    }
}
