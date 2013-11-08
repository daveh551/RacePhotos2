using System.Data.Entity.ModelConfiguration;
using PhotoServer.Domain;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoServer.DataAccessLayer.Mappings
{
    public class EventMapping : EntityTypeConfiguration<Event>

    {
        public EventMapping()
        {
            ToTable("Event");
        }
    }
}
