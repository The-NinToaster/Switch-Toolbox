﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Switch_Toolbox.Library
{
    public interface ICompressionFormat
    {
        string[] Description { get; set; }
        string[] Extension { get; set; }

        bool Identify(Stream stream);
        bool CanCompress { get; }

        Stream Decompress(Stream stream);
        Stream Compress(Stream stream);
    }
}