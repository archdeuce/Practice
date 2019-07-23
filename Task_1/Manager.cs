using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Manager
    {
        Ping ping = new Ping();

        Pong pong = new Pong();

        public void Execute()
        {
            this.ping.EventPing += this.OnPingInvoked;
            this.pong.EventPong += this.OnPongInvoked;

            ping.DoPing();
        }

        void OnPingInvoked(object sender, PingPongEventArgs e)
        {
            Console.WriteLine($"PongEventTime: {e}.\n");

            this.pong.DoPong();
        }

        void OnPongInvoked(object sender, PingPongEventArgs e)
        {
            Console.WriteLine($"PingEventTime: {e}.\n");

            this.ping.DoPing();
        }
    }
}