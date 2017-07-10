using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Singleton01
{
    /// <summary>
    /// Forma Hija 2
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FrmHija2 : Form
    {
        private static FrmHija2 instancia = null;

        private static object singletonLock = new object();

        private FrmHija2()
        {
            InitializeComponent();
        }

        // Propiedad para acceder a la instancia
        public static FrmHija2 Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    lock (singletonLock)
                    {
                        if (instancia == null || instancia.IsDisposed)
                        {
                            instancia = new FrmHija2();
                        }
                    }
                }

                return instancia;
            }
        }
    }
}