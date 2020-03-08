using System;
using System.IO;

using static System.Console;


namespace ReadWriterFilesKit
{
    class Program
    {
        private const int SUCCESS = 0;
        private const int FILE_or_DIR_DOES_NOT_EXIST = -1;


        static int Main(string[] args)
        {
            string filePath;
            string standartDirPath = @"C:\github_defteam\ReadWriterFilesKit\Files";//основная папка
            
            string dateNow = Convert.ToString(DateTime.Now);
            string[] date = dateNow.Split(' ');
            
            string dirPath = date[0];

            WriteLine("Введите путь к файлу");
            filePath = ReadLine();

            FileInfo file = new FileInfo(filePath);
            if(!file.Exists)
            {
                WriteLine("Данного файла не существует!\nХотите ли Вы повторить ввод?(Да или Нет)");

                if (ReadLine() == "Да")
                    Program.Main(null);

                return FILE_or_DIR_DOES_NOT_EXIST;
            }

            DirectoryInfo standDirInfo = new DirectoryInfo(standartDirPath);
            if (!standDirInfo.Exists)
            {
                standDirInfo.Create();
            }
            else if(!hasDirDate(dirPath, standartDirPath))
            {
                standDirInfo.CreateSubdirectory(dirPath);
            }

            file.MoveTo(standartDirPath + "\\" + dirPath + "\\" + file.Name);

            return SUCCESS;
        }
        
        static private bool hasDirDate(string dir, string standartDirPath)
        {
            string[] dirs = Directory.GetDirectories(standartDirPath);
            
            foreach(string s in dirs)
            {
                if (dir == s)
                    return true;
            }

            return false;
        }

    }
}

