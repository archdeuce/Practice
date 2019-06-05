using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Driver : Worker
    {
        public int Experience { get; set; }

        public DrivingCategory DriverCategory { get; set; }

        public Driver(string name, int age, int salary, int experience, DrivingCategory drivingCategory)
                : base(name, age, salary)
        {
            Experience = experience;

            DriverCategory = drivingCategory;
        }
    }
}

public enum DrivingCategory
{
    A = 0,
    B = 1,
    C = 2
}
