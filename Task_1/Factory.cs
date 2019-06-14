using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Factory
    {
        public void Execute()
        {
            Worker worker = new Worker("Ivan", "Pupkin");

            Plant[] plants = new Plant[]
            {
                        new Flower("Rose", PlantColor.green, 70, 1),
                        new Flower("Chamomile", PlantColor.white, 10, 10),
                        new Tree("Oak", PlantColor.brown, 500, 20),
                        new Tree("Pine", PlantColor.brown, 10000, 50)
            };

            Gallery ownGallery = new Gallery("Weeds", worker, plants);

            ownGallery.DoWork();
        }
    }
}