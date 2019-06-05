using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Gallery
    {
        public string Name { get; private set; }

        public Worker Employee { get; private set; }

        public Plant[] Plants { get; private set; }

        public Gallery(string name, Worker worker, Plant[] plants)
        {
            this.Name = name;
            this.Employee = worker;
            this.Plants = plants;
        }
    }
}