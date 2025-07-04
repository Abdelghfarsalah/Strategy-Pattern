using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    internal class pdfPrinter : IFormatePrinterStrategy
    {
        public void PrintFormate(string content)
        {
            Console.WriteLine($"pdf : {content}");

        }
    }
}
