using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Capicua.Patrones.Ejemplo.Command01.Persistencia
{
    /// <summary>
    /// Invocador de comandos
    /// </summary>
    internal class EmpleadoCommandInvocador
    {
        private IEnumerable<DbCommand> comandos;

        /// <summary>
        /// Invocador
        /// </summary>
        /// <param name="comandos">Comandos a invocar</param>
        public EmpleadoCommandInvocador(IEnumerable<DbCommand> comandos)
        {
            this.comandos = comandos;
        }

        public IEnumerable<Empleado> Ejecutar()
        {
            List<Empleado> resultado = new List<Empleado>();

            foreach (DbCommand comando in comandos)
            {
                try
                {
                    //Abro conexión
                    comando.Connection.Open();

                    //execute a datareader, closing the connection when all the data is read from it
                    using (DbDataReader dr = comando.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            resultado.Add(new Empleado { Id = long.Parse(dr["id"].ToString()), Nombre = (string)dr["nombre"] });
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                finally
                {
                    //Cierro conexion
                    comando.Connection.Close();
                }
            }

            return resultado;
        }
    }
}