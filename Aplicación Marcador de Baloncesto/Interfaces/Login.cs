using System;
using System.Windows.Forms;
using Aplicación_Marcador_de_Baloncesto.Datos;

namespace Aplicación_Marcador_de_Baloncesto.Interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Usuarios inicio = new Usuarios();                
            inicio.Inicio_Admin(textUsuario.Text, textContraseña.Text);              
            this.Hide();
        }
    }
}
