using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace PrismAppFramework
{
    public abstract class TestApplication : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ContainerRegistry = containerRegistry;
            RegisterApplicationSpecificTypes(containerRegistry);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            HandlePostInitialize();
        }

        protected override IContainerExtension CreateContainerExtension() => new UnityContainerExtension();

        public IContainerRegistry? ContainerRegistry { get; private set; }

        // New methods
        protected abstract void RegisterApplicationSpecificTypes(IContainerRegistry containerRegistry);
        protected abstract void HandlePostInitialize();
    }
}