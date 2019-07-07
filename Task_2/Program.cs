using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarCollection<Car> myCars = new CarCollection<Car>();

            //
            // Adding information to the collection.
            //
            myCars.Add(new Car("LADA Kalina", 2000));
            myCars.Add(new Car("LADA Vesta", 2001));
            myCars.Add(new Car("LADA Priora", 2002));
            myCars.Add(new Car("DEO Lanos", 2003));
            myCars.Add(new Car("DEO Sens", 2004));

            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"myCars.Count = ({myCars.Count}):");
            Console.WriteLine(myCars.ToString());
            Console.WriteLine($"myCars[3]: {myCars[3]}\n");
            Console.WriteLine(new string('-', 60));

            //
            // Search for items in the list.
            //
            var carWanted = new Car("LADA Priora", 2020);
            Console.WriteLine($"Looking for {carWanted.Name}({carWanted.Year}) - {myCars.Contains(carWanted)}.");

            carWanted = new Car("LADA Priora", 2002);
            Console.WriteLine($"Looking for {carWanted.Name}({carWanted.Year}) - {myCars.Contains(carWanted)}.");

            carWanted = new Car("Lamborghini Gallardo", 2010);
            Console.WriteLine($"Looking for {carWanted.Name}({carWanted.Year}) - {myCars.Contains(carWanted)}.");

            //
            // Clearing content.
            //
            myCars.Clear();

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("After starting the Clear function:\n");

            Console.WriteLine($"Output elements of myCars({myCars.Count}):");
            Console.WriteLine(myCars.ToString());

            Console.ReadKey();
        }
    }
}