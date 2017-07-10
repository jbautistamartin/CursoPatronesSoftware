using System.Data.Common;

namespace Capicua.Patrones.Ejemplo.Command01.Persistencia
{
    internal class EmpleadoPersistencia : IEmpleadoPersistencia
    {
        private string cadenaConexion = null;

        private DbProviderFactory factory = null;

        public EmpleadoPersistencia(DbProviderFactory factory, string cadenaConexion)
        {
            this.factory = factory;
            this.cadenaConexion = cadenaConexion;
        }

        /// <summary>
        /// REcupero los empelados
        /// </summary>
        /// <returns></returns>
        public DbCommand ObtenerEmpleados()
        {
            //Obtengo la conexion
            DbConnection conexion = factory.CreateConnection();

            //set the connection string
            conexion.ConnectionString = this.cadenaConexion;

            // Creo un comando
            DbCommand comando = conexion.CreateCommand();
            comando.CommandText = "select * from empleado";

            return comando;
        }
    }
}