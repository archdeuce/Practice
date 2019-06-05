using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance();

            Console.Read();
        }
    }

    class Singleton
    {
        private static Singleton instance;

        public int someField;

        public void DoSome()
        {
        }

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }
}
