using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Mammal
    {
        protected int Weight { get; set; }

        protected int Age { get; set; }

        protected string Beast { get; set; }

        protected int FoodIndex { get; set; }

        public Mammal(int weight, int age, string beast)
        {
            this.Weight = weight;

            this.Age = age;

            this.Beast = beast;

            this.FoodIndex = 5;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(new string('*', 70) + "\n" +
                $"Animal - {this.Beast}. \n" +
                $"Type - {this.GetType().Name} \n" +
                $"Animal weight {this.Weight} kg.\n" +
                $"The age of the animal is {this.Age} full years.");
        }

        public virtual void Eat(int foodAmount)
        {
            Console.WriteLine($"The animal has eaten {foodAmount} servings of food.");

            if (this.Age < 1)
                Console.WriteLine("The animal feeds on milk.");
            else
                Console.WriteLine("The animal no longer feeds on milk.");

            this.Weight += foodAmount * this.FoodIndex;

            Console.WriteLine($"The weight of the animal after feeding is equal to {this.Weight} kg.");
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal is moving.");
        }
    }
}
