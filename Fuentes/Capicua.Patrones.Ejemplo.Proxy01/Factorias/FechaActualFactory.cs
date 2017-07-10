using Capicua.Patrones.Ejemplo.Factory01.Comun;
using Capicua.Patrones.Ejemplo.Factory01.Local;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection;
using System;

namespace Capicua.Patrones.Ejemplo.Proxy01.Factorias
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
                    return PolicyInjection.Create<FechaActualServiceReference.FechaActualServiceClient, IFechaActual>();

                default:
                    throw new ArgumentException("tipo");
            }
        }

        static FechaActualFactory()
        {
            //Configuro las politicas
            PolicyInjection.SetPolicyInjector(new PolicyInjector(new SystemConfigurationSource(false)));

            //Configuro lo loggings
            IConfigurationSource configurationSource = ConfigurationSourceFactory.Create();
            LogWriterFactory logWriterFactory = new LogWriterFactory(configurationSource);
            LogWriter logWriter = logWriterFactory.Create();
            Logger.SetLogWriter(logWriter);
        }
    }
}