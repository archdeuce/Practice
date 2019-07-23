using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Ping
    {
        public event PingPongDelegate EventPing;

        protected virtual void OnPing(PingPongEventArgs e)
        {
            this.EventPing?.Invoke(this, e);
        }

        public void DoPing()
        {
            Console.WriteLine("Ping.\n");

            System.Threading.Thread.Sleep(1000);

            this.OnPing(new PingPongEventArgs(DateTime.Now));
        }
    }
}