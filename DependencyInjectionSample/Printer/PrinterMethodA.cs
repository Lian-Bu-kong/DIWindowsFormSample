using System;

namespace DependencyInjectionSample.Printer
{
    public class PrinterMethodA : IPrinter
    {
        public void PirnterOut(string message)
        {
            Console.WriteLine("MethodA Print:" + message);
        }
    }
}
