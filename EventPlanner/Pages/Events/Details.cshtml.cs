using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventPlanner.Data;
using EventPlanner.Models;

namespace EventPlanner.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly EventPlanner.Data.EventPlannerContext _context;

        public DetailsModel(EventPlanner.Data.EventPlannerContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }
        public bool HasSpots => Event.SpotsAvailable > 0;
        public bool IsJoined { get; set; } = false;


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.Include(x=>x.Organizer).Where(e=>e.ID == id).FirstOrDefaultAsync();
            AttendeeEvent AttendeeEvent = await _context.AttendeeEvents.Where(ae => ae.Attendee.ID == 1 && ae.Event.ID == id).FirstOrDefaultAsync();

            if (AttendeeEvent != default)
            {
                IsJoined = true;
            }
            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
