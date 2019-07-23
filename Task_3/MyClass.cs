using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class MyClass : IDisposable
    {
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //
                    // Dispose managed resources.
                    //
                    //Console.Beep();
                }
            }

            //
            // Dispose unmanaged resources.
            //
            //Console.Beep();

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~MyClass()
        {
            //Console.Beep();

            Dispose(false);
        }
    }
}