using DependencyInjectionSample.Controller;
using DependencyInjectionSample.Printer;
using DependencyInjectionSample.Repository;
using DependencyInjectionSample.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionSample
{
    public class DIServiceConfigure
    {
        private static ServiceProvider _provider;

        public static ServiceProvider GetProvider()
        {
            if (_provider is null) _provider = CreateServiceProvider();
            return _provider;
        }

        private static ServiceProvider CreateServiceProvider()
        {
            var collection = new ServiceCollection();


            // 系統單一物件定義使用，或沒有異部與大量Request問題，可直接用Singleton
            collection.AddSingleton<ISingletonLogRepository, LogRepository>();

            // 異部，且須大量Request的建議使用Transient (WundowsForm簡易Sample較難模擬)
            collection.AddTransient<ITransientLogRepository, LogRepository>();

            // 有生命週期的物件建議使用Scoped (須寫一個有生命周期的Thread去拿這個物件)
            collection.AddScoped<IScopedLogRepository, LogRepository>();

            collection.AddTransient<LogService>();

            // 彷 Web API
            collection.AddScoped<LogController>();
            collection.AddTransient<LogController2>();


            collection.AddTransient<IPrinter, PrinterMethodA>();
            collection.AddTransient<IPrinter, PrinterMethodB>();

            // 宣告MainFrom
            collection.AddScoped<Dialog>();
            collection.AddScoped<Form1>();

            return collection.BuildServiceProvider();
        }

    }
}
