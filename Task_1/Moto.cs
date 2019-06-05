using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Moto : Vehicle
    {
        public MotoType Type { get; set; }

        public Moto(MotoType MotoType, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            this.Type = MotoType;
        }

    }

    enum MotoType
    {
        Adventure = 0,
        Chopper = 1,
        Cruiser = 2,
        Enduro = 3
    }
}
