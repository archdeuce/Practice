using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public delegate void PingPongDelegate(object sender, PingPongEventArgs e);

    public class PingPongEventArgs : EventArgs
    {
        private DateTime eventTime;

        public PingPongEventArgs(DateTime eventTime)
        {
            this.eventTime = eventTime;
        }

        public override string ToString()
        {
            return eventTime.ToString();
        }
    }
}
