using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Vehicle
    {
        private int wheelCount;

        private int maxSpeed;

        public ConsoleColor Color { get; set; }

        public int PassengerCount { get; set; }

        public int WheelCount
        {
            get
            {
                return wheelCount;
            }
            set
            {
                if (value > 0)
                    wheelCount = value;
                else
                    wheelCount = 1;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0)
                    maxSpeed = value;
                else
                    maxSpeed = 1;
            }
        }

        public Vehicle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
        {
            this.WheelCount = wheelCount;

            this.Color = color;

            this.MaxSpeed = maxSpeed;

            this.PassengerCount = passengerCount;
        }

        public void Move(int meters)
        {
            Console.ForegroundColor = Color;

            Console.WriteLine($"{GetType().Name} has moved {meters} meters.");
        }
    }
}
