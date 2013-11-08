using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PhotoServer.Domain;

namespace RacePhotos2.App_Architecture.Services.Data
{
    public class PhotoServerDbContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Distance> Distances { get; set; }
    }
}