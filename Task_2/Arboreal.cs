using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Arboreal : Mammal
    {
        public Arboreal(int weight, int age, string beast)
            : base(weight, age, beast)
        {
            this.FoodIndex = 5;
        }

        public override void Move()
        {
            Console.WriteLine("Creeps on trees.");
        }
    }
}
