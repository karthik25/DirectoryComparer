using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirectoryComparer.Interfaces;
using DirectoryComparer.Objects;
using DirectoryComparer.Services;
using System.IO;

namespace DirectoryComparer.Comparers
{
    public class RecursiveDirectoryComparer : IDirectoryComparer
    {
        private ITwoPassComparer _comparer;

        private ComparisonResults _comparisonResults;

        public RecursiveDirectoryComparer(ITwoPassComparer comparer)
        {
            _comparer = comparer;
        }

        public ComparisonResults CompareDirectories()
        {
            _comparisonResults = new ComparisonResults();
            _comparisonResults.LeftResults = _comparer.LeftCompare(DirectoryComparerBaseInfo.LeftPath, DirectoryComparerBaseInfo.RightPath);
            _comparisonResults.RightResults = _comparer.RightCompare(DirectoryComparerBaseInfo.RightPath, DirectoryComparerBaseInfo.LeftPath);
            return _comparisonResults;
        }        
    }
}
