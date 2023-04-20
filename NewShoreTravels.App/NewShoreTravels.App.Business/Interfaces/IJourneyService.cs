using NewShoreTravels.App.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.Business.Interfaces
{
    public interface IJourneyService
    {
        public Journey GetJourney(string origin, string destination);
    }
}
