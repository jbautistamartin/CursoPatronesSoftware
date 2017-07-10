using Capicua.Patrones.Ejemplo.Factory01.Comun;
using System;

namespace Capicua.Patrones.Ejemplo.Factory01.Local
{
    /// <summary>
    /// Clase para obtener la fecha local
    /// </summary>
    /// <seealso cref="Capicua.Patrones.Ejemplo.Factory01.Comun.FechaActual" />
    public class FechaLocal : FechaActual
    {
        /// <summary>
        /// Obtiene la fecha actual
        /// </summary>
        /// <returns>
        /// Fecha actual
        /// </returns>
        public override DateTime Obtener()
        {
            return DateTime.Now;
        }
    }
}