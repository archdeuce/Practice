using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Mammal
    {
        public int Weight { get; private set; }

        public int Age { get; private set; }

        public string Beast { get; private set; }

        public int eatCounter { get; private set; }

        public Mammal(int weight, int age, string beast)
        {
            this.Weight = weight;
            this.Age = age;
            this.Beast = beast;
        }

        public void Eat(int foodAmount)
        {
            Console.WriteLine($"\n" +
                $"Animal - {this.Beast}. \n" +
                $"Animal weight {this.Weight} kg.\n" +
                $"The age of the animal is {this.Age} full years. \n" +
                $"The animal has eaten {foodAmount} servings of food.");

            if (this.Age < 1)
                Console.WriteLine("The animal feeds on milk.");
            else
                Console.WriteLine("The animal no longer feeds on milk.");

            this.eatCounter += foodAmount;

            this.Weight += this.eatCounter / 5;

            this.eatCounter = this.eatCounter % 5;

            Console.WriteLine($"The weight of the animal after feeding is equal to {this.Weight} kg.");
        }
    }
}
