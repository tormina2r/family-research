using DryIoc;
using FamilyResearch.UI;

namespace FamilyResearch.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceContainer.Instance.Resolve<IApplicationEntryPoint>().Run();
        }
    }
}
