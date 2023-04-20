using NewShoreTravels.App.Business.Interfaces;
using NewShoreTravels.App.DataAccess.Domain;
using NewShoreTravels.App.DataAccess.Interfaces;
using NewShoreTravels.App.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.Business.Services
{
    public class JourneyService : IJourneyService
    {
        private readonly IJourneyRepository _journeyRepository;

        public JourneyService(IJourneyRepository journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }
        public Journey GetJourney(string origin, string destination)
        {
            Journey journey;
            try
            {
                // Find into local repository if exist a journey with that origin and destination
                journey = _journeyRepository.GetJourney(origin, destination);

                if (journey == null)
                {
                    // Find into extern NewShoreTravelsAPI
                    // TO DO

                    // Save journey into local repository to use future
                    // TO DO
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return journey;
        }
    }
}
