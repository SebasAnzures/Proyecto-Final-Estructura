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
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void btnVG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Juegos form2 = new Juegos();
            form2.Show();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generos form2 = new Generos();
            form2.Show();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calificaciones form2 = new Calificaciones();
            form2.Show();
        }

        private void btnRate2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calificaciones form2 = new Calificaciones();
            form2.Show();
        }
    }
}
