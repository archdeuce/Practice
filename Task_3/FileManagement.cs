using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class FileManagement
    {
        public void ReadData()
        {
            string bufferAll = File.ReadAllText(Config.FullPath);
            string[] bufferWorlds = bufferAll.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] bufferLines = File.ReadAllLines(Config.FullPath);

            Console.WriteLine(bufferAll);

            int symbolCount = bufferAll.Length;
            int rowCount = bufferLines.Length;
            int wordCount = bufferWorlds.Length;

            Console.WriteLine($"\n" +
                $"symbolCount = {symbolCount}\n" +
                $"rowCount = {rowCount}\n" +
                $"wordCount = {wordCount}\n");
        }
    }
}