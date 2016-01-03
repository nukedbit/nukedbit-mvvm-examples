using Autofac;
using MvvmExample.ViewModels;
using NukedBit.Mvvm;
using NukedBit.Mvvm.DI.AutoFac;

namespace MvvmExample.Views
{
    public class Ioc
    {
        protected virtual ContainerBuilder Register()
        {
            var builder = new ContainerBuilder();
            builder.Register(c =>
                ViewModelNavigation.Create(MvvmContainerAutofac.Create(c.Resolve<IComponentContext>()),true))
                .SingleInstance();
            builder.RegisterType<HomeViewModel>();
            builder.RegisterType<SecondViewModel>();
            builder.RegisterType<ThirdViewModel>();
            builder.RegisterType<HomeView>()
                .AsView();
            builder.RegisterType<SecondView>()
                .AsView();
            return builder;
        }

        public IContainer Build()
        {
            return Register()
                .Build();
        }
    }
}