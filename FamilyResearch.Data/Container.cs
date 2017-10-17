using DryIoc;
using FamilyResearch.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Data
{
    public static class Container
    {
        public static void Register(IContainer container)
        {
            container.Register<IPersonRepository, PersonRepository>();
        }
    }
}
