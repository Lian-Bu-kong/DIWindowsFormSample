using System;

namespace DependencyInjectionSample.Printer
{
    public class PrinterMethodB : IPrinter
    {
        public void PirnterOut(string message)
        {
            Console.WriteLine("MethodB Print:" + message);
        }
    }
}
