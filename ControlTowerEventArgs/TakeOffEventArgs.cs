using System;

namespace ControlTower.ControlTowerEventArgs
{
    class TakeOffEventArgs : EventArgs
    {
        public readonly string TakeOff;

        public TakeOffEventArgs()
        {
            TakeOff = "Departed";
        }
    }
}
