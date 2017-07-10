using Capicua.Patrones.Ejemplo.Factory01.Comun;
using Capicua.Patrones.Ejemplo.Factory01.Local;
using System;

namespace Capicua.Patrones.Ejemplo.Factory01.Factorias
{
    /// <summary>
    /// Fabrica para FechaActual
    /// </summary>
    public static class FechaActualFactory
    {
        public static IFechaActual Create(FechaActualTipos tipo)
        {
            switch (tipo)
            {
                case FechaActualTipos.Local:
                    return new FechaLocal();

                case FechaActualTipos.Remoto:
                    return new FechaActualServiceReference.FechaActualServiceClient();

                default:
                    throw new ArgumentException("tipo");
            }
        }
    }
}