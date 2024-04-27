using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Libreria para base de datos
using Aplicación_Marcador_de_Baloncesto.Interfaces; //Acesso a nuestro archivo presentacion

namespace Aplicación_Marcador_de_Baloncesto.Datos
{
    class Usuarios
    {
        private Conexion conexion = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        public void Inicio_Admin(string NomUsuario, string contrasena)
        {
            try
            {
                Comando.Connection = conexion.AbrirConexion();
                Comando.CommandText = "Select * from Usuarios WHERE contraseña = '" + contrasena + "' and Nombre_Usuario = '" + NomUsuario + "' ";
                int a = Convert.ToInt32(Comando.ExecuteScalar()); //mira cuantos valores retorna
                Comando.Parameters.Clear();
                if (a == 0)
                {
                    MessageBox.Show("Usuario o contraseña invalidos");
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    FormBaloncesto inicio = new FormBaloncesto();
                    inicio.Show();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
