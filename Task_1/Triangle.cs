using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Triangle : Figure
    {
        protected int SideA { get; set; }

        protected int SideB { get; set; }

        protected int SideC { get; set; }

        public Triangle(int centerX, int centerY, int sideA, int sideB, int sideC)
            : base(centerX, centerY)
        {
            this.SideA = sideA;

            this.SideB = sideB;

            this.SideC = sideC;
        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle was drawn by coordinates {CenterX},{CenterY} with side {SideA}, {SideB}, {SideC}.");
        }
    }
}
