using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Terrestrial : Mammal
    {
        public Terrestrial(int weight, int age, string beast)
            : base(weight, age, beast)
        {
            this.FoodIndex = 1;
        }

        public override void Move()
        {
            Console.WriteLine("Runs on the ground.");
        }
    }
}