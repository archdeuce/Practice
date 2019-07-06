using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Testing logic on type Integer.
            //
            IMyList<int> myNumberList = new MyList<int>();

            myNumberList.Add(0);
            myNumberList.Add(1);
            myNumberList.Add(2);
            myNumberList.Add(3);
            myNumberList.Add(5);
            myNumberList.Add(6);

            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"myNumberList.Count({myNumberList.Count}):");
            Console.WriteLine(myNumberList.ToString());
            Console.WriteLine($"myNumberList[3]: {myNumberList[3]}\n");

            //
            // Testing logic on type String.
            //
            IMyList<string> myStringList = new MyList<string>();

            myStringList.Add("Zero");
            myStringList.Add("One");
            myStringList.Add("Two");
            myStringList.Add("Three");
            myStringList.Add("Four");

            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"myStringList.Count({myStringList.Count}):");
            Console.WriteLine(myStringList.ToString());
            Console.WriteLine($"myStringList[0]: {myStringList[0]}\n");

            //
            // Search for items in the list.
            //
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"Looking for a number 5 - {myNumberList.Contains(5)}.");
            Console.WriteLine($"Looking for a number 10 - {myNumberList.Contains(10)}.");
            Console.WriteLine();
            Console.WriteLine($"Looking for a string Zero - {myStringList.Contains("Zero")}.");
            Console.WriteLine($"Looking for a string Ten - {myStringList.Contains("Ten")}.");
            //
            // Clearing content.
            //
            myNumberList.Clear();
            myStringList.Clear();

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("After starting the Clear function:\n");

            Console.WriteLine($"Output elements of myNumberList({myNumberList.Count}):");
            Console.WriteLine(myNumberList.ToString());

            Console.WriteLine($"Output elements of myStringList({myStringList.Count}):");
            Console.WriteLine(myStringList.ToString());

            Console.ReadKey();
        }
    }
}