using Application.Persons.Queries;
using DryIoc;
using Domain.Persons.Queries;
using ServiceLayer.Persons;

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
            Instance.Register<IPersonRepository, DataAccess.Dummy.PersonRepository>();
        }
    }    
}
