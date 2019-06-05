using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public EngineType Engine { get; set; }
        public GearBoxType GearBox { get; set; }

        public Car(int doorsCount, EngineType engine, GearBoxType gearBox, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            DoorsCount = doorsCount;
            Engine = engine;
            GearBox = gearBox;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = tableColor;

            Console.WriteLine(String.Format("{0, -10} {1, -5} {2, -8} {3, -14} {4, -10} {5, -6} {6, -7}", "WheelCount", "Color", "MaxSpeed", "PassengerCount", "DoorsCount", "Engine", "Gearbox "));

            Console.WriteLine(String.Format("{0, -10} {1, -5} {2, -8} {3, -14} {4, -10} {5, -6} {6, -7}", WheelCount, Color, MaxSpeed, PassengerCount, DoorsCount, Engine, GearBox) + "\n");

            Console.ResetColor();
        }
    }

    public enum EngineType
    {
        Petrol,
        Diesel,
        Electro
    }

    public enum GearBoxType
    {
        Manual,
        Auto,
        Robot
    }
}
