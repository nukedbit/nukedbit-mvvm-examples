using Autofac;
using MvvmExample.iOS.Views;
using MvvmExample.Views;
using NukedBit.Mvvm.DI.AutoFac;

namespace MvvmExample.iOS
{
    public class AppleIoc : Ioc
    {
        protected override ContainerBuilder Register()
        {
            var builder = base.Register();
            builder.RegisterType<ThirdView>()
                .AsView();
            return builder;
        }
    }
}
