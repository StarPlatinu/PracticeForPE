using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using System.Collections;

namespace SaleManager.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDBContext database)
        {
            _db = database;
        }
        public void OnGet()
        {
            Categories = _db.Categiry;
        }
    }
}
