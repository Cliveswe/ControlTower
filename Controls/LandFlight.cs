using ControlTower.ControlTowerEventArgs;
using System;

namespace ControlTower.Controls
{
    class LandFlight : FlightButton
    {
        /// <summary>
        /// Event handler for this button.
        /// Make use of the generic event handler EventHandler<T> and 
        /// to make use of the custom EvenArgs.
        /// </summary>
        public event EventHandler<LandEventArgs> FlightArrived;
        public override bool ButtonCanExecute(object parameter)
        {
            return Isvalid;
        }
        /// <summary>
        /// Invoke the event.
        /// </summary>
        private void OnFlightArried()
        {
            FlightArrived?.Invoke(this, new LandEventArgs());
        }
        /// <summary>
        /// Button has been pressed perform actions.
        /// </summary>
        /// <param name="parameter">Object from the XAML</param>
        public override void ButtonExecute(object parameter)
        {
            Isvalid = false;
            OnFlightArried();
        }

        public LandFlight(string content) : base()
        {
            ButtonContent = content;
            Isvalid = false;

        }
    }
}
