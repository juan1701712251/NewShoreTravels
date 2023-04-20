using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.DataAccess.Domain
{
    public class Transport
    {
        [Key]
        public string? ID { get; set; }
        public string FlightCarrier { get; set; } 
        public string FlightNumber { get; set; }

    }
}
