using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensNotFull
{
    public delegate void FridgeDelegate(object sender, FridgeEventArgs e);

    public class FridgeEventArgs : EventArgs
    {
        public FridgeEventArgs()
        {
        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}

