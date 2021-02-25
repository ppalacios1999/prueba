using System;

namespace Backend.Inhumaciones.Utilities.Telemetry
{
    public interface ITelemetryException
    {
        void RegisterException(Exception exception);
    }
}