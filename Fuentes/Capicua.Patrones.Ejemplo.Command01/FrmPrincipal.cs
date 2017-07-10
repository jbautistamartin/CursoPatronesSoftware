using Capicua.Patrones.Ejemplo.Command01.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Command01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            List<DbCommand> comandos = new List<DbCommand>();

            //Creo los comandos
            comandos.Add(EmpleadoCommandCreador.Create("EjemploPatronesSoftwareSQLServer"));
            comandos.Add(EmpleadoCommandCreador.Create("EjemploPatronesSoftwareSQLite"));

            //Creo el invocador
            EmpleadoCommandInvocador invocador = new EmpleadoCommandInvocador(comandos);

            bindingSource.DataSource = invocador.Ejecutar();
        }
    }
}