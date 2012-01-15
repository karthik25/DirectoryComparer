using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DirectoryComparer.Services
{
    public static class Extensions
    {
        public static bool IsDirectory(this string fileOrFolder)
        {
            return File.GetAttributes(fileOrFolder) == FileAttributes.Directory;
        }

        public static bool IsFile(this string fileOrFolder)
        {
            return !IsDirectory(fileOrFolder);
        }

        public static string GetFileName(this string filePath)
        {
            return Path.GetFileName(filePath);
        }

        public static string GetFileExtension(this string filePath)
        {
            return Path.GetExtension(filePath);
        }

        public static string GetDirPath(this string filePath)
        {
            return Path.GetDirectoryName(filePath);
        }

        public static string GetCurrentDir(this string dirPath)
        {
            return dirPath.Split('\\').Last();
        }
    }
}
