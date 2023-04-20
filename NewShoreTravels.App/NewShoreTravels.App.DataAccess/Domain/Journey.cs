using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.DataAccess.Domain
{
    public class Journey
    {
        [Key]
        public string ID { get; set; }
        [MaxLength(100)]
        public string Origin { get; set; }
        [MaxLength(100)]
        public string Destination { get; set; }
        public double Price { get; set; }

        // List of Flights
        List<Flight> Flights { get; set; }
    }
}
