using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Q2.DataAccess;
using System.IO;

namespace Q2.Page
{
    public class IndexModel : PageModel
    {
      


		private readonly PRN_Spr23_B1Context _Context;
		
		public List<Product> Products { get; set; }

		public IndexModel(PRN_Spr23_B1Context context)
		{
			_Context = context;
		}
		public void OnGet()
		{
			Products = _Context.Products.Include(X => X.Category).ToList();
		}
    }
}
