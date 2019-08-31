using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing
{
    public class PlayerCar
    {
        public int СarLeftPositionX { get; private set; }

        public int СarRightPositionX { get; private set; }

        public int СarPositionY1 { get; private set; }

        public int СarPositionY2 { get; private set; }

        public int CurrentPositionX { get; private set; }

        public int CarHeight { get; private set; }

        public PlayerCar()
        {
            this.CurrentPositionX = -1;
            this.СarLeftPositionX = Config.PlayerCarLeftPositionX;
            this.СarRightPositionX = Config.PlayerCarRightPositionX;
            this.СarPositionY1 = Config.PlayerCarPositionY1;
            this.СarPositionY2 = Config.PlayerCarPositionY2;
            this.CarHeight = Config.CarHeight;
        }

        public void MoveLeft()
        {
            if (this.CurrentPositionX != this.СarLeftPositionX)
            {
                this.CurrentPositionX = this.СarLeftPositionX;

                this.ClearOldCarPosition(this.СarRightPositionX, this.СarPositionY1);
                this.DrawCar(this.СarLeftPositionX, this.СarPositionY1);
            }
        }

        public void MoveRight()
        {
            if (this.CurrentPositionX != this.СarRightPositionX)
            {
                this.CurrentPositionX = this.СarRightPositionX;

                this.ClearOldCarPosition(this.СarLeftPositionX, this.СarPositionY1);
                this.DrawCar(this.СarRightPositionX, this.СarPositionY1);
            }
        }

        public void RandomStartPosition()
        {
            this.CurrentPositionX = -1;

            int r = new Random().Next(0, 2);

            if (r == 0)
                this.MoveLeft();
            else
                this.MoveRight();
        }

        private void DrawCar(int x, int y)
        {
            lock (Game.consoleLocker)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write("  /\\  ");
                Console.SetCursorPosition(x, y++);
                Console.Write("[-||-]");
                Console.SetCursorPosition(x, y++);
                Console.Write("  ||  ");
                Console.SetCursorPosition(x, y++);
                Console.Write("[-\\/-]");
            }
        }

        private void ClearOldCarPosition(int x, int y)
        {
            string carClearRow = new string(' ', Config.CarWidth);

            lock (Game.consoleLocker)
            {
                for (int i = 0; i < this.CarHeight; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(carClearRow);
                }
            }
        }
    }
}