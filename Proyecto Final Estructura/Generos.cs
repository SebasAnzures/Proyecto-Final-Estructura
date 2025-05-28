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
    public partial class Generos : Form
    {
        Acciones acciones = new Acciones();
        public Generos()
        {
            InitializeComponent();
            dgGeneros.DataSource = acciones.ReadGenre();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hub form2 = new Hub();
            form2.Show();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            acciones.InsertGenre(tbGenre.Text);
            MessageBox.Show("Genero agregado con exito");
            dgGeneros.DataSource = null;
            dgGeneros.DataSource = acciones.ReadGenre();
        }
    }
}
