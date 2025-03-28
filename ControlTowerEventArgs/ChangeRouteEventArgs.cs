using System;

namespace ControlTower.ControlTowerEventArgs
{
    class ChangeRouteEventArgs : EventArgs
    {
        /// <summary>
        /// Current route of the flight.
        /// </summary>
        public readonly string Route;

        /// <summary>
        /// Current route
        /// </summary>
        /// <param name="route">Route as a string</param>
        public ChangeRouteEventArgs(string route)
        {
            Route = route;
        }
        /// <summary>
        /// Current route is empty.
        /// </summary>
        public ChangeRouteEventArgs()
        {
            Route = string.Empty;
        }
    }
}
