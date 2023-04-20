using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NewShoreTravels.App.DataAccess.Domain;

namespace NewShoreTravels.App.DataAccess.Context
{
    public class NewShoreTravelsDbContext : DbContext
    {
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<JourneyFlight> JourneyFlights { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "../Temp/routesDB.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }

    }
}
