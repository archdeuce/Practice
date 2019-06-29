using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Plant
    {
        public string Name { get; set; }

        public PlantColor Color { get; set; }

        public int Height { get; set; }

        public Plant()
        {
        }

        public Plant(string name, PlantColor color, int height)
        {
            this.Name = name;

            this.Color = color;

            this.Height = height;
        }

        public void PlantCare(int water, int minerals)
        {
            //
            // From watering the plant grows.
            //
            if (water > 0)
            {
                Console.WriteLine($"The plant {this.Name} was watered with {water} portions of water.");

                this.Height += water;

                Console.WriteLine($"The plant {this.Name} grows. Height {this.Height} conditional units.");
            }

            //
            // From feeding, the plant changes color.
            //
            if (minerals > 0)
            {
                Console.WriteLine($"The plant {this.Name} has bloome.");

                Console.WriteLine($"The plant {this.Name} has color {this.Color}.");
            }

            //
            // When watering and feeding at the same time the plant produces oxygen.
            //
            if (minerals > 0 && water > 0)
                Console.WriteLine($"The plant {this.Name} allocated of oxygen.");
        }
    }
}

public enum PlantColor
{
    white,
    green,
    yellow,
    brown
}