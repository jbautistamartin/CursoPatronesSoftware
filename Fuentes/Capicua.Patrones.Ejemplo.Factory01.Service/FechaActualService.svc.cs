using Capicua.Patrones.Ejemplo.Factory01.Local;

namespace Capicua.Patrones.Ejemplo.Factory01.Service
{
    /// <summary>
    /// Servicio de hora remoto, hereda de Fecha Local con lo que no hay que nada
    /// </summary>
    /// <seealso cref="Capicua.Patrones.Ejemplo.Factory01.Local.FechaLocal" />
    /// <seealso cref="Capicua.Patrones.Ejemplo.Factory01.Service.IFechaActualService" />
    public class FechaActualService : FechaLocal, IFechaActualService
    {
    }
}