using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Capicua.Patrones.Ejemplo.Buildery01.Persistencia
{
    internal static class Empleado
    {
        /// <summary>
        /// REcupero los empelados
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Capicua.Patrones.Ejemplo.Buildery01.Empleado> ObtenerEmpleadosSQLServer()
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

        public static IEnumerable<Capicua.Patrones.Ejemplo.Buildery01.Empleado> ObtenerEmpleadosSQLite()
        {
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();

            builder.DataSource = @"C:\CapacitacionPatrones\Scripts\Sqlite\EjemploPatronesSoftware.db";

            //Obtengo la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(builder.ConnectionString))
            {
                //open the connection
                conexion.Open();

                // Creo un comando
                SQLiteCommand comando = conexion.CreateCommand();
                comando.CommandText = "select * from empleado";

                //execute a datareader, closing the connection when all the data is read from it
                using (DbDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (dr.Read())
                    {
                        yield return new Capicua.Patrones.Ejemplo.Buildery01.Empleado { Id = (long)dr["id"], Nombre = (string)dr["nombre"] };
                    }
                }
            }
        }
    }
}