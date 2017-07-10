using System;

namespace Capicua.Patrones.Ejemplo.Adapter01.Service
{
    /// <summary>
    /// Servicio de hora remoto, hereda de Fecha Local con lo que no hay que nada
    /// </summary>
    /// <seealso cref="Capicua.Patrones.Ejemplo.Adapter01.Local.FechaLocal" />
    /// <seealso cref="Capicua.Patrones.Ejemplo.Adapter01.Service.ICurrentDateTimeService" />
    public class FechaActualService : ICurrentDateTimeService
    {
        public DateTime Obtain()
        {
            return DateTime.Now;
        }
    }
}