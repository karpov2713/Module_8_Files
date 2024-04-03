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
            
        }
    }
}
