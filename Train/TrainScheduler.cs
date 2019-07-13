using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class TrainScheduler
    {
        private const int TrainsMaxNumber = 1;

        private Train[] trainList;

        public TrainScheduler()
        {
            this.trainList = new Train[TrainScheduler.TrainsMaxNumber];
        }

        public void Exectute()
        {
            for (int i = 0; i < TrainScheduler.TrainsMaxNumber; i++)
            {
                this.trainList[i] = this.GetNewTrain();
            }

            int selectedTrainNumber = this.AskTrainNumber();

            this.DisplayTrainInfo(selectedTrainNumber);
        }

        private int AskTrainNumber()
        {
            int number;

            while (true)
            {
                Console.WriteLine("Please enter a train number");

                if (int.TryParse(Console.ReadLine(), out number))
                    break;
            }

            return number;
        }

        private void DisplayTrainInfo(int trainNumber)
        {
            Train selectedTrain = new Train();

            for (int i = 0; i < TrainScheduler.TrainsMaxNumber; i++)
            {
                if (this.trainList[i].GetTrainNumber() == trainNumber)
                    selectedTrain = this.trainList[i];
            }

            if (selectedTrain.GetTrainNumber() == 0)
            {
                Console.WriteLine($"Train number {trainNumber} was not found in a list of trains.");
                return;
            }

            Console.WriteLine($"Train {trainNumber} is departuring to {selectedTrain.GetDestination()} at {selectedTrain.GetDepartureTime()}");
        }

        /// <summary>
        /// Gets a new instance of <see cref="Train"/>
        /// </summary>
        /// <owner>Reshetilo Oleg</owner>
        /// <returns>A new instance of <see cref="Train"/></returns>
        /// <remarks>The data for new instance is obtained from user.</remarks>
        private Train GetNewTrain()
        {
            int number = 0;

            while (true)
            {
                Console.WriteLine("Enter the number of a train");

                if (Int32.TryParse(Console.ReadLine(), out number))
                    break;
            }

            DateTime departureTime;

            while (true)
            {
                Console.WriteLine("Enter the departure time of a train");

                if (DateTime.TryParse(Console.ReadLine(), out departureTime))
                    break;
            }

            string destination = string.Empty;

            while (true)
            {
                Console.WriteLine("Enter the destination of a train");

                destination = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(destination))
                    break;
            }

            return new Train(number, destination, departureTime);
        }
    }
}
