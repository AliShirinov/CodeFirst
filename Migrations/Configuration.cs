namespace WinAppCF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WinAppCF.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WinAppCF.Models.PeopleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WinAppCF.Models.PeopleDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if(!context.People.Any())
            {
                context.People.AddOrUpdate(new Person
                {
                    Email = "admin@gmail.com",

                    Name = "Admin"
                });
            }
            
        }
    }
}
