using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();

            Console.WriteLine($"MyLinkedList isEmpty: {myLinkedList.IsEmpty}.\n");
            Console.WriteLine("Add data and display:");

            myLinkedList.Add("1");
            myLinkedList.Add("2");
            myLinkedList.Add("3");
            myLinkedList.Add("4");

            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }

            if (!myLinkedList.IsEmpty)
                Console.WriteLine($"MyLinkedList isEmpty: {myLinkedList.IsEmpty}.\nNumber of elements = {myLinkedList.Count}.");
            else
                Console.WriteLine($"MyLinkedList isEmpty: {myLinkedList.IsEmpty}.");

            myLinkedList.Remove("2");

            Console.WriteLine("\nAfter remove \"2\":");

            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAfter clear:");

            myLinkedList.Clear();

            if (!myLinkedList.IsEmpty)
                Console.WriteLine($"MyLinkedList isEmpty: {myLinkedList.IsEmpty}.\nNumber of elements = {myLinkedList.Count}.");
            else
                Console.WriteLine($"MyLinkedList isEmpty: {myLinkedList.IsEmpty}.");

            Console.ReadKey();
        }
    }
}
