using System;

namespace FamilyResearch.UI
{
    public interface IApplicationEntryPoint: IDisposable
    {
        void Run();
    }
}