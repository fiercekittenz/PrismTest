using Prism.Ioc;
using Prism.Unity;
using PrismAppFramework;
using System;
using System.Windows;

namespace PrismTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterApplicationSpecificTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<Test>();
        }

        protected override void HandlePostInitialize()
        {
            Test test = Container.Resolve<Test>();
            MainWindow.Title = test.GetHeader();
        }
    }
}
