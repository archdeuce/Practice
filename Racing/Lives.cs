using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Lives
    {
        private int livesNumber;

        public Lives(int liveCounter)
        {
            this.livesNumber = liveCounter;
        }

        public void DecreaseLive()
        {
            if (livesNumber > 0)
                this.livesNumber--;
        }

        public int GetLive()
        {
            return this.livesNumber;
        }
    }
}
