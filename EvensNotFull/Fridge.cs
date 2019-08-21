using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensNotFull
{
    public class Fridge
    {
        private FridgeState FridgePowerState { get; set; }

        private DoorState FreezerDoorState { get; set; }

        private DoorState MainDoorState { get; set; }

        public event FridgeDelegate EventFridge;

        public Fridge() 
        {
            this.FridgePowerState = FridgeState.off;
            this.FreezerDoorState = DoorState.close;
            this.MainDoorState = DoorState.close;
        }

        public Fridge(FridgeState fridgePowerState, DoorState freezerDoorState, DoorState mainDoorState)
        {
            this.FridgePowerState = fridgePowerState;
            this.FreezerDoorState = freezerDoorState;
            this.MainDoorState = mainDoorState;
        }

        public FridgeState CurrentFridgePowerState()
        {
            return this.FridgePowerState;
        }
        public DoorState CurrentFreezerDoorState()
        {
            return this.FreezerDoorState;
        }

        public DoorState CurrentMainDoorState()
        {
            return this.MainDoorState;
        }

        public void ChangeFridgePowerState()
        {
            if (CurrentFridgePowerState() == FridgeState.on)
                this.FridgePowerState = FridgeState.off;
            else
                this.FridgePowerState = FridgeState.on;
        }

        public void ChangeFreezerDoorState()
        {
            if (CurrentFreezerDoorState() == DoorState.open)
                this.FreezerDoorState = DoorState.close;
            else
                this.FreezerDoorState = DoorState.open;
        }

        public void ChangeMainDoorState()
        {
            if (CurrentMainDoorState() == DoorState.open)
                this.MainDoorState = DoorState.close;
            else
                this.MainDoorState = DoorState.open;
        }

        protected virtual void OnFridge(object sender, FridgeEventArgs e)
        {
            this.EventFridge?.Invoke(this, e);
        }

        public void DoFridge()
        {
            Console.WriteLine("Fridge state changed.\n");

            System.Threading.Thread.Sleep(1000);

            this.OnFridge(new object(), new FridgeEventArgs());
        }
    }
}
