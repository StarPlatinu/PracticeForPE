using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using q2_Trial.Hubs;
using q2_Trial.Models;

namespace q2_Trial.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly q2_Trial.Models.Prn221Spr22Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;

        public DeleteModel(q2_Trial.Models.Prn221Spr22Context context, IHubContext<SignalRServer> signalRHub)
        {
            _context = context;
            _signalRHub = signalRHub;
        }

        [BindProperty]
      public Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FirstOrDefaultAsync(m => m.Id == id);

            if (employee == null)
            {
                return NotFound();
            }
            else 
            {
                Employee = employee;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }
            var employee = await _context.Employees.FindAsync(id);

            if (employee != null)
            {
                Employee = employee;
                _context.Employees.Remove(Employee);
                await _context.SaveChangesAsync();
            }
            await _signalRHub.Clients.All.SendAsync("LoadEmployees");
            return RedirectToPage("./Index");
        }
    }
}
