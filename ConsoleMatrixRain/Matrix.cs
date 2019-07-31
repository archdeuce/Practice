using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleMatrixRain
{
    public class Matrix
    {
        //
        // The coordinates of the first node of the chain.
        //
        private int hPos;
        private int vPos;

        //
        // Cell for storing a pseudo-random symbol.
        //
        private static int randomSymbol;

        //
        // A locker object to prohibit simultaneous access to console functions from different threads.
        //
        private static object locker = new object();

        public Matrix()
        {
            this.vPos = 0;
            this.hPos = 0;
        }

        public Matrix(int vPos, int hPos)
        {
            this.vPos = vPos;
            this.hPos = hPos;
        }

        public void SingleChain()
        {
            this.StartupTimeout();

            int chainLength = GetRandomChainLength();
            int chainSpeed = GetRandomChainSpeed();

            this.StartupTimeout();

            //
            // Endless rendering of a vertical chain of symbols.
            //
            while (true)
            {
                Thread.Sleep(chainSpeed);

                //
                // Vertical tail position of the chain.
                //
                int tailPosition = this.vPos - chainLength;

                //
                // Draw the first node.
                //
                if (this.vPos >= 0 &&
                    this.vPos < Config.VPosMax)
                    this.DrawSymbol(this.hPos, this.vPos, Config.firstNodeColor);

                //
                // Draw the second node.
                //
                int secondNodePosition = this.vPos - 1;

                if (secondNodePosition < Config.VPosMax &&
                    secondNodePosition >= 0)
                    this.DrawSymbol(this.hPos, secondNodePosition, Config.secondNodeColor);

                //
                // Drawing the rest of the nodes.
                //
                for (int i = 2; i < chainLength; i++)
                {
                    int currentNode = vPos - i;

                    if (currentNode < Config.VPosMax && currentNode >= 0)
                        this.DrawSymbol(this.hPos, currentNode, Config.otherNodeColor);
                }

                //
                // Clear unnecessary positions behind the string of symbols in the console at each offset.
                //
                if (tailPosition >= 0 && tailPosition < Config.VPosMax)
                    this.DrawSymbol(this.hPos, tailPosition, "null", ' ');

                //
                // Change the coordinates of the vertical position of the first symbol of the chain.
                //
                this.vPos++;

                //
                // After a full cycle of symbols passing through the column, we change the length of the chain and the speed of movement of the chain of symbols.
                //
                if (tailPosition >= Config.VPosMax)
                {
                    chainLength = GetRandomChainLength();
                    chainSpeed = GetRandomChainSpeed();
                    this.vPos = 0;

                    continue;
                }
            }
        }

        //
        // Draw characters by the set color and position.
        //
        public void DrawSymbol(int hPos, int vPos, string color, char symbol = (char)0)
        {
            //
            // Block access to the console until we draw the current chain completely.
            //
            lock (locker)
            {
                switch (color)
                {
                    case "white":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "lightgreen":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "darkgreen":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                }

                Console.SetCursorPosition(hPos, vPos);

                if (symbol == ' ')
                    Console.Write(' ');
                else
                    Console.Write(GetRandomSymbol());
            }
        }

        //
        // Generate a pseudo-random symbol.
        //
        public static char GetRandomSymbol()
        {
            while (true)
            {
                if (randomSymbol <= Config.startSymbolRange || randomSymbol >= Config.endSymbolRange)
                    randomSymbol = Config.startSymbolRange;

                return (char)randomSymbol++;
            }
        }

        //
        // Generate a random string length.
        //
        public int GetRandomChainLength()
        {
            return new Random().Next(Config.MinChainLength, Config.MaxChainLength);
        }

        //
        // Generation of random speed of movement of a string of characters.
        //
        public int GetRandomChainSpeed()
        {
            return new Random().Next(Config.MinSpeed, Config.MaxSpeed);
        }

        //
        // Generate a random delay before starting the movement of a string of characters.
        //
        public void StartupTimeout()
        {
            Thread.Sleep(new Random().Next(Config.MinTimeout, Config.MaxTimeout));
        }
    }
}
