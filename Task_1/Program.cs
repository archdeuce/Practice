using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(4, EngineType.Diesel, GearBoxType.Manual, 4, ConsoleColor.Cyan, 200, 5),
                new Bicycle(BicycleType.BMX, BreakType.FootBrakes, 2, ConsoleColor.Green, 40, 1),
                new Moto(MotoType.Chopper, 2, ConsoleColor.Red, 160, 2)
            };

            Random rand = new Random();

            foreach (var item in vehicles)
            {
                item.Move(rand.Next(5000));

                if (item is Car tmpCar)
                    tmpCar.DisplayInfo();
                else if (item is Bicycle tmpBicycle)
                    tmpBicycle.DisplayInfo();
                else if (item is Moto tmpMoto)
                    tmpMoto.DisplayInfo();
            }

            Console.ReadKey();
        }
    }
}
