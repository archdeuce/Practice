using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public abstract class Operation
    {
        protected double FirstOperand { get; set; }

        protected double SecondOperand { get; set; }

        protected string Action { get; set; }

        public Operation(double firstOperand, double secondOperand)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
        }

        public void ToString()
        {
            Console.WriteLine($"The calculation is performed using the operation {this.Action}.");

            Console.WriteLine($"FirstOperand = {FirstOperand}\nSecondOperand = {SecondOperand}");
        }

        public abstract double Calculate();
    }
}
