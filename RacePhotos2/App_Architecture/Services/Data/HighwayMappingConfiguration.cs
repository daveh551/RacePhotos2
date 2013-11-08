// [[Highway.Onramp.MVC.Data]]
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Highway.Data;
using RacePhotos2.Entities;

namespace RacePhotos2.App_Architecture.Services.Data
{
    public class HighwayMappingConfiguration : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(this.GetType().Assembly);
        }
    }
}