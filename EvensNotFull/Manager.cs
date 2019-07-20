using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensNotFull
{
    class Manager
    {
        Fridge myFridge = new Fridge();

        public void Execute()
        {
            this.myFridge.EventFridge += this.OnFridge;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an action:");
                Console.WriteLine($"1. Power management of the refrigerator (Now: {myFridge.CurrentFridgePowerState()}).");
                Console.WriteLine($"2. Control the freezer door (Now: {myFridge.CurrentFreezerDoorState()}).");
                Console.WriteLine($"3. Control the main door (Now: {myFridge.CurrentMainDoorState()}).");

                int userInput = 0;

                Int32.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 1:
                        myFridge.ChangeFridgePowerState();
                        break;
                    case 2:
                        myFridge.ChangeFreezerDoorState();
                        break;
                    case 3:
                        myFridge.ChangeMainDoorState();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        void OnFridge(object sender, FridgeEventArgs e)
        {
            Console.WriteLine($"Fridge state changed.\n");

            this.myFridge.DoFridge();
        }
    }
}
