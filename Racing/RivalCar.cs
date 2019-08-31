using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing
{
    public class RivalCar
    {
        public int CarPositionX { get; private set; }

        public int СarLeftPositionX { get; private set; }

        public int СarRightPositionX { get; private set; }

        public int CarPositionY1 { get; private set; }

        public int CarPositionY2 { get; private set; }

        public int CarHeight { get; private set; }

        public int RoadLength { get; private set; }

        public int OffsetY { get; private set; }

        public RivalCar(int offsetY = 0)
        {
            this.OffsetY= offsetY;
            this.CarPositionY1 = Config.RivalCarStartPositionY1 - offsetY;
            this.CarPositionY2 = Config.RivalCarStartPositionY2 - offsetY;
            this.СarLeftPositionX = Config.RivalCarLeftPositionX;
            this.СarRightPositionX = Config.RivalCarRightPositionX;
            this.CarPositionX = Config.RivalCarLeftPositionX;
            this.CarHeight = Config.CarHeight;
            this.RoadLength = Config.RoadY2;
        }

        private void LeftPosition(int offsetY)
        {
            this.CarPositionX = Config.RivalCarLeftPositionX;
            this.CarPositionY1 = Config.RivalCarStartPositionY1 - offsetY;
            this.CarPositionY2 = Config.RivalCarStartPositionY2 - offsetY;
        }

        private void RightPosition(int offsetY)
        {
            this.CarPositionX = Config.RivalCarRightPositionX;
            this.CarPositionY1 = Config.RivalCarStartPositionY1 - offsetY;
            this.CarPositionY2 = Config.RivalCarStartPositionY2 - offsetY;
        }

        private void DrawCar(int x, int y)
        {
            lock (Game.consoleLocker)
            {
                if (y >= 0 && y < 30)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("[-/\\-]");
                }

                y++;

                if (y >= 0 && y < 30)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ||  ");
                }

                y++;

                if (y >= 0 && y < 30)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("[-||-]");
                }

                y++;

                if (y >= 0 && y < 30)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("  \\/  ");
                }
            }
        }

        public bool Move()
        {
            bool IsFinished = false;

            this.ClearOldCarPosition();

            this.DrawCar(this.CarPositionX, this.CarPositionY1);

            this.CarPositionY1++;
            this.CarPositionY2++;

            if (this.CarPositionY1 > Config.ConsoleHeight)
            {
                IsFinished = true;
                this.RandomStartPosition();
            }

            return IsFinished;
        }

        public void RandomStartPosition(int offsetY = 0)
        {
            int r = new Random().Next(0, 2);

            if (r == 0)
                this.LeftPosition(offsetY);
            else
                this.RightPosition(offsetY);
        }

        private void ClearOldCarPosition()
        {
            string carClearRow = new string(' ', Config.CarWidth);

            lock (Game.consoleLocker)
            {
                for (int i = 0; i < this.CarHeight; i++)
                {
                    int y = this.CarPositionY1 + i - 1;

                    if (y >= 0 && y < 30)
                    {
                        Console.SetCursorPosition(this.CarPositionX, y);
                        Console.Write(carClearRow);
                    }
                }
            }
        }
    }
}
