using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> files = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");
            FileInfo[] fileInfo = directoryInfo.GetFiles();

            foreach (var file in fileInfo)
            {
                if (!files.ContainsKey(file.Extension))
                {
                    files.Add(file.Extension, new Dictionary<string, double>());
                }

                files[file.Extension].Add(file.Name, file.Length / 1000.00);
            }

            using (StreamWriter writer = new StreamWriter
                 (@$"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\DirectoryTraversal.txt"))
            {

                foreach (var item in files.OrderByDescending(x => x.Value.Count()).ThenBy(k => k.Key))
                {
                    writer.WriteLine(item.Key);

                    foreach (var file in item.Value.OrderBy(v => v.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}");
                    }
                }

            }




        }
    }
}
