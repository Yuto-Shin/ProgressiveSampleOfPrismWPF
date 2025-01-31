﻿using ShowContentSelectedInList.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using PersonData;

namespace ShowContentSelectedInList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(new PersonList());
            containerRegistry.RegisterForNavigation<ContentControl>();
        }
    }
}
