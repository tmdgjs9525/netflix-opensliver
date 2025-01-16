using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using netflix_opensliver.Core;
using netflix_opensliver.ViewModels;
using netflix_opensliver.Views;
using System;
using System.Windows;

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
            Container container = new Container(services);

            container.AddSingletonNavigation<LoginView,LoginViewModel>();

            services.AddSingleton<MainView>();
            services.AddSingleton<MainViewModel>();

            return services.BuildServiceProvider();
        }
    }

}
