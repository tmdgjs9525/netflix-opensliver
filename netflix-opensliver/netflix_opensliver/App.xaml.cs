using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using netflix_opensliver.ViewModels;
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

            var mainView         = provider.GetRequiredService<MainView>();
            mainView.DataContext = provider.GetRequiredService<MainViewModel>();

            Window.Current.Content = mainView;
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
            services.AddSingleton<MainView>();
            services.AddSingleton<MainViewModel>();

            return services.BuildServiceProvider();
        }
    }

}
