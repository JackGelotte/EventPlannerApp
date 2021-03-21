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
    public class DeleteModel : PageModel
    {
        private readonly EventPlanner.Data.EventPlannerContext _context;

        public DeleteModel(EventPlanner.Data.EventPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AttendeeEvent AttendeeEvent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AttendeeEvent = await _context.AttendeeEvents.FirstOrDefaultAsync(m => m.ID == id);

            if (AttendeeEvent == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AttendeeEvent = await _context.AttendeeEvents.FindAsync(id);

            if (AttendeeEvent != null)
            {
                _context.AttendeeEvents.Remove(AttendeeEvent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
