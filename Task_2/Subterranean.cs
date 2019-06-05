using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Subterranean : Mammal
    {
        public Subterranean(int weight, int age, string beast)
            : base(weight, age, beast)
        {
            this.FoodIndex = 2;
        }

        public override void Move()
        {
            Console.WriteLine("Digs the ground.");
        }
    }
}
