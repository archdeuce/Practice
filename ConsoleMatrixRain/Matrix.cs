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
        // Current vertical position of the tail and second node.
        //
        private int tailPosition;
        private int secondNodePosition;

        //
        // Dimensions and speed of the chain of symbols.
        //
        private int chainLength;
        private int chainSpeed;

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

            this.chainLength = this.GetRandomChainLength();
            this.chainSpeed = this.GetRandomChainSpeed();

            //
            // Endless rendering of a vertical chain of symbols.
            //
            while (true)
            {
                Thread.Sleep(chainSpeed);

                //
                // Tail position.
                //
                this.tailPosition = this.vPos - this.chainLength;

                //
                // Draw the first node.
                //
                if (this.vPos >= 0 &&
                    this.vPos < Config.VPosMax)
                    this.DrawSymbol(this.hPos, this.vPos, Config.FirstNodeColor);

                //
                // Draw the second node.
                //
                this.secondNodePosition = this.vPos - 1;

                if (this.secondNodePosition >= 0 &&
                    this.secondNodePosition < Config.VPosMax)
                    this.DrawSymbol(this.hPos, this.secondNodePosition, Config.SecondNodeColor);

                //
                // Drawing the rest of the nodes.
                //
                for (int i = 2; i < this.chainLength; i++)
                {
                    int currentNode = vPos - i;

                    if (currentNode >= 0 &&
                        currentNode < Config.VPosMax)
                        this.DrawSymbol(this.hPos, currentNode, Config.OtherNodeColor);
                    else
                        break;

                }

                //
                // Clear unnecessary positions behind the string of symbols in the console at each offset.
                //
                if (this.tailPosition >= 0 &&
                    this.tailPosition < Config.VPosMax)
                    this.DrawSymbol(this.hPos, tailPosition, "null", ' ');

                //
                // Change the coordinates of the vertical position of the first symbol of the chain.
                //
                this.vPos++;

                //
                // After a full cycle of symbols passing through the column, we change the length of the chain and the speed of movement of the chain of symbols.
                //
                if (this.tailPosition >= Config.VPosMax)
                {
                    this.chainLength = this.GetRandomChainLength();
                    this.chainSpeed = this.GetRandomChainSpeed();
                    this.vPos = 0;
                }
            }
        }

        //
        // Draw characters by the set color and position.
        //
        private void DrawSymbol(int x, int y, string color, char symbol = (char)0)
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

                Console.SetCursorPosition(x, y);

                if (symbol == ' ')
                    Console.Write(' ');
                else
                    Console.Write(this.GetRandomSymbol());
            }
        }

        //
        // Generate a pseudo-random symbol.
        //
        private char GetRandomSymbol()
        {
            while (true)
            {
                if (randomSymbol <= Config.StartSymbolRange ||
                    randomSymbol >= Config.EndSymbolRange)
                    randomSymbol = Config.StartSymbolRange;

                return (char)randomSymbol++;
            }
        }

        //
        // Generate a random string length.
        //
        private int GetRandomChainLength()
        {
            return new Random().Next(Config.MinChainLength, Config.MaxChainLength);
        }

        //
        // Generation of random speed of movement of a string of characters.
        //
        private int GetRandomChainSpeed()
        {
            return new Random().Next(Config.MinSpeed, Config.MaxSpeed);
        }

        //
        // Generate a random delay before starting the movement of a string of characters.
        //
        private void StartupTimeout()
        {
            Thread.Sleep(new Random().Next(Config.MinTimeout, Config.MaxTimeout));
        }
    }
}
