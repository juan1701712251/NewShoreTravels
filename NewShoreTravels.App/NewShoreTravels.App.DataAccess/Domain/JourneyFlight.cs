using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.DataAccess.Domain
{
    public class JourneyFlight
    {
        // Flight
        public string? FlightID { get; set; }
        public Flight Flight { get; set; }

        // Journey
        public string? JourneyID { get; set; }
        public Journey Journey { get; set; }
    }
}
