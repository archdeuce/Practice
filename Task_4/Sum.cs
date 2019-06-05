using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Sum : Operation
    {
        public Sum(double firstOperand, double secondOperand)
            : base(firstOperand, secondOperand)
        {
            this.Action = "Addition";
        }

        public override double Calculate()
        {
            return this.FirstOperand + this.SecondOperand;
        }
    }
}