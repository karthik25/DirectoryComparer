using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectoryComparer.Objects
{
    public class CompareResult
    {
        public int SerialNo { get; set; }
        public string LeftFilePath { get; set; }
        public string RightFilePath { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public DateTime LeftCreatedDate { get; set; }
        public DateTime LeftModifiedDate { get; set; }
        public DateTime RightCreatedDate { get; set; }
        public DateTime RightModifiedDate { get; set; }
        public bool ExistsLeft { get; set; }
        public bool ExistsRight { get; set; }
        public string LeftHash { get; set; }
        public string RightHash { get; set; }
        public bool Match { get; set; }
        public bool Compared { get; set; }
        public bool IsFile { get; set; }

        public override string ToString()
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
            return string.Format(description, this.FileName, 
                                              this.LeftFilePath, 
                                              this.RightFilePath, 
                                              this.Match,
                                              this.LeftCreatedDate,
                                              this.RightCreatedDate,
                                              this.LeftModifiedDate,
                                              this.RightModifiedDate);
        }
    }
}
