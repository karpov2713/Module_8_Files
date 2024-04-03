using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Module_8_1
{
    class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            AvailableSpace = freeSpace;
        }

        public string Name { get; }
        public long TotalSpace { get; }
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
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название:\t {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");

                if(drive.IsReady)
                {
                    Console.WriteLine($"Объем диска:\t {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство:\t {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка диска:\t {drive.VolumeLabel}");
                    Console.WriteLine($"Тип разметки:\t {drive.DriveFormat}");
                }
                Console.WriteLine();
            }
        }
    }
}
