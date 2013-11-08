using System;
using Common.Logging;
// [[Highway.Onramp.MVC.Data]]
using Highway.Data;
using RacePhotos2.App_Architecture.Configs;

namespace RacePhotos2.App_Architecture.Services.Data
{
    public class HighwayDataContext : DataContext
    {
        public HighwayDataContext(IConnectionStringConfig config, IMappingConfiguration mapping, IContextConfiguration contextConfiguration, ILog log)
            : base(config.ConnectionString, mapping, contextConfiguration, log)
        {
        }

        [Obsolete("Don't use this constructor in Application. Only here for Migrations")]
        public HighwayDataContext() :
            base("DefaultConnection", new PhotoServer.DataAccessLayer.Mappings.HighwayMappingConfiguration())
        {
                
        }
    }
}
