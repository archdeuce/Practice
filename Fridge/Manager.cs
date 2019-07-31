using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge
{
    public class Manager
    {
        Fridge myFridge = new Fridge();

        public void Execute()
        {
            this.myFridge.EventFridge += this.DisplayInfo;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(myFridge.ToString());
                Console.WriteLine("\nSelect an action:");
                Console.WriteLine($"1. Change the main door state.");
                Console.WriteLine($"2. Change the freezer door state.");
                Console.WriteLine($"3. Change the fridge power state.");


                int userInput = 0;

                Int32.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 1:
                        myFridge.ChangeMainDoorState();
                        break;
                    case 2:
                        myFridge.ChangeFreezerDoorState();
                        break;
                    case 3:
                        myFridge.ChangeFridgePowerState();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to continue.");
                        break;
                }

                Console.ReadKey();
            }
        }

        public void DisplayInfo(object sender, FridgeEventArgs e)
        {
            Console.WriteLine($"\nEvent! Sender - ({sender.GetType().Name}):");
            Console.WriteLine($"MainDoor:    {e.MainDoorState}\n" +
                              $"FreezerDoor: {e.FreezerDoorState}\n" +
                              $"PowerState:  {e.FridgePowerState}\n\n");
        }
    }
}
