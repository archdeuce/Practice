using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Pong
    {
        public event PingPongDelegate EventPong;

        protected virtual void OnPong(PingPongEventArgs e)
        {
            this.EventPong?.Invoke(this, e);
        }

        public void DoPong()
        {
            Console.WriteLine("Pong.\n");

            System.Threading.Thread.Sleep(1000);

            this.OnPong(new PingPongEventArgs(DateTime.Now));
        }
    }
}
