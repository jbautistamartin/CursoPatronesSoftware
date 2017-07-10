using System.Configuration;
using System.Data.Common;

namespace Capicua.Patrones.Ejemplo.Command01.Persistencia
{
    internal static class EmpleadoCommandCreador
    {
        public static DbCommand Create(string nombreConexion)
        {
            //obtengo la Configuración
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings[nombreConexion];

            //Obtengo La factoria
            DbProviderFactory factory = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName);

            EmpleadoPersistencia empleadoPersistencia = new EmpleadoPersistencia(factory, connectionStringSettings.ConnectionString);

            return empleadoPersistencia.ObtenerEmpleados();
        }
    }
}