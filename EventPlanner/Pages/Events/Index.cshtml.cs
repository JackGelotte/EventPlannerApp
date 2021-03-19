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
    public class IndexModel : PageModel
    {
        private readonly EventPlanner.Data.EventPlannerContext _context;

        public IndexModel(EventPlanner.Data.EventPlannerContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }
        public async Task OnGetAsync()
        {
            Event = await _context.Events.Include(e=>e.Organizer).ToListAsync();
        }
    }
}
