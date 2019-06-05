using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Device : ISwitchable
    {
        public bool State { get; set; }

        public void Switch()
        {
            this.State = !this.State;
        }

        public void ToString()
        {
            if (this.State == true)
                Console.WriteLine($"{this.GetType().Name} was turned on.");
            else
                Console.WriteLine($"{this.GetType().Name} was turned off.");
        }
    }
}
