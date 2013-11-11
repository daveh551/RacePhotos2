using System;
using System.Collections.Generic;
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
            Context = context => context.AsQueryable<Race>();
        }
    }
}
