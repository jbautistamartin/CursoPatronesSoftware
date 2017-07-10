using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace Capicua.Patrones.Ejemplo.AbtractFactory01.Persistencia
{
    internal static class Empleado
    {
        /// <summary>
        /// REcupero los empelados
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Capicua.Patrones.Ejemplo.AbtractFactory01.Empleado> ObtenerEmpleados()
        {
            //obtengo la Configuración
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EjemploPatronesSoftwareConnectionString"];

            //Obtengo La factoria
            DbProviderFactory factory = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName);

            //Obtengo la conexion
            using (DbConnection conexion = factory.CreateConnection())
            {
                //set the connection string
                conexion.ConnectionString = connectionStringSettings.ConnectionString;

                //open the connection
                conexion.Open();

                // Creo un comando
                DbCommand comando = conexion.CreateCommand();
                comando.CommandText = "select * from empleado";

                //execute a datareader, closing the connection when all the data is read from it
                using (DbDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (dr.Read())
                    {
                        yield return new Capicua.Patrones.Ejemplo.AbtractFactory01.Empleado { Id = long.Parse(dr["id"].ToString()), Nombre = (string)dr["nombre"] };
                    }
                }
            }
        }
    }
}