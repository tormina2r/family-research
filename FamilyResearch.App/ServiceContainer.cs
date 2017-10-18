using DryIoc;

namespace FamilyResearch.App
{
    public static class ServiceContainer
    {
        public static Container Instance;

        static ServiceContainer()
        {
            Instance = new Container();

            BusinessLogic.Container.Register(Instance);
            Data.Container.Register(Instance);
            UI.Container.Register(Instance);
        }
    }
}
