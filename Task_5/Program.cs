using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] arrAnimal = new Animal[]
            {
                  new Dog { Name = "Шарик" },
                  new Cat { Name = "Кусака" },
                  new Cat { Name = "Ленивец" },
                  new Lynx { Name = "Леснушка"},
                  new Dog { Name = "Джек" },
                  new Cat { Name = "Черныш"},
                  new Dog { Name = "Арчи"},
                  new Lynx { Name = "Рыська"}
            };

            foreach (Animal item in arrAnimal)
            {
                item.Bite();

                //
                // First option.
                //
                // if (item is IPurr newItem)
                //    newItem.Purr();

                //
                // Second option.
                //
                // if (item is Cat)
                //    ((Cat)item).Purr();

                // if (item is Lynx)
                //    ((Lynx)item).Purr();

                //
                // Third option.
                //
                // if (item as Cat != null)
                //    ((Cat)item).Purr();

                // if (item as Lynx != null)
                //    ((Lynx)item).Purr();

                //
                // Fifth option.
                //
                try
                {
                    Cat newCat = (Cat)item;
                    newCat.Purr();
                }
                catch (InvalidCastException) { }

                try
                {
                    Lynx newLynx = (Lynx)item;
                    newLynx.Purr();
                }
                catch (InvalidCastException) { }
            }

            Console.ReadKey();
        }
    }
}
