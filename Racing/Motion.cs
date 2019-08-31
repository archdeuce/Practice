using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Motion
    {
        public int Level { get; private set; }

        public int MoveTimeout { get; private set; }

        public int StepTimeout { get; private set; }

        private int[] speed = { 10, 9, 8, 7, 6, 5, 4};

        public Motion()
        {
            this.Default();
        }

        //
        // Set the level and speed.
        //
        public void LevelUp()
        {
            if (this.Level < speed.Length)
            {
                this.Level++;
                this.MoveTimeout = speed[this.Level - 1];
            }
        }

        //
        // Starting parameters of the entry level.
        //
        public void Default()
        {
            this.Level = 1;
            this.StepTimeout = 4;
            this.MoveTimeout = 21;
        }
    }
}
