using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Q2.Hubs;
using Q2.Models;

namespace Q2.Pages
{
    public class OrderModel : PageModel
    {

        private readonly PRN_Spr23_B1Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;

        public OrderModel(PRN_Spr23_B1Context context, IHubContext<SignalRServer> signalRHub)
        {
            _context = context;
            _signalRHub = signalRHub;
        }

        public async Task<IActionResult> OnGet()
        {
            var orders = await _context.Orders.Include(o => o.Customer).Include(o => o.Employee).ToListAsync();
            ViewData["orders"] = orders;
            return Page();
        }

        public async Task<IActionResult> OnGetDelete(int id)
        {
            var order =  await _context.Orders.Where(o => o.OrderId == id).FirstOrDefaultAsync();
            var orderDetails = await _context.OrderDetails.Where(od => od.OrderId== id).ToListAsync(); 

            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.RemoveRange(orderDetails);
                _context.Remove(order);
                if(await _context.SaveChangesAsync() > 0)
                {
                    await transaction.CommitAsync();
                    await _signalRHub.Clients.All.SendAsync("LoadOrders");
                }
            }
            var orders = await _context.Orders.Include(o => o.Customer).Include(o => o.Employee).ToListAsync();
            ViewData["orders"] = orders;
            return Page();
        }
    }
}
