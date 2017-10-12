namespace FamilyResearch.Data.Migrations
{
    using FamilyResearch.Data.DataStructures;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FamilyResearch.Data.DataStructures.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FamilyResearch.Data.DataStructures.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.People.AddOrUpdate(
                p => p.Id,
                new Person { Id = 1, FirstName = "Lisa", Surname = "Pettersen", DateOfBirth = new DateTime(1983, 2, 12) });
        }
    }
}
