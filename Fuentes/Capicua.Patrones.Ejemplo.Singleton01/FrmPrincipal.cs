using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Singleton01
{
    /// <summary>
    /// Clase principal
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FrmPrincipal : Form
    {
        private static readonly Lazy<FrmPrincipal> instancia = new Lazy<FrmPrincipal>(() => new FrmPrincipal());

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Propiedad para acceder a la instancia
        public static FrmPrincipal Instancia
        {
            get
            {
                return instancia.Value;
            }
        }

        private void formaHija1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(FrmHija1.Instancia);
        }

        private void formaHija2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(FrmHija2.Instancia);
        }

        private void ShowForm(Form instancia)
        {
            instancia.MdiParent = this;
            instancia.Show();
            if (instancia.WindowState == FormWindowState.Minimized) instancia.WindowState = FormWindowState.Normal;
            instancia.Activate();
        }
    }
}