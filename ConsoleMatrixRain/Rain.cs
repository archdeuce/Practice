using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleMatrixRain
{
    public static class Rain
    {
        public static void MatrixRain(int menuChoice = 0)
        {
            int spaceBetweenColumns = 0;

            if (menuChoice == 0)
                new Matrix(0, 0).SingleChain();
            else
            {
                if (menuChoice == 1)
                    spaceBetweenColumns = Config.spaceBetweenColumns;
                else
                    spaceBetweenColumns = Config.spaceBetweenColumns * 2;

                for (int row = 0; row < Config.HPosMax; row += spaceBetweenColumns)
                {
                    //
                    // A slight pause before starting the stream to get a more random starting vertical position.
                    //
                    Thread.Sleep(10);

                    int vPosFirstChain = new Random().Next(0, 20);

                    Matrix m = new Matrix(vPosFirstChain, row);
                    Thread t = new Thread(m.SingleChain);

                    t.Start();

                    //
                    // Run the second chain in the same column with an offset, if necessary.
                    //
                    if (menuChoice == 2)
                    {
                        int vPosSecondChain = (vPosFirstChain + 15) % 30;

                        Matrix m2 = new Matrix(vPosSecondChain, row);
                        Thread t2 = new Thread(m2.SingleChain);

                        t2.Start();
                    }
                }
            }
        }
    }
}
