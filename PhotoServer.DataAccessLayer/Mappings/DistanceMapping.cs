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
    public class DistanceMapping : EntityTypeConfiguration<Distance>
    {
        public DistanceMapping()
        {
            ToTable("Distance");
        }
    }
}
