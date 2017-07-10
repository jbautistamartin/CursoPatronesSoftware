using System.Data.Common;

namespace Capicua.Patrones.Ejemplo.Command01.Persistencia
{
    internal interface IEmpleadoPersistencia
    {
        /// <summary>
        /// REcupero los empelados
        /// </summary>
        /// <returns></returns>
        DbCommand ObtenerEmpleados();
    }
}