using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Key
    {
        private ConsoleKeyInfo keyInfo;

        public event KeyDelegate keyEvent;

        protected virtual void OnKeyPress()
        {
            this.keyEvent?.Invoke(this, new KeyEventArgs(this.keyInfo));
        }

        public void StartReadKey()
        {
            while (true)
            {
                this.keyInfo = Console.ReadKey(true);

                this.OnKeyPress();
            }
        }
    }
}
