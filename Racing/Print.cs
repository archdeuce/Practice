using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing
{
    public static class Print
    {
        public static void DrawInterface()
        {
            //
            // Configure the console.
            //
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(Config.ConsoleWidth, Config.ConsoleHeight);
            Console.SetBufferSize(Config.ConsoleWidth, Config.ConsoleHeight);

            //
            // Drawing a vertical separator between the path and interface.
            //
            for (int y = 0; y < Config.ConsoleHeight; y++)
                Print.Text(Config.InfoPanelPositionX1, y, '|');

            //
            // Information output in info panel.
            //
            Print.Text(Config.ScoreTitlePositionX, Config.ScoreTitlePositionY, Config.ScoreTitle);
            DisplayScore(0);

            Print.Text(Config.LivesTitlePositionX, Config.LivesTitlePositionY, Config.LivesTitle);
            DisplayLives(Config.LivesNumber);

            Print.Text(Config.SpeedTitlePositionX, Config.SpeedTitlePositionY, Config.SpeedTitle);
            DisplayLevel(1);

            Print.Text(Config.PаuseTextTitle1X, Config.PаuseTextTitle1Y, Config.PаuseTextTitle1);

            Print.Text(Config.PаuseTextTitle2X, Config.PаuseTextTitle2Y, Config.PаuseTextTitle2);
        }

        //
        // Score update.
        //
        public static void DisplayScore(int score)
        {
            Print.Text(Config.ScorePositionX, Config.ScorePositionY, score);
        }

        //
        // Speed ​​update.
        //
        public static void DisplayLevel(int level)
        {
            Print.Text(Config.SpeedMeterPositionX, Config.SpeedMeterPositionY, level);
        }

        //
        // Update information on the number of lives.
        //
        public static void DisplayLives(int currentLives)
        {
            for (int i = 0; i < Config.LivesNumber; i++)
            {
                string liveIcon = string.Empty;

                if (i < currentLives)
                    liveIcon = "[+]";
                else
                    liveIcon = "[-]";

                //
                // To draw a "+" from the last position to the first.
                //
                int symbolPositionOffset = Config.LivesNumber * 3 - ((i + 1) * 3);

                Print.Text(Config.LivesBarPositionX + symbolPositionOffset, Config.LivesBarPositionY, liveIcon);
            }
        }

        //
        // The effect of a collision of cars.
        //
        public static void CollisionEffect(int x, int y)
        {
            int blinkTimeout = 150;

            for (int i = 0; i < 3; i++)
            {
                CollisionEffectFirst(x, y);
                Thread.Sleep(blinkTimeout);

                CollisionEffectSecond(x, y);
                Thread.Sleep(blinkTimeout);
            }
        }

        private static void CollisionEffectFirst(int x, int y)
        {
            lock (Game.consoleLocker)
            {
                for (int j = 0; j < 8; j += 2)
                {
                    Console.SetCursorPosition(x, y + j);
                    Console.Write(" + + +");
                    Console.SetCursorPosition(x, y + j + 1);
                    Console.Write("+ + + ");
                }
            }
        }

        private static void CollisionEffectSecond(int x, int y)
        {
            lock (Game.consoleLocker)
            {
                for (int j = 0; j < 8; j += 2)
                {
                    Console.SetCursorPosition(x, y + j);
                    Console.Write("+ + + ");
                    Console.SetCursorPosition(x, y + j + 1);
                    Console.Write(" + + +");
                }
            }
        }

        //
        // Generation of an empty string the size of the width of the road and progressive cleaning of the road.
        //
        public static void ClearRoad()
        {
            int roadWidth = Config.RoadX2 - Config.RoadX1;
            string clearRow = new string(' ', roadWidth);

            for (int y = 0; y < Config.ConsoleHeight; y++)
            {
                Print.Text(Config.RoadX1, y, clearRow);
            }
        }

        //
        // Displays a message about the end of the game.
        //
        public static void DisplayGameOverScreen()
        {
            string score = Config.GameOverTotalScoreText + Game.score.Get();

            Console.Clear();
            Print.Text(Config.GameOverX, Config.GameOverY, score);

            Thread.Sleep(3000);

            Console.Clear();

            for (int i = 0; i < Config.GameOverText.Length; i++)
            {
                Print.Text(Config.GameOverX + i, Config.GameOverY, Config.GameOverText[i]);

                Thread.Sleep(30);
            }

            Thread.Sleep(3000);
        }

        //
        // Rendering data at a specified position.
        //
        public static void Text(int x, int y, char symbol)
        {
            Print.Text(x, y, Convert.ToString(symbol));
        }

        public static void Text(int x, int y, int number)
        {
            Print.Text(x, y, Convert.ToString(number));
        }

        public static void Text(int x, int y, string str)
        {
            lock (Game.consoleLocker)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(str);
            }
        }
    }
}
