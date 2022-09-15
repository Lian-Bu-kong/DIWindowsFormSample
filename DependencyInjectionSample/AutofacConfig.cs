using Autofac;
using DependencyInjectionSample.Controller;
using DependencyInjectionSample.Core;
using DependencyInjectionSample.Printer;
using DependencyInjectionSample.Repository;
using DependencyInjectionSample.Service;

namespace DependencyInjectionSample
{
    public class AutofacConfig
    {
        private static readonly ContainerBuilder _builder = new ContainerBuilder();

        public static IContainer Container { get; private set; }
        public static IContainer GetContainer()
        {
            _builder.RegisterSingleton<ISingletonLogRepository, LogRepository>();
            _builder.RegisterTransient<ITransientLogRepository, LogRepository>();
            _builder.RegisterScoped<IScopedLogRepository, LogRepository>();
            _builder.RegisterTransient<LogService>();
            _builder.RegisterTransient<LogController>();
            _builder.RegisterTransient<LogController2>();
            _builder.RegisterTransient<IPrinter, PrinterMethodA>();
            //_builder.RegisterTransient<IPrinter, PrinterMethodB>();

            _builder.RegisterScoped<Dialog>();
            _builder.RegisterScoped<Form1>();
            Container = _builder.Build();
            return Container;
        }
    }
}
