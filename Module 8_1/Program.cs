using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
