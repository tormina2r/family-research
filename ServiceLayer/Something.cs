using DryIoc;
using ServiceLayer.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public static class Something
    {
        public static void Register(IContainer container)
        {
            container.Register<IPersonRepository, PersonRepository>
        }
    }
}
