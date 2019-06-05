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
            Task_1.Calculate();

            Console.ReadKey();
        }
    }

    class Task_1
    {
        public static void Calculate()
        {
            double firstOperand = UserOperandInput();
            double secondOperand = UserOperandInput();
            char operationSign = UserSignInput();

            double result = 0;
            bool isDivByZero = false;

            switch (operationSign)
            {
                case '+':
                    result = Add(firstOperand, secondOperand);
                    break;
                case '-':
                    result = Sub(firstOperand, secondOperand);
                    break;
                case '*':
                    result = Mul(firstOperand, secondOperand);
                    break;
                case '/':
                    if (secondOperand != 0)
                    {
                        result = Div(firstOperand, secondOperand);
                    }
                    else
                    {
                        isDivByZero = true;
                        Console.WriteLine("Division by zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid value entered!");
                    break;
            }

            if (isDivByZero == false)
            {
                Console.WriteLine($"result = {result}");
            }
        }

        public static double UserOperandInput()
        {
            Console.Write("Enter operand: ");

            int tmp;

            while (!Int32.TryParse(Console.ReadLine(), out tmp))
            {
                Console.Write("Invalid value entered! Try again: ");
            }

            return tmp;
        }

        public static char UserSignInput()
        {
            Console.Write("Enter operation sign: ");

            char tmp;

            Char.TryParse(Console.ReadLine(), out tmp);

            while (tmp != '+' && tmp != '-' && tmp != '*' && tmp != '/')
            {
                Console.Write("Invalid value entered! Try again: ");
                Char.TryParse(Console.ReadLine(), out tmp);
            }

            return tmp;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static double Mul(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
