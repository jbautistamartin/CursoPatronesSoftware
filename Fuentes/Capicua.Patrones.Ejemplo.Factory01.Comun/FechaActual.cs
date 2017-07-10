using System;

namespace Capicua.Patrones.Ejemplo.Factory01.Comun
{
    /// <summary>
    /// Clase para trabajar con la fecha actual
    /// </summary>
    public abstract class FechaActual : IFechaActual
    {
        /// <summary>
        /// Obtiene la fecha actual
        /// </summary>
        /// <returns>Fecha actual</returns>
        public abstract DateTime Obtener();
    }
}