using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Singleton01
{
    /// <summary>
    /// Forma hija 1
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FrmHija1 : Form
    {
        private static readonly Lazy<FrmHija1> instancia = new Lazy<FrmHija1>(() => new FrmHija1());

        private FrmHija1()
        {
            InitializeComponent();
        }

        // Propiedad para acceder a la instancia
        public static FrmHija1 Instancia
        {
            get
            {
                return instancia.Value;
            }
        }

        private void FrmHija1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}