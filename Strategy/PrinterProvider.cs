using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    internal class PrinterProvider
    {
        public IFormatePrinterStrategy formatePrinterStrategy;
        public PrinterProvider(IFormatePrinterStrategy formatePrinterStrategy)
        {
            this.formatePrinterStrategy = formatePrinterStrategy;
        }

        public void setNewFormatePrinter(IFormatePrinterStrategy formatePrinterStrategy)
        {
            this.formatePrinterStrategy = formatePrinterStrategy;
        }
        public void printContent(string content)
        {
            formatePrinterStrategy.PrintFormate(content);
        }
    }
}
