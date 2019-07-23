using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Hunting
    {
        Rabbit rabbit = new Rabbit();

        Hunter hunter = new Hunter();

        public void Execute()
        {
            this.rabbit.EventRabbit += this.hunter.Hunt;

            while (true)
            {
                rabbit.Move();

                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}