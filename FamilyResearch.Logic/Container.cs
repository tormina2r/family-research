using DryIoc;
using FamilyResearch.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.BusinessLogic
{
    public static class Container
    {
        public static void Register(IContainer container)
        {
            container.Register<IPersonController, PersonController>();
        }
    }
}
