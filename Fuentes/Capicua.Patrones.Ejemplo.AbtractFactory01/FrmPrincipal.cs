using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.AbtractFactory01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdo_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = Persistencia.Empleado.ObtenerEmpleados();
        }
    }
}