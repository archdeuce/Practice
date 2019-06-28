using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Calculator
    {
        public double Sum(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

        public double Sub(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }

        public double Mul(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

        public double Div(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }

    public class Helper
    {
        public void Execute(Func<double, double, double> action)
        {
            double firstArgument = 10;
            double secondArgument = 20;

            var calculationResult = action.Invoke(firstArgument, secondArgument);

            Console.WriteLine(calculationResult);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Helper();
            var calculator = new Calculator();

            //
            // Invoke Sum.
            //
            helper.Execute(calculator.Sum);

            //
            // Invoke Sub.
            //
            helper.Execute(calculator.Sub);

            //
            // Invoke Mul.
            //
            helper.Execute(calculator.Mul);

            //
            // Invoke Div.
            //
            helper.Execute(calculator.Div);

            Console.ReadKey();
        }
    }
}
