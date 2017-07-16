using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DirectoryComparer.Objects
{
    public enum FileCompareStrategy
    {
        [Description("Any File Simple Compare")]
        AnyFileCompare,
        [Description("Image Compare By MetaData")]
        ImageCompare,
    }
}
