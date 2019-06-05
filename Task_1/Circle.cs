using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Circle : Figure
    {
        private int Radius { get; set; }

        public Circle(int centerX, int centerY, int radius)
            : base(centerX, centerY)
        {
            this.Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle was drawn by coordinates {CenterX},{CenterY} with radius {Radius}.");
        }
    }
}
