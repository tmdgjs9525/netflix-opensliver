using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace netflix_opensliver
{
    public sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            IServiceProvider provider = serviceInitialize();

            var mainPage = provider.GetRequiredService<MainPage>();

            Window.Current.Content = mainPage;
        }

        private IServiceProvider serviceInitialize()
        {
            ServiceCollection services = new ServiceCollection();

            IServiceProvider provider = Configure.ConfigureService(services);

            Ioc.Default.ConfigureServices(provider);

            return provider;
        }
    }

    internal static class Configure
    {
        public static IServiceProvider ConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<MainPage>();

            return services.BuildServiceProvider();
        }
    }

}
