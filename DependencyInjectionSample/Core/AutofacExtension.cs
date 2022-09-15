using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Core
{
    internal static class AutofacExtension
    {

        public static void RegisterTransient<Type>(this ContainerBuilder builder)
        {
            builder.RegisterType<Type>()
                .AsSelf()
                .InstancePerDependency();
        }

        public static void RegisterTransient<Interface, Type>(this ContainerBuilder builder)
        {
            builder.RegisterType<Type>()
             .As<Interface>()
             .AsSelf()
              .InstancePerDependency();
        }

        public static void RegisterScoped<Type>(this ContainerBuilder builder)
        {
            builder.RegisterType<Type>()
                .AsSelf()
                .InstancePerLifetimeScope();
        }

        public static void RegisterScoped<Interface, Type>(this ContainerBuilder builder)
        {
            builder.RegisterType<Type>()
             .As<Interface>()
             .AsSelf()
              .InstancePerLifetimeScope();
        }

        /// <summary>
        /// 將自己註冊為單例實體，曝露介面為Interface
        /// </summary>
        public static void RegisterSingleton<Interface, Type>(this ContainerBuilder builder)
        {
            builder.RegisterType<Type>()
              .As<Interface>()
              .AsSelf()
              .SingleInstance();
        }

        
    }
}
