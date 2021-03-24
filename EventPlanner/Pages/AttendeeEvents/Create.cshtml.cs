using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventPlanner.Data;
using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Pages.AttendeeEvents
{
    public class CreateModel : PageModel
    {
        private readonly EventPlanner.Data.EventPlannerContext _context;

        public CreateModel(EventPlanner.Data.EventPlannerContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Event = await _context.Events.Where(e => e.ID == id).FirstOrDefaultAsync();
            if(Event == default)
            {
                return RedirectToPage("../Events/Details", new { id });
            }
            AttendeeEvent joinedEvent = new AttendeeEvent()
            {
                Attendee = await _context.Attendees.Where(a => a.ID == 1).FirstOrDefaultAsync(),
                Event = Event,
            };
            _context.AttendeeEvents.Add(joinedEvent);

            if(Event != default)
            {
                Event.SpotsAvailable--;
            }
            
            await _context.SaveChangesAsync();

            return RedirectToPage("../Events/Details", new { id });
        }

        [BindProperty]
        public AttendeeEvent AttendeeEvent { get; set; }
        public Event Event { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AttendeeEvents.Add(AttendeeEvent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
