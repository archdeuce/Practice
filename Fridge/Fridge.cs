using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge
{
    public class Fridge
    {
        private PowereState FridgePowerState { get; set; }

        private DoorState FreezerDoorState { get; set; }

        private DoorState MainDoorState { get; set; }

        public event FridgeDelegate EventFridge;

        public Fridge()
        {
            this.FridgePowerState = PowereState.off;
            this.FreezerDoorState = DoorState.close;
            this.MainDoorState = DoorState.close;
        }

        public Fridge(PowereState fridgePowerState, DoorState freezerDoorState, DoorState mainDoorState)
        {
            this.FridgePowerState = fridgePowerState;
            this.FreezerDoorState = freezerDoorState;
            this.MainDoorState = mainDoorState;
        }

        //
        // Changing the state of power supply of the fridge.
        //
        public void ChangeFridgePowerState()
        {
            if (this.FridgePowerState == PowereState.on)
                this.FridgePowerState = PowereState.off;
            else
                this.FridgePowerState = PowereState.on;

            this.OnFridge(this, new FridgeEventArgs(this.FridgePowerState, this.FreezerDoorState, this.MainDoorState));
        }

        //
        // Changing the state of the fridge freezer.
        //
        public void ChangeFreezerDoorState()
        {
            if (this.FreezerDoorState == DoorState.open)
                this.FreezerDoorState = DoorState.close;
            else
                this.FreezerDoorState = DoorState.open;

            this.OnFridge(this, new FridgeEventArgs(this.FridgePowerState, this.FreezerDoorState, this.MainDoorState));
        }

        //
        // Changing the state of the door of the main compartment of the fridge.
        //
        public void ChangeMainDoorState()
        {
            if (this.MainDoorState == DoorState.open)
                this.MainDoorState = DoorState.close;
            else
                this.MainDoorState = DoorState.open;

            this.OnFridge(this, new FridgeEventArgs(this.FridgePowerState, this.FreezerDoorState, this.MainDoorState));
        }

        //
        // Event handling.
        //
        protected virtual void OnFridge(object sender, FridgeEventArgs e)
        {
            this.EventFridge?.Invoke(sender, e);
        }

        //
        // Information about the current state of the fridge.
        //
        public override string ToString()
        {
            return $"Condition of the object ({this.GetType().Name}):\n" +
                   $"MainDoor:    {this.MainDoorState}\n" +
                   $"FreezerDoor: {FreezerDoorState}\n" +
                   $"PowerState:  {this.FridgePowerState}\n";
        }
    }
}
