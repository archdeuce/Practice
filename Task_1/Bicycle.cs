using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Bicycle : Vehicle
    {
        public BicycleType Type { get; set; }

        public BreakType Brake { get; set; }

        public Bicycle(BicycleType bicycleType, BreakType breakType, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            this.Type = bicycleType;

            this.Brake = breakType;
        }

    }

    enum BicycleType
    {
        RoadBike = 0,
        MountainBike = 1,
        BMX = 2
    }

    enum BreakType
    {
        HandBrakes = 0,
        FootBrakes = 1
    }
}
