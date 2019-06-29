using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Worker
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Worker(string name, string surname)
        {
            this.Name = name;

            this.Surname = surname;
        }
    }
}