using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Q2.Models;
using Q2.Models.SchoolViewModels;

namespace Q2.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly Q2.Models.SchoolContextDBContext _context;

        public IndexModel(Q2.Models.SchoolContextDBContext context)
        {
            _context = context;
        }

        public IList<CourseViewModel> CourseVM { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Courses != null)
            {
                CourseVM = await _context.Courses
                    .Select(p => new CourseViewModel
                    {
                        CourseId = p.CourseId,
                        Title = p.Title,
                        Credits = p.Credits,
                        DepartmentName = p.Department.Name
                    }).ToListAsync();
            }
        }
    }
}
