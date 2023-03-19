using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Q2.Hubs;
using Q2.Models;

namespace Q2.Pages.Courses
{
    public class DeleteModel : PageModel
    {
        private readonly Q2.Models.SchoolContextDBContext _context;
        private readonly IHubContext<SignalRServer> _signalRHub;
        public DeleteModel(Q2.Models.SchoolContextDBContext context, IHubContext<SignalRServer> signalRHub)
        {
            _context = context;
            _signalRHub = signalRHub;
        }

        [BindProperty]
      public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.Include(c => c.Department).FirstOrDefaultAsync(m => m.CourseId == id);

            if (course == null)
            {
                return NotFound();
            }
            else 
            {
                Course = course;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses.Include(c => c.Department)
                .FirstOrDefaultAsync(m => m.CourseId == id);

            if (course != null)
            {
                Course = course;
                _context.Courses.Remove(Course);
                await _context.SaveChangesAsync();
                await _signalRHub.Clients.All.SendAsync("LoadCourses");
            }

            return RedirectToPage("./Index");
        }
    }
}
