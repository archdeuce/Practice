using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Node
    {
        //
        // Позиция ноды.
        //
        public int X { get; set; }
        public int Y { get; set; }

        //
        // Цвет и форма.
        //
        public char Symbol { get; set; }
        public string Color { get; set; }

        //
        // Генерация ноды.
        //
        public Node(int x, int y, char symbol, string color)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = symbol;
            this.Color = color;
        }
    }
}
