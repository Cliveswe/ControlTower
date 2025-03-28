using System;

namespace ControlTower.ControlTowerEventArgs
{
    class FlightStatusEventArgs : EventArgs
    {
        public readonly string FlightCode;
        public readonly string FlightStatus;
        public readonly DateTime FlightStatusUpdateTime;

        public FlightStatusEventArgs(string flightCode, string flightStatus, DateTime dateTime)
        {
            FlightStatus = flightStatus;
            FlightCode = flightCode;
            FlightStatusUpdateTime = dateTime;
        }
    }
}
