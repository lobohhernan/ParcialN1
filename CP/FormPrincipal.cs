using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
    }
}
