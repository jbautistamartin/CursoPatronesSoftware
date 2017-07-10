using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Decorator02
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            //Intego habilitar todos los botores
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
    }
}