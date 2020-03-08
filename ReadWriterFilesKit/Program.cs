using System;
using System.IO;

using static System.Console;


namespace ReadWriterFilesKit
{
    class Program
    {
        static void Main(string[] args)
        {
            const string standartDirPath = @"C:\github_defteam\ReadWriterFilesKit\Files";//основная папка
            string filePath;
            
            string dateNow = (DateTime.Now).ToString();
            string[] date = dateNow.Split(' ');
            
            string dirPath = date[0];

            WriteLine("Введите путь к файлу");
            filePath = ReadLine();

            FileInfo file = new FileInfo(filePath);
            if(!file.Exists)
            {
                WriteLine("Данного файла не существует!\nХотите ли Вы повторить ввод?(Да или Нет)");
                if (ReadLine().ToLower() == "да")
                    Program.Main(null);
            }
            else
            {
                DirectoryInfo standDirInfo = new DirectoryInfo(standartDirPath);
                if (!standDirInfo.Exists)
                {
                    standDirInfo.Create();
                }
                else if(!HasDirDate(dirPath, standartDirPath))
                {
                    standDirInfo.CreateSubdirectory(dirPath);
                }

                file.MoveTo(standartDirPath + "\\" + dirPath + "\\" + file.Name);
            }
        }
        
        static private bool HasDirDate(string dir, string standartDirPath)
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

