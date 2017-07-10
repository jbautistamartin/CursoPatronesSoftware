using System;
using System.ServiceModel;

namespace Capicua.Patrones.Ejemplo.Adapter01.Service
{
    /// <summary>
    /// Interfaz del servicio
    /// </summary>
    [ServiceContract]
    public interface ICurrentDateTimeService
    {
        /// <summary>
        /// Obtiene la fecha actual
        /// </summary>
        /// <returns>Fecha actual</returns>
        [OperationContract]
        DateTime Obtain();
    }
}