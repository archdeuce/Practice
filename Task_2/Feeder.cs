using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Feeder
    {
        Random rand = new Random();

        public void Feed(Mammal[] mammals)
        {
            foreach (var item in mammals)
            {
                item.DisplayInfo();

                item.Eat(this.rand.Next(50));

                item.Move();
            }
        }
    }
}
