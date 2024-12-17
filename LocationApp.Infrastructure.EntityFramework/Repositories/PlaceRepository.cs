using LocationApp.Domain.Entities;
using LocationApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Infrastructure.EntityFramework.Repositories
{
    public class PlaceRepository : Repository<Place>, IPlaceRepository
    {
        public PlaceRepository(LocationAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
