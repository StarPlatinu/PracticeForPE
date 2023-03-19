using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using q2_Trial.Hubs;
using q2_Trial.Models;

namespace q2_Trial.Pages.Rooms
{
    public class CreateModel : PageModel
    {
        private readonly q2_Trial.Models.Prn221Spr22Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;

        public CreateModel(Prn221Spr22Context context, IHubContext<SignalRServer> signalRHub) 
        {
            _context = context;
            _signalRHub = signalRHub;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Room Room { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Rooms == null || Room == null)
            {
                return Page();
            }

            _context.Rooms.Add(Room);
            await _context.SaveChangesAsync();
            await _signalRHub.Clients.All.SendAsync("LoadRooms");
            return RedirectToPage("./Index");
        }
    }
}
