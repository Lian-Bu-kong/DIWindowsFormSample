using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Autofac;

namespace DependencyInjectionSample
{
    public class Bootstrapper
    {
        // Net DI
        private readonly IServiceProvider _sysServiceProvider;
        
        // Autofac
        //private readonly IContainer _container;
        public Bootstrapper()
        {
            // Net DI
            _sysServiceProvider = DIServiceConfigure.GetProvider();
            // Autofac
            //_container = AutofacConfig.GetContainer();
        }

        public void Run()
        {
            StarFormApp();
        }

        private void StarFormApp()
        {
            // Net DI
            var form = _sysServiceProvider.GetRequiredService<Form1>();
            // Autofac
            //var form = _container.Resolve<Form1>();
            Application.Run(form);
        }
    }
}
