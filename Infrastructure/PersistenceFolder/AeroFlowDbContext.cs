using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.PersistenceFolder
{
    public class AeroFlowDbContext : DbContext
    {

        public AeroFlowDbContext(DbContextOptions<AeroFlowDbContext> options) : base(options) 
        {

        }

        //Declaring DbSets
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<FlightLog> FlightLogs { get; set; }
        public DbSet<MaintenanceEvent> MaintenanceEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Enforcing Precision for properties dealing with hours

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.TotalAirframeHours)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Component>()
                .Property(c => c.TotalComponentHours)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Component>()
                .Property(c => c.MaximumHoursBeforeService)
                .HasPrecision(18, 2);

            modelBuilder.Entity<FlightLog>()
                .Property(f => f.FlightDuration)
                .HasPrecision(18, 2);

           //Enforcing a layer of protection so that a deleted aircraft does not cause its compenets to be removed
            modelBuilder.Entity<Component>()
                .HasOne(c => c.Aircraft)
                .WithMany(c => c.Components)
                .HasForeignKey(c => c.AircraftId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
