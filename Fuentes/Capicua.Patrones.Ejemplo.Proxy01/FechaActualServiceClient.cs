using Capicua.Patrones.Ejemplo.Factory01.Comun;

namespace Capicua.Patrones.Ejemplo.Proxy01.FechaActualServiceReference
{
    /// <summary>
    /// Extiendo el cliente del servicio para obtener la fecha local
    /// </summary>
    /// <seealso cref="System.ServiceModel.ClientBase{Capicua.Patrones.Ejemplo.Proxy01.FechaActualServiceReference.IFechaActualService}" />
    /// <seealso cref="Capicua.Patrones.Ejemplo.Proxy01.FechaActualServiceReference.IFechaActualService" />
    /// <seealso cref="Capicua.Patrones.Ejemplo.Proxy01.Comun.IFechaActual" />
    public partial class FechaActualServiceClient : IFechaActual

    {
    }
}