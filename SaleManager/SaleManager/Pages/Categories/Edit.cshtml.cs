using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace SaleManager.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;
      //individual way  [BindProperty]
        public  Category Category { get; set; }

        public EditModel(ApplicationDBContext db)
        {
            _dbContext = db;    
        }
        public void OnGet(int id)
        {
            Category = _dbContext.Categiry.Find(id);
            //Category = _dbContext.Categiry.FirstOrDefault(c => c.Id == id);
            //Category = _dbContext.Categiry.SingleOrDefault(c => c.Id == id);
            //Category = _dbContext.Categiry.Where(c => c.Id == id).FirstOrDefault();

        }
        //Use BindCategory So we doesn't need to inject data  =>  public async Task<IActionResult> OnPost(Category category)
        public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name","The display oerder canot exacly ,the the name");
            }
            if (ModelState.IsValid)
            {
                 _dbContext.Categiry.Update(Category);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = "Category Edit successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}


