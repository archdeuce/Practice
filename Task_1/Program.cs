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
            Vehicle[] vehicles = new Vehicle[]
        {
        new Car { Fuel = 100, LicensePlate = "111" },
            new Bike { Fuel = 200, LicensePlate = "222" },
                new Car { Fuel = 50, LicensePlate = "333" }
        };

            foreach (var item in vehicles)
            {
                item.Move(1000);
            }

            foreach (var item in vehicles)
            {
                Console.WriteLine("Type: " + item.GetType().Name);
                Console.WriteLine(item.Fuel);
                Console.WriteLine(item.LicensePlate);
            }

            Console.ReadKey();
        }
    }

    public abstract class Vehicle
    {
        protected string licensePlate;

        public abstract string LicensePlate { get; set; }

        public int Fuel { get; set; }

        public abstract void Move(int meters);

        public virtual void AddFuel(int count)
        {
            this.Fuel += count;
        }
    }

    public class Car : Vehicle
    {
        public override string LicensePlate
        {
            get
            {
                return this.licensePlate;
            }
            set
            {
                this.licensePlate = value + "car";
            }
        }

        public override void Move(int meters)
        {
            Console.WriteLine($"Car is moving for {meters}");
        }
    }

    public class Bike : Vehicle
    {
        public override string LicensePlate
        {
            get
            {
                return this.licensePlate;
            }
            set
            {
                this.licensePlate = value + "bike";
            }
        }

        public override void Move(int meters)
        {
            Console.WriteLine($"Bike is moving for {meters}");
        }
    }
}
