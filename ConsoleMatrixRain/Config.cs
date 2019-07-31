using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatrixRain
{
    public static class Config
    {
        //
        // Size of the console. Indicated in symbols.
        //
        public const int HPosMax = 120;
        public const int VPosMax = 30;

        //
        // Set the colors of the nodes.
        //
        public const string firstNodeColor = "white";
        public const string secondNodeColor = "lightgreen";
        public const string otherNodeColor = "darkgreen";

        //
        // Chain size range. Indicated in symbols.
        // The minimum length of the chain is 3 symbols (use 3 colors).
        // The maximum length of the chain is not limited.
        // The recommended maximum length should not exceed the size of the vertical size of the console.
        //
        public const int MinChainLength = 3;
        public const int MaxChainLength = 7;

        //
        // Speed ​​range. Specified in milliseconds.
        //
        public const int MinSpeed = 50;
        public const int MaxSpeed = 150;

        //
        // Range to set the delay. Specified in milliseconds.
        //
        public const int MinTimeout = 50;
        public const int MaxTimeout = 500;

        //
        // Range of random symbols.
        // Letters and symbols [33 - 128].
        // Large letters [65 - 91].
        //
        public const int startSymbolRange = 33;
        public const int endSymbolRange = 128;

        //
        // Spacing between columns. Indicated in symbols.
        //
        public const int spaceBetweenColumns = 3;
    }
}
