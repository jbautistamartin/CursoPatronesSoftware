using System.Collections.Generic;

namespace Capicua.Patrones.Ejemplo.Buildery01.Persistencia
{
    internal interface IEmpleadoPersistencia
    {
        /// <summary>
        /// REcupero los empelados
        /// </summary>
        /// <returns></returns>
        IEnumerable<Capicua.Patrones.Ejemplo.Buildery01.Empleado> ObtenerEmpleados();
    }
}