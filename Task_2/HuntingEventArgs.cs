using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public delegate void HuntingDelegate(object sender, HuntingEventArgs e);

    public class HuntingEventArgs : EventArgs
    {
        private int PositionX { get; set; }

        private int PositionY { get; set; }

        public HuntingEventArgs(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public override string ToString()
        {
            return $"{this.PositionX}.{this.PositionY}";
        }
    }
}
