using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace SaleManager.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;
      //individual way  [BindProperty]
        public  Category Category { get; set; }

        public CreateModel(ApplicationDBContext db)
        {
            _dbContext = db;    
        }
        public void OnGet()
        {
        }
        //Use BindCategory So we doesn't need to inject data  =>  public async Task<IActionResult> OnPost(Category category)
        public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty,"The display oerder canot exacly ,the the name");
            }
            if (ModelState.IsValid)
            {
                await _dbContext.Categiry.AddAsync(Category);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = "Category Created successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}


