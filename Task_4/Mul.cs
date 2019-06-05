using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Mul : Operation
    {
        public Mul(double firstOperand, double secondOperand)
            : base(firstOperand, secondOperand)
        {
            this.Action = "Multiply";
        }

        public override double Calculate()
        {
            return this.FirstOperand * this.SecondOperand;
        }
    }
}