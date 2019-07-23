using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Hunter
    {
        public void Hunt(object sender, HuntingEventArgs e)
        {
            Console.WriteLine($"{this.GetType().Name}: The target ({sender.GetType().Name}) moved to a new position ({e.ToString()}).\n");
        }
    }
}