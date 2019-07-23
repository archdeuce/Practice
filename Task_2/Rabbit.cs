using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Rabbit
    {
        public event HuntingDelegate EventRabbit;

        private int PositionX { get; set; }

        private int PositionY { get; set; }

        Random rand = new Random();

        protected virtual void OnMove(object sender, HuntingEventArgs e)
        {
            if (EventRabbit != null)
                this.EventRabbit?.Invoke(this, e);
        }

        public void Move()
        {
            Console.WriteLine($"{this.GetType().Name}: Now position ({this.PositionX}.{this.PositionY}). Move to new random position.\n");

            this.PositionX = rand.Next(10);
            this.PositionY = rand.Next(10);

            System.Threading.Thread.Sleep(2000);

            this.OnMove(this, new HuntingEventArgs(this.PositionX, this.PositionY));
        }
    }
}