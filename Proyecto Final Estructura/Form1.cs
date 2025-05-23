using Proyecto_Final_Estructura.Controller;

namespace Proyecto_Final_Estructura
{
    public partial class Form1 : Form
    {
        Acciones acciones = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acciones.Register(tbuser.Text, tbpw.Text);
            MessageBox.Show("Usuario registrado con exito");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (acciones.Login(tbuser.Text, acciones.GetUsers(), tbpw.Text))
            {
                MessageBox.Show("Bienvenido " + tbuser.Text);
                this.Hide();
                Hub form2 = new Hub();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
