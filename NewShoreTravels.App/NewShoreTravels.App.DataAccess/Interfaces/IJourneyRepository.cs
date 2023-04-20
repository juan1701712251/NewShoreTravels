using NewShoreTravels.App.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.DataAccess.Interfaces
{
    public interface IJourneyRepository
    {
        // Save Journey
        bool SaveJourney(Journey journey);

        // Get Journey
        Journey GetJourney(string origin, string destination);
        
    }
}
