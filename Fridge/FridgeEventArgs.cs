using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge
{
    public delegate void FridgeDelegate(object sender, FridgeEventArgs e);

    public class FridgeEventArgs : EventArgs
    {
        public PowereState FridgePowerState { get; }

        public DoorState FreezerDoorState { get; }

        public DoorState MainDoorState { get; }

        public FridgeEventArgs(PowereState fridgePowerState, DoorState freezerDoorState, DoorState mainDoorState)
        {
            this.FridgePowerState = fridgePowerState;
            this.FreezerDoorState = freezerDoorState;
            this.MainDoorState = mainDoorState;
        }
    }
}

