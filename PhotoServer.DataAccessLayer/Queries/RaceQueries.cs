using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoServer.Domain;
using Highway.Data;

namespace PhotoServer.DataAccessLayer.Queries
{
    public class FindAllRaces : Query<Race>
    {
        public FindAllRaces()
        {
            ContextQuery = context => context.AsQueryable<Race>().Include("Event").Include("Distance");
        }
    }

    public class FindRaceById : Scalar<Race>
    {
        public FindRaceById(int raceId)
        {
            ContextQuery =
                context =>
                    context.AsQueryable<Race>().Include("Event").Include("Distance").FirstOrDefault(r => r.Id == raceId);
        }
    }
}
