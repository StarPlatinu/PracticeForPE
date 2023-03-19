using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly Q2.Models.PRN_Spr23_B1Context _context;

        public IndexModel(Q2.Models.PRN_Spr23_B1Context context)
        {
            _context = context;
        }

        public IList<Order> OrderVM { get; set; } = default!;
        String Cusname { get; set; }
        String Employee { get; set; }
        public String Address { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Orders != null)
            {
                OrderVM = await _context.Orders
                    .Select(p => new Order
                    {
                        OrderId = p.OrderId,
                        CustomerId = p.CustomerId,
                        EmployeeId = p.EmployeeId,
                        OrderDate = p.OrderDate,
                        RequiredDate = p.RequiredDate,
                        ShipAddress = p.ShipAddress
                    }).ToListAsync();
            }
        }
    }
}
