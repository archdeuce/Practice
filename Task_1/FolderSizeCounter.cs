using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class FolderSizeCounter
    {
        public void Execute()
        {
            string[] filesList = Directory.GetFiles(Config.DirPath);

            int folderCount = 0;
            int fileCount = 0;

            decimal dirTotalSize = FolderCounter(Config.DirPath, ref folderCount, ref fileCount);

            Console.WriteLine(new string('-', 120));
            Console.WriteLine($"Folder \"{Config.DirPath}\" has size " + String.Format("{0:0.00}", (dirTotalSize / 1048576m)) + " MB.");
            Console.WriteLine($"Folder \"{Config.DirPath}\" сontains {folderCount} folders.");
            Console.WriteLine($"Folder \"{Config.DirPath}\" сontains {fileCount} files.");
        }

        public decimal FolderCounter(string path, ref int dirs, ref int files)
        {
            decimal folderSize = 0;

            string[] filesList = Directory.GetFiles(path);

            string[] dirList = Directory.GetDirectories(path);

            dirs += dirList.Length;
            files += filesList.Length;

            foreach (var file in filesList)
            {
                FileInfo fileInfo = new FileInfo(file);

                folderSize += fileInfo.Length;
            }

            if (dirList.Length == 0)
                return folderSize;

            foreach (string dir in dirList)
            {
                var currentDirSize = FolderCounter(dir, ref dirs, ref files);

                folderSize += currentDirSize;

                Console.WriteLine($"\"{dir}\" Size: " + String.Format("{0:0.00}", (currentDirSize / 1048576m)) + " MB.");
            }

            return folderSize;
        }
    }
}