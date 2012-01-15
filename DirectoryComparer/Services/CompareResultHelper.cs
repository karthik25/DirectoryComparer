using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirectoryComparer.Objects;

namespace DirectoryComparer.Services
{
    public static class CompareResultHelper
    {
        public static string GetFileOrFolderName(this CompareResult item)
        {
            if (item.FileName != string.Empty)
                return item.FileName;

            string folderPath = item.LeftFilePath != string.Empty ? item.LeftFilePath : item.RightFilePath;
            return folderPath.GetCurrentDir();
        }
    }
}
