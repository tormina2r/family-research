using Application.Persons.Queries;
using DryIoc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public static class ServiceContainer
    {
        public static IContainer Instance;

        static ServiceContainer()
        {
            Instance = new Container(Rules.Default
                .WithConcreteTypeDynamicRegistrations()
                .WithTrackingDisposableTransients());

            Instance.Register<IGetPersonsQuery, GetPersonsQuery>();
        }
    }    
}
