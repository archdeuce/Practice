using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CarCollection<T> : ICarCollection<T>
    {
        private T[] myCarCollection;

        public CarCollection()
        {
            this.myCarCollection = new T[0];
            this.Count = 0;
        }

        public CarCollection(int length)
        {
            this.myCarCollection = new T[length];
            this.Count = length;
        }

        public T this[int index]
        {
            get
            {
                return myCarCollection[index];
            }
        }

        public int Count { get; private set; }

        public void Add(T a)
        {
            Array.Resize<T>(ref this.myCarCollection, ++this.Count);
            this.myCarCollection[this.Count - 1] = a;
        }

        public void Clear()
        {
            this.myCarCollection = new T[0];
            this.Count = 0;
        }

        public bool Contains(T item)
        {
            foreach (T el in myCarCollection)
            {
                if (item.Equals(el))
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            if (Count == 0)
                return "No data.\n";

            string result = string.Empty;
            int pos = 0;

            foreach (T selectedCar in myCarCollection)
            {
                result += $"{pos}: {selectedCar.ToString()}";

                pos++;
            }

            return result;
        }
    }
}