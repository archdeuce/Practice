using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public delegate void KeyDelegate(object sender, KeyEventArgs e);

    public class KeyEventArgs : EventArgs
    {
        public ConsoleKeyInfo KeyInfo { get; private set; }

        public KeyEventArgs(ConsoleKeyInfo keyInfo)
        {
            this.KeyInfo = keyInfo;
        }
    }
}
