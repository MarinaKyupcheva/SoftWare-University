using System;
using System.IO.Compression;

namespace _06ZipAndExtract
{
    class ZipAndExtract
    {
        static void Main(string[] args)
        {
            string startPath = @"D:\\File";
            string zipPath = @"D:\\result\\result.zip";
            string extractPath = @"D:\\extract";

            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
