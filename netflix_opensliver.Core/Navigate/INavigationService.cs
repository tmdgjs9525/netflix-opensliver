﻿using netflix_opensliver.Core.Parameter;
using System.Windows.Controls;

namespace netflix_opensliver.Core.Navigate
{
    public interface INavigationService
    {
        void NavigateTo(string regionName, string viewName, Parameters? parameters = null);
    }

    public interface INavigationRegister
    {
        public void AddTransientNavigation<TView, TViewModel>() where TView : Control
                                                                where TViewModel : ViewModelBase;
        public void AddSingletonNavigation<TView, TViewModel>() where TView : Control
                                                                where TViewModel : ViewModelBase;

        public void AddSingletonNavigation<TInterface, TImplementation, TViewModel>()
                    where TInterface : class
                    where TImplementation : Control, TInterface
                    where TViewModel : ViewModelBase;

        public void AddTransientNavigation<TInterface, TImplementation, TViewModel>()
                   where TInterface : class
                   where TImplementation : Control, TInterface
                   where TViewModel : ViewModelBase;
    }

    public interface IRegionRegister
    {
        public void RegisterRegion(string regionName, ContentControl control);
    }

    public interface INavigateAware
    {
        public void NavigateTo(Parameters parameters);
    }
}
