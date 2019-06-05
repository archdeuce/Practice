using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Square : Figure
    {
        private int Side { get; set; }

        public Square(int centerX, int centerY, int side)
            : base(centerX, centerY)
        {
            this.Side = side;
        }

        public void Draw()
        {
            Console.WriteLine($"Square was drawn by coordinates {CenterX},{CenterY} with side {Side}.");
        }
    }
}
