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

namespace q2_Trial.Pages.Rooms
{
    public class DeleteModel : PageModel
    {
        private readonly q2_Trial.Models.Prn221Spr22Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;


        public DeleteModel(q2_Trial.Models.Prn221Spr22Context context, IHubContext<SignalRServer> signalrhub)
        {
            _context = context;
            _signalRHub = signalrhub;
        }

        [BindProperty]
      public Room Room { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms.FirstOrDefaultAsync(m => m.Title == id);

            if (room == null)
            {
                return NotFound();
            }
            else 
            {
                Room = room;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }
            var room = await _context.Rooms.FindAsync(id);

            if (room != null)
            {
                Room = room;
                _context.Rooms.Remove(Room);
                await _context.SaveChangesAsync();
            }
            await _signalRHub.Clients.All.SendAsync("LoadRooms");
            return RedirectToPage("./Index");
        }
    }
}
