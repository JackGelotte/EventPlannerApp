using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        [Display(Name="Spots Available")]
        public bool SpotsAvailable { get; set; } = true;
        public Organizer Organizer { get; set; }
        public ICollection<AttendeeEvent> AttendeeEvents { get; set; }
    }
}
