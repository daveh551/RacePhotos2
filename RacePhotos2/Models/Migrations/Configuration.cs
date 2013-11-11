using Microsoft.AspNet.Identity.EntityFramework;

namespace RacePhotos2.Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RacePhotos2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Models\Migrations";
            ContextKey = "RacePhotos2.Models.ApplicationDbContext";
        }

        protected override void Seed(RacePhotos2.Models.ApplicationDbContext context)
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
            
            context.Roles.AddOrUpdate(
                r => r.Id,
                new IdentityRole {Id = new Guid("02D3C98C-CC1F-4236-AE82-BE5E032713A5").ToString(), Name = "administrator"},
                new IdentityRole {Id = new Guid("58E3760C-DB3D-43FF-B66A-3100331FC19C").ToString(), Name = "contributor"});
        }
    }
}
