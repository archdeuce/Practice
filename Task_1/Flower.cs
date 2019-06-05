using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Flower : Plant
    {
        public int FlowerBuds { get; set; }

        public Flower(string form, PlantColor color, int height, int buds)
            : base(form, color, height)
        {
            this.FlowerBuds = buds;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The number of flower buds {this.FlowerBuds}.");
        }
    }
}