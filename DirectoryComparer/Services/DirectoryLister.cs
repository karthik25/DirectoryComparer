using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DirectoryComparer.Services
{
    public class DirectoryLister
    {
        public static List<string> GetAllFiles(string rootFolder, bool isRecursive)
        {
            if (!Directory.Exists(rootFolder))
            {
                throw new Exception("Root folder does not exist");
            }

            SearchOption option = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            string[] files = Directory.GetFiles(rootFolder, "*.*", option);

            return files.ToList();
        }

        public static List<string> GetAllFiles(string rootFolder)
        {
            if (!Directory.Exists(rootFolder))
            {
                throw new Exception("Root folder does not exist");
            }

            string[] filesAndFolders = Directory.GetFiles(rootFolder, "*.*", SearchOption.TopDirectoryOnly);
            filesAndFolders = filesAndFolders.Concat(Directory.GetDirectories(rootFolder)).ToArray();

            return filesAndFolders.ToList();
        }

        public static List<string> GetJPGImages(string rootFolder)
        {
            if (!Directory.Exists(rootFolder))
            {
                throw new Exception("Root folder does not exist");
            }

            var jpg = Directory.GetFiles(rootFolder, "*.jpg", SearchOption.AllDirectories);

            return jpg.ToList();
        }

        public static List<string> GetRawCanonImages(string rootFolder)
        {
            if (!Directory.Exists(rootFolder))
            {
                throw new Exception("Root folder does not exist");
            }

            var rowCanon = Directory.GetFiles(rootFolder, "*.CR2", SearchOption.AllDirectories);

            return rowCanon.ToList();
        }

        public static List<string> GetRawNilonImages(string rootFolder)
        {
            if (!Directory.Exists(rootFolder))
            {
                throw new Exception("Root folder does not exist");
            }

            var rowNikon = Directory.GetFiles(rootFolder, "*.NEF", SearchOption.AllDirectories);

            return rowNikon.ToList();
        }
    }
}
