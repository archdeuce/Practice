using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Aquatic : Mammal
    {
        public Aquatic(int weight, int age, string beast)
            : base(weight, age, beast)
        {
            this.FoodIndex = 4;
        }

        public override void Move()
        {
            Console.WriteLine("Swims in the water.");
        }
    }
}
