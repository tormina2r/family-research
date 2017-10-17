using DryIoc;

namespace FamilyResearch.App
{
    public static class ServiceContainer
    {
        public static Container Instance;

        static ServiceContainer()
        {
            Instance = new Container();
            Data.Container.Register(Instance);
        }
    }
}
