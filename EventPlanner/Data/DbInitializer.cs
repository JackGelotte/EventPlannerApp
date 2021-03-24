using EventPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(EventPlannerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Attendees.Any())
            {
                return;
            }

            var attendees = new Attendee[]
            {
                new Attendee{FirstName="Björn", LastName="Strömberg", EmailAddress="me@hacker.se"},
            };

            context.Attendees.AddRange(attendees);
            context.SaveChanges();

            var organizers = new Organizer[]
            {
                new Organizer{Name="Grabs Inc.", EmailAddress="info@grabs.com"},
                new Organizer{Name="Monsters Inc.", EmailAddress="info@monster.com"},
                new Organizer{Name="Richalito Games", EmailAddress="winner@gamer.com"},
            };

            context.Organizers.AddRange(organizers);
            context.SaveChanges();

            var events = new Event[]
            {
                new Event{Title="Lazy Sunday", Description="Make breakfast, watch tv and do nothing else.", Organizer = organizers[0], Address="Homestreet 52, Earth", Date=DateTime.Parse("2022-05-21"), SpotsAvailable=20,},
                new Event{Title="Dreamhack", Description="Play games, win stuff.", Organizer = organizers[2], Address="Kungsgatan 3, Jönköping", Date=DateTime.Parse("2021-10-15"), SpotsAvailable=3,},
                new Event{Title="Programming Fest", Description="Hack your neighbour and stuff.", Organizer = organizers[1], Address="RobinStreet 2, Gothenburg", Date=DateTime.Parse("2021-03-29"), SpotsAvailable=0,},
                new Event{Title="Music and stuff", Description="Start Spotify and act like a dj.", Organizer = organizers[0], Address="SpasticCorner 9, Paris", Date=DateTime.Parse("2025-01-02"), SpotsAvailable=42,},
                new Event{Title="E3 Expo", Description="Celebrations and game announcements.", Organizer = organizers[2], Address="GameCity, Los Angeles", Date=DateTime.Parse("2021-12-24"), SpotsAvailable=59,},
                new Event{Title="Skriva Rapport", Description="Kryp under en sten osv.", Organizer = organizers[0], Address="NopeStreet 13, Madrid", Date=DateTime.Parse("2022-09-09"), SpotsAvailable=1,},

            };

            context.Events.AddRange(events);
            context.SaveChanges();
        }
    }
}
