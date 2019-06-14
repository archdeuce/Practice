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
            var car1 = new Car<DiselEngine>(new DiselEngine());
            var car2 = new Car<ElectroEngine>(new ElectroEngine());

            car1.Engine.PrintType();
            car2.Engine.PrintType();

            Console.ReadKey();
        }
    }

    public class Car<TEngine>
    {
        public TEngine Engine { get; set; }

        public Car(TEngine engine)
        {
            this.Engine = engine;
        }
    }

    public class DiselEngine : BaseEngine<object>
    {
        public void PrintType()
        {
            Console.WriteLine("Disel Engine.");
        }
    }

    public class ElectroEngine : BaseEngine<object>
    {
        public void PrintType()
        {
            Console.WriteLine("Electro Engine.");
        }
    }

    public class BaseEngine<T>
    {
        public T Id { get; set; }

        public void PrintId()
        {
            Console.WriteLine(this.Id);
        }
    }
}