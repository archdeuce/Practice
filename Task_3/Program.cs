using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_3.Credit();

            Console.ReadKey();
        }

        public class Task_3
        {
            public static void Credit()
            {
                decimal debt = 700;
                decimal minAmountOfPayment = 100;
                decimal amountOfPayment = 0;

                LoanInformation(amountOfPayment, ref debt, minAmountOfPayment);

                while (debt > 0)
                {
                    amountOfPayment = DepositingMoney(minAmountOfPayment);
                    LoanInformation(amountOfPayment, ref debt, minAmountOfPayment);
                }
            }

            public static decimal DepositingMoney(decimal minAmountOfPayment)
            {
                decimal amountOfPayment;

                while (true)
                {
                    Console.WriteLine($"{System.Environment.NewLine}Amount of money?");

                    if (Decimal.TryParse(Console.ReadLine(), out amountOfPayment) && (amountOfPayment >= minAmountOfPayment))
                        return amountOfPayment;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{System.Environment.NewLine}You entered incorrect data or the amount is less than the minimum! Try again.");
                    }
                }
            }

            public static void LoanInformation(decimal amountOfPayment, ref decimal debt, decimal minAmountOfPayment)
            {
                debt -= amountOfPayment;

                if (debt > 0)
                    Console.WriteLine($"{System.Environment.NewLine}Amount of debt {debt} uah.");
                Console.WriteLine($"{System.Environment.NewLine}Minimum amount of payment {minAmountOfPayment} uah.");

                if (debt < 0)
                {
                    Console.WriteLine($"{System.Environment.NewLine}Overpayment amount {-(debt)} uah.");
                    Console.WriteLine($"{System.Environment.NewLine}Long repaid uah.");
                }
            }
        }
    }
}
