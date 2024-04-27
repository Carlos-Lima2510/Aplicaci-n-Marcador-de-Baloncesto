using Aplicación_Marcador_de_Baloncesto.Interfaces;
using System;
using System.Windows.Forms;

namespace Aplicación_Marcador_de_Baloncesto
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
