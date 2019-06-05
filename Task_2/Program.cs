using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_2.ExchangeRates();

            Console.ReadKey();
        }

        class Task_2
        {
            public static void ExchangeRates()
            {
                string[] currencies = { "UAH", "RUB", "USD", "EUR" };
                decimal[] currenciesPrice = { 1m, 0.3900m, 26.800m, 30.000m };

                Console.WriteLine("List of currencies:");

                for (int i = 0; i < currencies.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {currencies[i]} - {currenciesPrice[i]}");
                }

                Console.Write("\nSelect a currency: ");
                int selectCurrencies1 = UserInputSelect();

                Console.Write("\nEnter the amount of money: ");
                decimal sum = UserMoney();

                Console.Write("\nWhat currency we convert: ");
                int selectCurrencies2 = UserInputSelect();

                decimal result = SumResult(selectCurrencies1, selectCurrencies2, sum, currenciesPrice);

                Console.WriteLine($"\n{sum} {currencies[selectCurrencies1]} <--> {currencies[selectCurrencies2]} {result}");
            }

            public static int UserInputSelect()
            {
                int tmp;

                Int32.TryParse(Console.ReadLine(), out tmp);

                while (tmp < 0 & tmp > 4)
                {
                    Console.Write("Invalid value entered! Try again: ");
                    Int32.TryParse(Console.ReadLine(), out tmp);
                }

                return tmp - 1;
            }

            public static decimal UserMoney()
            {
                decimal tmp;

                Decimal.TryParse(Console.ReadLine(), out tmp);

                while (tmp < 0)
                {
                    Console.Write("Invalid value entered! Try again: ");
                    Decimal.TryParse(Console.ReadLine(), out tmp);
                }

                return tmp;
            }

            public static decimal SumResult(int selectCurrencies1, int selectCurrencies2, decimal sum, decimal[] currenciesPrice)
            {
                return sum * currenciesPrice[selectCurrencies1] / currenciesPrice[selectCurrencies2];
            }
        }
    }
}
