using Capicua.Patrones.Ejemplo.Factory01.Comun;
using System;

namespace Capicua.Patrones.Ejemplo.Factory01.Adapter
{
    internal class CurrentDateTimeAdapter : IFechaActual
    {
        private CurrentDateTimeServiceReference.CurrentDateTimeServiceClient client = new CurrentDateTimeServiceReference.CurrentDateTimeServiceClient();

        public DateTime Obtener()
        {
            return client.Obtain();
        }
    }
}