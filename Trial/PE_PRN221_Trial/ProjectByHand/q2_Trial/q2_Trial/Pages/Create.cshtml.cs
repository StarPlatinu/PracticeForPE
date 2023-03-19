using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using q2_Trial.Hubs;
using q2_Trial.Models;

namespace q2_Trial.Pages
{
    public class CreateModel : PageModel
    {
        private readonly q2_Trial.Models.Prn221Spr22Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;
        public CreateModel(q2_Trial.Models.Prn221Spr22Context context,IHubContext<SignalRServer> signalRHub)
        {
            _context = context;
            _signalRHub = signalRHub;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Employees == null || Employee == null)
            {
                return Page();
            }

            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();
            await _signalRHub.Clients.All.SendAsync("LoadEmployees");
            return RedirectToPage("./Index");
        }
    }
}
