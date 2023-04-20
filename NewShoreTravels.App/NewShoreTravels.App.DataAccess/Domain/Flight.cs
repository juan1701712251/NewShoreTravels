using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreTravels.App.DataAccess.Domain
{
    public class Flight
    {
        [Key]
        public string ID { get; set; }
        [MaxLength(100)]
        public string Origin { get; set; }
        [MaxLength(100)]
        public string Destination { get; set; }
        public double Price { get; set; }

        // Transport
        public string? TransportID { get; set; }
        public Transport Transport { get; set; }

    }
}
