using Capicua.Patrones.Ejemplo.Buildery01.Persistencia;
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
            IEmpleadoPersistencia empleadoPersistencia = EmpleadoPersistenciaFactory.Create(EmpleadoPersistenciaTipo.SQLServer);
            bindingSource.DataSource = empleadoPersistencia.ObtenerEmpleados();
        }

        private void btnSQLite_Click(object sender, EventArgs e)
        {
            IEmpleadoPersistencia empleadoPersistencia = EmpleadoPersistenciaFactory.Create(EmpleadoPersistenciaTipo.SQLLite);
            bindingSource.DataSource = empleadoPersistencia.ObtenerEmpleados();
        }
    }
}