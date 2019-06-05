using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Car : Vehicle
    {
        public int DoorsCount { get; set; }

        public EngineType Engine { get; set; }

        public GearBoxType GearBox { get; set; }

        public Car(int doorsCount, EngineType engine, GearBoxType gearBox, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            this.DoorsCount = doorsCount;

            this.Engine = engine;

            this.GearBox = gearBox;
        }

    }

    enum EngineType
    {
        Petrol = 0,
        Diesel = 1,
        Electro = 2
    }

    enum GearBoxType
    {
        Manual = 0,
        Auto = 1,
        Robot = 2
    }
}
