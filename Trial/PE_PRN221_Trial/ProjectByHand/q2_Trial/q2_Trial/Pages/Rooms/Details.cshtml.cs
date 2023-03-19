using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using q2_Trial.Models;

namespace q2_Trial.Pages.Rooms
{
    public class DetailsModel : PageModel
    {
        private readonly q2_Trial.Models.Prn221Spr22Context _context;

        public DetailsModel(q2_Trial.Models.Prn221Spr22Context context)
        {
            _context = context;
        }

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
    }
}
