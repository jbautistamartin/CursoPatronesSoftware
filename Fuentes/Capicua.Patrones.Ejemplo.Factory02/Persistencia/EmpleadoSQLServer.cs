using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Capicua.Patrones.Ejemplo.Buildery01.Persistencia
{
    internal class EmpleadoSQLServer : IEmpleadoPersistencia
    {
        /// <summary>
        /// REcupero los empelados
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Capicua.Patrones.Ejemplo.Buildery01.Empleado> ObtenerEmpleados()
        {
            SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();

            builder.DataSource = @"(local)\SqlExpress";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "EjemploPatronesSoftware";

            //Obtengo la conexion
            using (SqlConnection conexion = new SqlConnection(builder.ConnectionString))
            {
                //open the connection
                conexion.Open();

                // Creo un comando
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandText = "select * from empleado";

                //execute a datareader, closing the connection when all the data is read from it
                using (DbDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (dr.Read())
                    {
                        yield return new Capicua.Patrones.Ejemplo.Buildery01.Empleado { Id = long.Parse(dr["id"].ToString()), Nombre = (string)dr["nombre"] };
                    }
                }
            }
        }
    }
}