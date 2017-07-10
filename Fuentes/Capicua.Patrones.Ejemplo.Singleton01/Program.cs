using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Singleton01
{
    internal static class Program
    {
        /// <summary>
        /// Forma principal
        /// </summary>
        /// <value>
        /// la forma principal
        /// </value>
        public static FrmPrincipal FrmPrincipal
        {
            get
            {
                return FrmPrincipal.Instancia;
            }
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Program.FrmPrincipal);
        }
    }
}