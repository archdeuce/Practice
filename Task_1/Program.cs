using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[] {
                new Circle(67,48,10),
                new Circle(21,0,20),
                new Circle(1,35,30),
                new Square(0,3,40),
                new Square(34,0,50),
                new Square(0,23,60),
                new Triangle(8,5,10,10,10),
                new Triangle(65,34,11,20,30),
                new Triangle(89,45,20,20,30),
                new Triangle(34,0,30,20,30)
        };

            foreach (var item in figures)
            {
                if (item is Circle newCircle)
                    newCircle.Draw();
                else if (item is Square newSquare)
                    newSquare.Draw();
                else if (item is Triangle newTriangle)
                    newTriangle.Draw();
            }

            Console.ReadKey();
        }
    }
}
