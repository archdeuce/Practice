using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Div : Operation
    {
        public Div(double firstOperand, double secondOperand)
            : base(firstOperand, secondOperand)
        {
            this.Action = "Division";
        }

        public override double Calculate()
        {
            return this.FirstOperand / this.SecondOperand;
        }
    }
}
