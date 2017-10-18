using System.Collections.Generic;

namespace FamilyResearch.BusinessLogic
{
    public interface IPersonController
    {
        List<PersonDisplay> People { get; }
    }
}