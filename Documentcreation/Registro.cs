using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Documentcreation
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario, password;

            usuario = txtusuario.Text;
            password = txtcontrasena.Text;

            if (usuario == "Karla" && password == "123")
            {
                DatosP datosp= new DatosP();
                datosp.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Código para el evento groupBox1_Enter, si es necesario.
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtusuario.Text = "";
            txtcontrasena.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }

      
    }
}
