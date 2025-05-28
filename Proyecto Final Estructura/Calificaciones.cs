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
    public partial class Calificaciones : Form
    {
        Acciones acciones = new Acciones();
        public Calificaciones()
        {
            InitializeComponent();
            dgCalificaciones.DataSource = acciones.ReadRate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hub form2 = new Hub();
            form2.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            acciones.InsertRate(Convert.ToInt32(tbIdGame.Text), Convert.ToInt32(tbScore.Text), tbCC.Text);
            MessageBox.Show("Calificación agregada con éxito");
            dgCalificaciones.DataSource = null;
            dgCalificaciones.DataSource = acciones.ReadRate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            acciones.UpdateRate(Convert.ToInt32(tbIdRate.Text), Convert.ToInt32(tbIdGame.Text), Convert.ToInt32(tbScore.Text), tbCC.Text);
            MessageBox.Show("Calificación actualizada con éxito");
            dgCalificaciones.DataSource = null;
            dgCalificaciones.DataSource = acciones.ReadRate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            acciones.DeleteRate(Convert.ToInt32(tbIdRate.Text));
            MessageBox.Show("Calificación eliminada con éxito");
            dgCalificaciones.DataSource = null;
            dgCalificaciones.DataSource = acciones.ReadRate();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            acciones.DeleteRate(Convert.ToInt32(tbIdRate.Text));
            MessageBox.Show("Calificación eliminada con éxito");
            dgCalificaciones.DataSource = null;
            dgCalificaciones.DataSource = acciones.ReadRate();
        }
    }
}
