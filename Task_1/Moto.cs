using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Moto : Vehicle
    {
        public MotoType Type { get; set; }

        public Moto(MotoType MotoType, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            Type = MotoType;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = tableColor;

            Console.WriteLine(String.Format("{0, -10} {1, -5} {2, -8} {3, -14} {4, -8}", "WheelCount", "Color", "MaxSpeed", "PassengerCount", "MotoType"));

            Console.WriteLine(String.Format("{0, -10} {1, -5} {2, -8} {3, -14} {4, -8}", WheelCount, Color, MaxSpeed, PassengerCount, Type) + "\n");

            Console.ResetColor();
        }
    }

    public enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        Enduro
    }
}
