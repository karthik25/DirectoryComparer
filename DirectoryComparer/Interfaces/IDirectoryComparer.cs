using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirectoryComparer.Objects;
using System.ComponentModel;

namespace DirectoryComparer.Interfaces
{
    public interface IDirectoryComparer
    {
        ComparisonResults CompareDirectories();
    }
}
