using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirectoryComparer.Objects;
using System.IO;

namespace DirectoryComparer.Services
{
    public class CompareResultExporter
    {
        public static void ExportAsXml(List<CompareResult> src, string path)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("<Files>");
            foreach (CompareResult result in src)
            {
                writer.WriteLine(result.ToXml());
            }
            writer.WriteLine("</Files>");
            writer.Close();
        }

        public static void ExportAsCsv(List<CompareResult> src, string path)
        {
            StreamWriter writer = new StreamWriter(path);
            foreach (CompareResult result in src)
            {
                writer.WriteLine(result.ToCsv());
            }
            writer.Close();
        }
    }

    public static class CompareResultExtensions
    {
        public static string ToXml(this CompareResult compareResult)
        {
            string description = @"<File>
                                    <FileName>{0}</FileName>
                                    <LeftFilePath>{1}</LeftFilePath>
                                    <RightFilePath>{2}</RightFilePath>
                                    <Match>{3}</Match>
                                    <LeftFileCreatedDate>{4}</LeftFileCreatedDate>
                                    <RightFileCreatedDate>{5}</RightFileCreatedDate>
                                    <LeftFileModifiedDate>{6}</LeftFileModifiedDate>
                                    <RightFileModifiedDate>{7}</RightFileModifiedDate>
                                   </File>";
            return string.Format(description, compareResult.GetFileOrFolderName(),
                                              compareResult.LeftFilePath,
                                              compareResult.RightFilePath,
                                              compareResult.Match,
                                              GetDate(compareResult.LeftCreatedDate),
                                              GetDate(compareResult.RightCreatedDate),
                                              GetDate(compareResult.LeftModifiedDate),
                                              GetDate(compareResult.RightModifiedDate));
        }

        public static string ToCsv(this CompareResult compareResult)
        {
            string description = "{0},{1},{2},{3},{4},{5},{6},{7}";
            return string.Format(description, compareResult.GetFileOrFolderName(), compareResult.LeftFilePath, compareResult.RightFilePath, compareResult.Match, compareResult.LeftCreatedDate, compareResult.RightCreatedDate, compareResult.LeftModifiedDate, compareResult.RightModifiedDate);
        }

        private static string GetDate(DateTime dt)
        {
            if (dt == DateTime.MinValue)
                return string.Empty;
            return dt.ToString();
        }
    }
}
