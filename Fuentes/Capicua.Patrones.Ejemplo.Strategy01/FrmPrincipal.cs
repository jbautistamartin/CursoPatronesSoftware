using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Strategy01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            LogEntry entrada = new LogEntry
            {
                //  Categories = new string[] { "Informacion" },
                Message = txtMensaje.Text,
                Severity = System.Diagnostics.TraceEventType.Information,
            };
            Logger.Write(entrada);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            LogEntry entrada = new LogEntry
            {
                Categories = new string[] { "Error" },
                Message = txtMensaje.Text,
                Severity = System.Diagnostics.TraceEventType.Critical,
            };
            Logger.Write(entrada);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                IConfigurationSource configurationSource = ConfigurationSourceFactory.Create();
                LogWriterFactory logWriterFactory = new LogWriterFactory(configurationSource);
                LogWriter logWriter = logWriterFactory.Create();
                Logger.SetLogWriter(logWriter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}