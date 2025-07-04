

using StrategyPattern.Strategy;

IFormatePrinterStrategy formatePrinterStrategy=null;
formatePrinterStrategy = new pdfPrinter();

Console.WriteLine("-----------------------------------");
Console.WriteLine("Print in pdf formate");
PrinterProvider printerProvider = new PrinterProvider(formatePrinterStrategy);
printerProvider.printContent("Abdelghfar salah Khairallah");

Console.WriteLine("-----------------------------------");
Console.WriteLine("Print in excel formate");
printerProvider.setNewFormatePrinter(new excelPrinter());
printerProvider.printContent("Abdelghfar salah Khairallah");

Console.WriteLine("-----------------------------------");
Console.WriteLine("Print in word formate");
printerProvider.setNewFormatePrinter(new wordPrinter());
printerProvider.printContent("Abdelghfar salah Khairallah");