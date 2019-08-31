using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Score
    {
        private int totalScore;

        public Score()
        {
            this.totalScore = 0;
        }

        public void Add(int score)
        {
            if (score > 0)
                this.totalScore += score;
        }

        public int Get()
        {
            return this.totalScore;
        }
    }
}
