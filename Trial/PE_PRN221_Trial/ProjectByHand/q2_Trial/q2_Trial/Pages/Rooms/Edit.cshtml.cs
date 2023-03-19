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
    public class EditModel : PageModel
    {
        private readonly q2_Trial.Models.Prn221Spr22Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;
        public EditModel(q2_Trial.Models.Prn221Spr22Context context, IHubContext<SignalRServer> signalRHub)
        {
            _context = context;
            _signalRHub = signalRHub;
        }

        [BindProperty]
        public Room Room { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }

            var room =  await _context.Rooms.FirstOrDefaultAsync(m => m.Title == id);
            if (room == null)
            {
                return NotFound();
            }
            Room = room;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(Room.Title))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            await _signalRHub.Clients.All.SendAsync("LoadRooms");
            return RedirectToPage("./Index");
        }

        private bool RoomExists(string id)
        {
          return (_context.Rooms?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
