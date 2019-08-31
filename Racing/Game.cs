using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing
{
    public static class Game
    {
        public static object consoleLocker = new object();

        public static Score score = new Score();
        public static Lives lives = new Lives(Config.LivesNumber);
        public static Motion motion = new Motion();

        public static RoadSide roadSide = new RoadSide();
        public static RivalCar rivalCar = new RivalCar();
        public static RivalCar rivalCar2 = new RivalCar(Config.RivalCarOffset);
        public static PlayerCar playerCar = new PlayerCar();

        public static Key key = new Key();

        public static Thread keyboardThred = new Thread(key.StartReadKey);

        public static int roadSpeedK = 0;
        public static int rivalSpeedK = 0;
        public static int carCounter = 0;
        public const int carCounterDefault = 2;
        public static int carCounterK = carCounterDefault;
        public static int MoveTimeout;
        public static bool IsPaused = false;


        //
        // Initialize all game modules.
        //
        public static void Initialization()
        {
            key.keyEvent += KeyboardHandler;

            Print.DrawInterface();

            playerCar.RandomStartPosition();
            rivalCar.RandomStartPosition();
            rivalCar2.RandomStartPosition(Config.RivalCarOffset);
            roadSide.Move();

            keyboardThred.Start();

            Game.Start();
        }

        private static void Start()
        {
            while (true)
            {
                //
                // Delay in each iteration to simulate speed.
                //
                Thread.Sleep(motion.MoveTimeout);

                //
                // Simple pause implementation.
                //
                while (IsPaused) { }

                bool IsFinishedFirst = false;
                bool IsFinishedSecond = false;

                //
                // Unsubscribing from the processing of keyboard keystrokes to avoid errors during movement at the time of collision miscalculations.
                //
                key.keyEvent -= KeyboardHandler;

                //
                // Car collision check.
                //
                if (IsCollision(playerCar, rivalCar) ||
                    IsCollision(playerCar, rivalCar2))
                {
                    Console.Beep();

                    IsFinishedFirst = false;
                    IsFinishedSecond = false;

                    lives.DecreaseLive();

                    Print.DisplayLives(lives.GetLive());
                    Print.CollisionEffect(playerCar.CurrentPositionX, playerCar.СarPositionY1 - Config.CarHeight);
                    Print.ClearRoad();

                    //
                    // If lives are greater than 0 and have not reached the limit on points, restart the game.
                    //
                    if (lives.GetLive() > 0 && score.Get() < Config.MaxScore)
                    {
                        Thread.Sleep(1);
                        playerCar.RandomStartPosition();

                        Thread.Sleep(1);
                        rivalCar.RandomStartPosition();

                        Thread.Sleep(1);
                        rivalCar2.RandomStartPosition(Config.RivalCarOffset);

                        motion.Default();

                        carCounter = 0;
                        carCounterK = carCounterDefault;

                        Print.DisplayLevel(motion.Level);
                    }
                    //
                    // Game completion 3 seconds after displaying the results.
                    //
                    else
                    {
                        Print.DisplayGameOverScreen();

                        Thread.Sleep(3000);

                        Process.GetCurrentProcess().Kill();
                    }
                }
                else
                {
                    key.keyEvent += KeyboardHandler;

                    rivalSpeedK++;
                    roadSpeedK++;

                    if (rivalSpeedK >= 5)
                    {
                        IsFinishedFirst = rivalCar.Move();

                        IsFinishedSecond = rivalCar2.Move();

                        rivalSpeedK = 0;
                    }

                    if (roadSpeedK >= 8)
                    {
                        roadSide.Move();
                        roadSpeedK = 0;
                    }

                    if (IsFinishedFirst || IsFinishedSecond)
                    {
                        int tmpScore = motion.Level * 5;
                        score.Add(tmpScore);
                        Print.DisplayScore(score.Get());

                        IsFinishedFirst = false;
                        IsFinishedSecond = false;

                        carCounter++;
                    }

                    //
                    // Switching levels after a successful overtaking of cars. The higher the level, the more cars you need to overtake to increase the level.
                    //
                    if (carCounter == carCounterK)
                    {
                        motion.LevelUp();

                        carCounter = 0;
                        carCounterK += motion.Level;

                        Print.DisplayLevel(motion.Level);
                    }
                }
            }
        }

        //
        // Compares two cars at the intersection of coordinates.
        //
        private static bool IsCollision(PlayerCar p, RivalCar r)
        {
            if (p.CurrentPositionX == r.CarPositionX)
            {
                for (int y = p.СarPositionY1; y < p.СarPositionY2; y++)
                {
                    int yNextStep = y + 1;

                    if (r.CarPositionY1 == yNextStep ||
                        r.CarPositionY2 == yNextStep)
                        return true;
                }
            }

            return false;
        }

        //
        // Pause flag management.
        //
        public static void Pause()
        {
            IsPaused = !IsPaused;
        }

        //
        // Processing keystrokes.
        //
        private static void KeyboardHandler(object sender, KeyEventArgs e)
        {
            switch (e.KeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (!IsPaused)
                        playerCar.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    if (!IsPaused)
                        playerCar.MoveRight();
                    break;
                case ConsoleKey.Spacebar:
                    Game.Pause();
                    break;
                case ConsoleKey.Escape:
                    Process.GetCurrentProcess().Kill();
                    break;
                default:
                    break;
            }
        }
    }
}
