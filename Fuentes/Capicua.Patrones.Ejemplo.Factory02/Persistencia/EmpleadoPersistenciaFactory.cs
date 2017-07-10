using System;

namespace Capicua.Patrones.Ejemplo.Buildery01.Persistencia
{
    internal static class EmpleadoPersistenciaFactory
    {
        public static IEmpleadoPersistencia Create(EmpleadoPersistenciaTipo tipo)
        {
            switch (tipo)
            {
                case EmpleadoPersistenciaTipo.SQLServer:
                    return new EmpleadoSQLServer();

                case EmpleadoPersistenciaTipo.SQLLite:
                    return new EmpleadoSQLite();

                default:
                    throw new ArgumentException("tipo");
            }
        }
    }
}