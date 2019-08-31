using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing
{
    public class RoadSide
    {
        private int k;

        private int j;

        private int roadSideX1;

        private int roadSideX2;

        private int roadSideY1;

        private int roadSideY2;

        public RoadSide()
        {
            this.k = 0;
            this.j = 0;
            this.roadSideX1 = Config.RoadSideX1;
            this.roadSideX2 = Config.RoadSideX2;
            this.roadSideY1 = Config.RoadSideY1;
            this.roadSideY2 = Config.RoadSideY2;
        }

        public void Move()
        {
            this.j = this.k++;

            for (int y = this.roadSideY2 - 1; y >= this.roadSideY1; y--)
            {
                char roadSideSymbol;

                if (this.j > 2)
                {
                    roadSideSymbol = ' ';
                    this.j = 0;
                }
                else
                {
                    roadSideSymbol = '#';
                    this.j++;
                }

                Print.Text(this.roadSideX1, y, roadSideSymbol);
                Print.Text(this.roadSideX2, y, roadSideSymbol);
            }

            if (k > 3)
                k = 0;
        }
    }
}