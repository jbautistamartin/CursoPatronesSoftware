using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using System;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Decorator03
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnValidarAmbiente1_Click(object sender, EventArgs e)
        {
            //Validar el ambiente Uno
            Validator<Usuario> validador = ValidationFactory.CreateValidator<Usuario>("Ambiente1");
            ValidarAmbiente(validador);
        }

        private void btnValidarAmbiente2_Click(object sender, EventArgs e)
        {
            //Validar el ambiente Uno
            Validator<Usuario> validador = ValidationFactory.CreateValidator<Usuario>("Ambiente2");
            ValidarAmbiente(validador);
        }

        private void btnValidarAmbiente3_Click(object sender, EventArgs e)
        {
            this.validationProvider.PerformValidation(this);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Configuro la factoria
            ValidationFactory.SetDefaultConfigurationValidatorFactory(new SystemConfigurationSource());

            //Creo el usuario por defecto
            bindingSource.DataSource = new Usuario();
        }

        private void ValidarAmbiente<T>(Validator<T> validador)
        {
            //Usuario a validar
            Usuario usuario = (Usuario)bindingSource.DataSource;

            //Resultado
            ValidationResults resultadoValidaciones = validador.Validate(usuario);

            if (resultadoValidaciones.IsValid)
            {
                MessageBox.Show("La validación es exitosa", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (ValidationResult validacionActual in resultadoValidaciones)
                {
                    MessageBox.Show(validacionActual.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}