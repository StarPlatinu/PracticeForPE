using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;


namespace SaleManager.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;
      //individual way  [BindProperty]
        public  Category Category { get; set; }

        public DeleteModel(ApplicationDBContext db)
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
         
            
                var cartegoryFromDb = _dbContext.Categiry.Find(Category.Id);
                if(cartegoryFromDb != null)
                {
                    _dbContext.Categiry.Remove(cartegoryFromDb);
                    await _dbContext.SaveChangesAsync();
                TempData["success"] = "Category Delete successfully";
                return RedirectToPage("Index");
            }                  
            return Page();
        }
    }
}


