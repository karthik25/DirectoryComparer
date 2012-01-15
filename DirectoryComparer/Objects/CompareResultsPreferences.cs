using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectoryComparer.Objects
{
    public class CompareResultsPreferences
    {
        public string DefaultLeftPath { get; set; }
        public string DefaultRightPath { get; set; }
        public List<ColumnItem> Columns { get; set; }
    }

    public class ColumnItem
    {
        public string ColumnCaption { get; set; }
        public bool IsVisible { get; set; }
    }

    public class ColumnItemHelper
    {
        public static List<ColumnItem> GetColumns(string columnStr)
        {
            return new List<ColumnItem>()
            {
                new ColumnItem { ColumnCaption = "Left Created Date", IsVisible = (columnStr.Split(',')[0] == "1")},
                new ColumnItem { ColumnCaption = "Right Created Date", IsVisible = (columnStr.Split(',')[1] == "1")},
                new ColumnItem { ColumnCaption = "Left Modified Date", IsVisible = (columnStr.Split(',')[2] == "1")},
                new ColumnItem { ColumnCaption = "Right Modified Date", IsVisible = (columnStr.Split(',')[3] == "1")},
                new ColumnItem { ColumnCaption = "Left Hash", IsVisible = (columnStr.Split(',')[4] == "1")},
                new ColumnItem { ColumnCaption = "Right Hash", IsVisible = (columnStr.Split(',')[5] == "1")}
            };
        }
    }

    public static class BoolHelpers
    {
        public static int ToInt(this bool flag)
        {
            return Convert.ToInt32(flag);
        }
    }
}
