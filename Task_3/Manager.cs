using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Manager
    {
        public static void FirstClearMethod(MyClass obj)
        {
            StreamReader myFile = null;
            string myText = string.Empty;

            try
            {
                myFile = new StreamReader("C:\\Share\\LastLoggedOnUser.reg");
                myText = myFile.ReadToEnd();
            }
            finally
            {
                if (myFile != null)
                    myFile.Dispose();
            }
        }

        public static void SecondClearMethod(MyClass obj)
        {
            obj.Dispose();
        }
    }
}