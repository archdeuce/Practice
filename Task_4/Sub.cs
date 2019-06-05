using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Sub : Operation
    {
        public Sub(double firstOperand, double secondOperand)
            : base(firstOperand, secondOperand)
        {
            this.Action = "Subtraction";
        }

        public override double Calculate()
        {
            return this.FirstOperand - this.SecondOperand;
        }
    }
}