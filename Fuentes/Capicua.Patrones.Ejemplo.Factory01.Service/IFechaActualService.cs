using System;
using System.ServiceModel;

namespace Capicua.Patrones.Ejemplo.Factory01.Service
{
    /// <summary>
    /// Interfaz del servicio
    /// </summary>
    [ServiceContract]
    public interface IFechaActualService
    {
        /// <summary>
        /// Obtiene la fecha actual
        /// </summary>
        /// <returns>Fecha actual</returns>
        [OperationContract]
        DateTime Obtener();
    }
}