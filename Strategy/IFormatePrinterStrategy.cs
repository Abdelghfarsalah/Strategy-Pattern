﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    internal interface IFormatePrinterStrategy
    {
        void PrintFormate(string content);
    }
}
