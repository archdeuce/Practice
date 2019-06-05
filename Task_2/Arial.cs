using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Arial : Mammal
    {
        public Arial(int weight, int age, string beast)
            : base(weight, age, beast)
        {
            this.FoodIndex = 3;
        }

        public override void Move()
        {
            Console.WriteLine("Flies.");
        }
    }
}
