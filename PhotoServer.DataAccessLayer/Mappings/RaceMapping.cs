using PhotoServer.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PhotoServer.DataAccessLayer.Mappings
{
    public class RaceMapping : EntityTypeConfiguration<Race>
    {
        public RaceMapping()
        {
            ToTable("Race");

        }
    }
}
