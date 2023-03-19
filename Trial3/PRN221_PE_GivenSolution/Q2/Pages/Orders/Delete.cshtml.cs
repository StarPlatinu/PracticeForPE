using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Q2.Hubs;
using Q2.Models;

namespace Q2.Pages.Orders
{
    public class DeleteModel : PageModel
    {
        private readonly Q2.Models.PRN_Spr23_B1Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;
        public DeleteModel(Q2.Models.PRN_Spr23_B1Context context, IHubContext<SignalRServer> signalRHub)
        {
            _context = context;
            _signalRHub = signalRHub;
        }

        [BindProperty]
        public Order Order { get; set; }

       

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }
            var course =  _context.Orders.Include(x => x.OrderId ==id);

            if (course != null)
            {
             
                _context.Orders.Remove((Order)_context.Orders.Include(x=>x.OrderId == id));
                await _context.SaveChangesAsync();
                await _signalRHub.Clients.All.SendAsync("LoadOrder");
            }

            return RedirectToPage("./Index");
        }
    }
}
