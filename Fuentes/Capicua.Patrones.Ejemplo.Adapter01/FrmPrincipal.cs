using Capicua.Patrones.Ejemplo.Adapter01.Factorias;
using Capicua.Patrones.Ejemplo.Factory01.Comun;
using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Factory01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            IFechaActual fechaActual = ObtenerClaseFechaActual();
            MessageBox.Show(fechaActual.Obtener().ToString());
        }

        /// <summary>
        /// Obtengo la clase para la fecha actual
        /// </summary>
        /// <returns></returns>
        private IFechaActual ObtenerClaseFechaActual()
        {
            return FechaActualFactory.Create(ObtenerTipoFechaActual());
        }

        /// <summary>
        /// Obtengo el tipo actual
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException">Opcion incorrecta</exception>
        private FechaActualTipos ObtenerTipoFechaActual()
        {
            if (rdbLocal.Checked)
            {
                return FechaActualTipos.Local;
            }
            else if (rdbRemoto.Checked)
            {
                return FechaActualTipos.Remoto;
            }
            else if (rdbIngles.Checked)
            {
                return FechaActualTipos.Ingles;
            }
            else
            {
                throw new InvalidOperationException("Opcion incorrecta");
            }
        }
    }
}