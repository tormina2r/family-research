using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.UI
{
    public static class Container
    {
        public static void Register(IContainer container)
        {
            container.Register<IApplicationEntryPoint, ApplicationEntryPoint>(setup: Setup.With(allowDisposableTransient: true));
        }
    }
}
