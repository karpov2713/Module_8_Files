using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Module_8_1
{
    class Disk
    {
        public Disk(string name, long totalSpace, long availableSpace)
        {
            Name = name;
            Size = totalSpace;
            AvailableSpace = availableSpace;
        }

        public string Name { get; }
        public long Size { get; }
        public long AvailableSpace { get; }
    }

    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // получим системные диски
            /*DriveInfo[] drives = DriveInfo.GetDrives();*/

            /*foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.AvailableFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }*/

            //GetCatalogs();

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\");

                Console.WriteLine($"Название каталога: {dirInfo.Name}");
                Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
                Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
                Console.WriteLine($"Корневой каталог: {dirInfo.Root}");

                if (dirInfo.Exists)
                {
                    Console.WriteLine($"Количество директорий = {dirInfo.GetDirectories().Length}");
                    Console.WriteLine($"Количество файлов = {dirInfo.GetFiles().Length}");
                }

                DirectoryInfo newDirectory = new DirectoryInfo("C:\\newDirectory");

                if (!newDirectory.Exists)
                {
                    newDirectory.Create();
                }

                Console.WriteLine($"Количество директорий = {dirInfo.GetDirectories().Length}");
                Console.WriteLine($"Количество файлов = {dirInfo.GetFiles().Length}");

                /*DirectoryInfo delNewDirectory = new DirectoryInfo("C:\\newDirectory");

                if (delNewDirectory.Exists)
                {
                    delNewDirectory.Delete(true);
                    Console.WriteLine("Каталог удален");
                }

                Console.WriteLine($"Количество директорий = {dirInfo.GetDirectories().Length}");
                Console.WriteLine($"Количество файлов = {dirInfo.GetFiles().Length}");*/

                // Перемещение каталога
                DirectoryInfo moveNewDirectory = new DirectoryInfo("C:\\newDirectory");
                string newPath = "C:\\moveNewDirectory";

                if (moveNewDirectory.Exists && !Directory.Exists(newPath))
                {
                    moveNewDirectory.MoveTo(newPath);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /*static void GetCatalogs()
        {
            string dirName = "C:\\"; // Прописываем путь к корневой директории
            int numberOfDirs = 0;
            int numberOfFiles = 0;

            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);
                
                // Получим все директории корневого каталоги
                foreach (string dir in dirs) // Выведем их все
                {
                    Console.WriteLine(dir);

                    numberOfDirs++;
                }

                Console.WriteLine();
                Console.WriteLine("Файлы:");

                string[] files = Directory.GetFiles(dirName);
                
                //Получим все файлы корневого каталога
                foreach(string s in files)
                {
                    Console.WriteLine(s);
                    numberOfFiles++;
                }
            }

            Console.WriteLine($"Количество директорий = {numberOfDirs}");
            Console.WriteLine($"Количество файлов = {numberOfFiles}");
        }*/
    }
}
