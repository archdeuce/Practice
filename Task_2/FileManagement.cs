using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class FileManagement
    {
        public void WriteData()
        {
            Directory.CreateDirectory(Config.DirPath);

            Console.WriteLine("Enter the text to write to the text file:");

            string userInput = Console.ReadLine() + '\n';

            File.AppendAllText(Config.FullPath, userInput);

            Console.WriteLine("Information successfully recorded.");
        }
    }
}