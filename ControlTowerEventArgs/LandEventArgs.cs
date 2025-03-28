using System;

namespace ControlTower.ControlTowerEventArgs
{
    class LandEventArgs : EventArgs
    {
        public readonly string Land;

        public LandEventArgs()
        {
            Land = "Arrived";
        }
    }
}
