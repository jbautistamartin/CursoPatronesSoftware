using Capicua.Patrones.Ejemplo.Factory01.Comun;

namespace Capicua.Patrones.Ejemplo.Factory01.FechaActualServiceReference
{
    /// <summary>
    /// Extiendo el cliente del servicio para obtener la fecha local
    /// </summary>
    /// <seealso cref="System.ServiceModel.ClientBase{Capicua.Patrones.Ejemplo.Factory01.FechaActualServiceReference.IFechaActualService}" />
    /// <seealso cref="Capicua.Patrones.Ejemplo.Factory01.FechaActualServiceReference.IFechaActualService" />
    /// <seealso cref="Capicua.Patrones.Ejemplo.Factory01.Comun.IFechaActual" />
    public partial class FechaActualServiceClient : IFechaActual

    {
    }
}