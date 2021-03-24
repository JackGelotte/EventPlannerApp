using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventPlanner.Data;
using EventPlanner.Models;

namespace EventPlanner.Pages.AttendeeEvents
{
    public class IndexModel : PageModel
    {
        private readonly EventPlanner.Data.EventPlannerContext _context;

        public IndexModel(EventPlanner.Data.EventPlannerContext context)
        {
            _context = context;
        }

        public IList<AttendeeEvent> AttendeeEvent { get;set; }

        public async Task OnGetAsync()
        {
            AttendeeEvent = await _context.AttendeeEvents.Include(e=>e.Event).ThenInclude(o=>o.Organizer).Where(ae => ae.Attendee.ID == 1).ToListAsync();
        }
    }
}
