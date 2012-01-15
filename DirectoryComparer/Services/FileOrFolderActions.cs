using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DirectoryComparer.Services
{
    public static class FileOrFolderActions
    {
        public static void OpenFile(string fileName)
        {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            Process process = new Process();
            process.StartInfo.FileName = windir + @"\\notepad.exe";
            process.StartInfo.Arguments = fileName;
            process.Start();
        }

        public static void OpenFolder(string folderName)
        {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            Process process = new Process();
            process.StartInfo.FileName = windir + @"\\explorer.exe";
            process.StartInfo.Arguments = folderName;
            process.Start();
        }
    }
}
