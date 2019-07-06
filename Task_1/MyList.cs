using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class MyList<T> : IMyList<T>
    {
        private T[] myList;

        public MyList()
        {
            this.myList = new T[0];
            this.Count = 0;
        }

        public MyList(int length)
        {
            this.myList = new T[length];
            this.Count = length;
        }

        public T this[int index]
        {
            get
            {
                return myList[index];
            }
        }

        public int Count { get; private set; }

        public void AddEasy(T a)
        {
            Array.Resize<T>(ref this.myList, ++this.Count);
            this.myList[this.Count - 1] = a;
        }

        public void Add(T a)
        {
            //
            // It could be made easier.
            //
            //Array.Resize<T>(ref this.myList, ++this.length);

            T[] tmpList = new T[this.Count];
            Array.Copy(this.myList, tmpList, this.Count);
            this.myList = new T[++this.Count];
            Array.Copy(tmpList, this.myList, Count - 1);

            this.myList[Count - 1] = a;
        }

        public void Clear()
        {
            this.myList = new T[0];
            this.Count = 0;
        }

        public bool Contains(T item)
        {
            foreach (T el in myList)
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

            foreach (T item in myList)
            {
                result += $"{pos}: {Convert.ToString(item)}\n";

                pos++;
            }

            return result;
        }
    }
}