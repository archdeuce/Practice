using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Bicycle : Vehicle
    {
        public BicycleType Type { get; set; }
        public BreakType Brake { get; set; }

        public Bicycle(BicycleType bicycleType, BreakType breakType, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            Type = bicycleType;
            Brake = breakType;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = tableColor;

            Console.WriteLine(String.Format("{0, -10} {1, -5} {2, -8} {3, -14} {4, -11} {5, -9}", "WheelCount", "Color", "MaxSpeed", "PassengerCount", "BicycleType", "BreakType"));

            Console.WriteLine(String.Format("{0, -10} {1, -5} {2, -8} {3, -14} {4, -11} {5, -9}", WheelCount, Color, MaxSpeed, PassengerCount, Type, Brake) + "\n");

            Console.ResetColor();
        }
    }

    public enum BicycleType
    {
        RoadBike,
        MountainBike,
        BMX
    }

    public enum BreakType
    {
        HandBrakes,
        FootBrakes
    }
}
