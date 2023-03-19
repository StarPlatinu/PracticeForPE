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
    public class IndexModel : PageModel
    {
        private readonly q2_Trial.Models.Prn221Spr22Context _context;

        public IndexModel(q2_Trial.Models.Prn221Spr22Context context)
        {
            _context = context;
        }

        public IList<Room> Room { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Rooms != null)
            {
                Room = await _context.Rooms.ToListAsync();
            }
        }
    }
}
