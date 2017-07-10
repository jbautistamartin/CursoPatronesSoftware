using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Buildery01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSQLServer_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = Persistencia.Empleado.ObtenerEmpleadosSQLServer();
        }

        private void btnSQLite_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = Persistencia.Empleado.ObtenerEmpleadosSQLite();
        }
    }
}