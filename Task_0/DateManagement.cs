using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0
{
    public class DateManagement
    {
        public void Execute()
        {
            DateTime today = DateTime.Today;

            Console.WriteLine($"Today: {today.Month}.{today.Day}.{today.Year}");

            Console.WriteLine("-1 day: " + DateTime.Today.AddDays(-1));

            Console.WriteLine("-2 mounths: " + DateTime.Today.AddMonths(-2));

            Console.WriteLine("-1 year: " + DateTime.Today.AddYears(-1));

            Console.WriteLine("my bd: " + new DateTime(1989, 04, 21, 16, 20, 00));
        }
    }
}