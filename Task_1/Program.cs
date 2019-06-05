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
            Mammal[] mammals = new Mammal[]
                {
                    new Aquatic(1, 0, "Manatee"),
                    new Aquatic(6, 3, "Sea lion"),
                    new Arboreal(10, 0, "Sloth"),
                    new Arboreal(4, 1, "Chimpanzee"),
                    new Arial(1, 0, "Bat"),
                    new Arial(2, 2, "Flying squirrel"),
                    new Subterranean(1, 0, "Marmot"),
                    new Subterranean(2, 1, "Mole"),
                    new Terrestrial(100, 0, "Horse"),
                    new Terrestrial(100, 5, "Guepard")
                };

            new Feeder().Feed(mammals);

            Console.ReadKey();
        }
    }
}