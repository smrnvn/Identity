using IdentityTestClient.Repositories;
using Prism.Ioc;
using Prism.Unity;
using Refit;
using System.Net.Http;
using System;
using System.Windows;
using IdentityTestClient.Views;

namespace IdentityTestClient
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterScoped<IIdentityAPI>(x =>
            {
                var client = new HttpClient()
                {
                    BaseAddress = new Uri("http://localhost:5192"),
                    Timeout = TimeSpan.FromSeconds(120)
                };

                return RestService.For<IIdentityAPI>(client);
            });
        }
    }
}
