using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Q2.Models;

namespace Q2.Pages.Courses
{
    public class DepartmentNamePageModel : PageModel
    {
        public SelectList DepartmentNameSL { get; set; }
        public void PopulateDepartmentsDropDownList(SchoolContextDBContext _context,
            object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.Name // Sort by name.
                                   select d;

            DepartmentNameSL = new SelectList(departmentsQuery,
                nameof(Department.DepartmentId),
                nameof(Department.Name),
                selectedDepartment);
        }
    }
}
