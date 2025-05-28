using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_Final_Estructura.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Estructura
{
    public partial class Juegos : Form
    {
        Acciones acciones = new Acciones();
        public Juegos()
        {
            InitializeComponent();
            dgJuegos.DataSource = acciones.LeerJuegos(tbusuario.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hub form2 = new Hub();
            form2.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            dgJuegos.DataSource = null;
            dgJuegos.DataSource = acciones.LeerJuegos(tbusuario.Text);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            acciones.InsertarJuego(tbnombre.Text, tbplatform.Text, Convert.ToInt32(tbusuario.Text));
            MessageBox.Show("Juego agregado con exito");
            dgJuegos.DataSource = null;
            dgJuegos.DataSource = acciones.LeerJuegos(tbusuario.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            acciones.ActualizarJuego(Convert.ToInt32(tbidjuego.Text), tbnombre.Text, tbplatform.Text, Convert.ToInt32(tbusuario.Text));
            MessageBox.Show("Juego actualizado con exito");
            dgJuegos.DataSource = null;
            dgJuegos.DataSource = acciones.LeerJuegos(tbusuario.Text);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            acciones.EliminarJuego(Convert.ToInt32(tbidjuego.Text));
            MessageBox.Show("Juego eliminado con exito");
            dgJuegos.DataSource = null;
            dgJuegos.DataSource = acciones.LeerJuegos(tbusuario.Text);
        }
    }
}
