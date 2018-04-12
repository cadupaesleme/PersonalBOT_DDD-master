using PersonalBot.CrossCutting.IoC;
using SimpleInjector;

namespace PersonalBot.Services.ConsoleApp
{
    public static class SimpleInjectorInitializer
    {
        public static Container Initialize()
        {
            var container = new Container();

            InitializeContainer(container);

            container.Verify();

            return container;
        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}
