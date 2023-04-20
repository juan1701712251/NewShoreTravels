using NewShoreTravels.App.DataAccess.Context;
using NewShoreTravels.App.DataAccess.Domain;
using NewShoreTravels.App.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.DataAccess.Repositories
{
    public class JourneyRepository : IJourneyRepository
    {
        private readonly NewShoreTravelsDbContext _dbContext;
        public JourneyRepository(NewShoreTravelsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Journey GetJourney(string origin, string destination)
        {
            throw new NotImplementedException();
        }

        public bool SaveJourney(Journey journey)
        {
            throw new NotImplementedException();
        }
    }
}
