using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Figure
    {
        public int CenterX { get; set; }

        public int CenterY { get; set; }

        public Figure(int centerX, int centerY)
        {
            this.CenterX = centerX;

            this.CenterY = centerY;
        }

        public virtual void Draw()
        {
        }
    }
}
