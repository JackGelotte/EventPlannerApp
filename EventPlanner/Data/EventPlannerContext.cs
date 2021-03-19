using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventPlanner.Models;

namespace EventPlanner.Data
{
    public class EventPlannerContext : DbContext
    {
        public EventPlannerContext (DbContextOptions<EventPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<EventPlanner.Models.Event> Events { get; set; }
        public DbSet<EventPlanner.Models.Attendee> Attendees { get; set; }
        public DbSet<EventPlanner.Models.Organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
            modelBuilder.Entity<Organizer>().ToTable("Organizer");
            modelBuilder.Entity<Event>().ToTable("Event");
        }
    }
}
