using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q3_211.Models;
using System.Collections;       

namespace Q3_211.Pages.List
{
    public class IndexModel : PageModel
    {
        private readonly PrnSum22B1Context _context;
       
        public IndexModel(PrnSum22B1Context context)
        {
            this._context = context;
        }

        List<Employee> employees = new ArrayList<>();
        public void OnGet()
        {
        }
    }
}
