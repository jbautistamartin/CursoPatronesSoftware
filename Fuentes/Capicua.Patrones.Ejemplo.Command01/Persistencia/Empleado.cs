using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace Capicua.Patrones.Ejemplo.Command01.Persistencia
{
    internal class EmpleadoSQLite : IEmpleadoPersistencia
    {
        public IEnumerable<Capicua.Patrones.Ejemplo.Command01.Empleado> ObtenerEmpleados()
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
                        yield return new Capicua.Patrones.Ejemplo.Command01.Empleado
                        {
                            Id = (long)dr["id"],
                            Nombre = (string)dr["nombre"]
                        };
                    }
                }
            }
        }
    }
}