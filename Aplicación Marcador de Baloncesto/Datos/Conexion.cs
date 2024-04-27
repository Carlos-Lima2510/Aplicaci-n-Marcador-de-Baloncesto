using System.Data.SqlClient;
using System.Data;

namespace Aplicación_Marcador_de_Baloncesto.Datos
{
    class Conexion
    {
        static private string CadenaConexion = "Server= LAPTOP-C3RL3T0; DataBase=Usuarios; Integrated Security=true";
        private SqlConnection conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
