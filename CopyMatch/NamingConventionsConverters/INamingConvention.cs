﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CopyMatch.NamingConventionsConverters
{
    public interface INamingConvention
    {
        string ThisToString(string inputString);
        string StringToThis(string inputString);
        bool IsTypeOfThis(string inputString);
    }
}
