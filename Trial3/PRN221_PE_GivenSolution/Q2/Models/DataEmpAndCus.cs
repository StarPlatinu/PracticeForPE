using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Q2.Models
{
    public class DataEmpAndCus :PageModel
    {
        public SelectList CustomerSL { get; set; }
        public void PopulateCustomerDropDownList(PRN_Spr23_B1Context _context,
            object selectedOrder = null)
        {
            var orderquery = from d in _context.Customers  select d;

            CustomerSL = new SelectList(orderquery,
                nameof(Customer.CustomerId),
                nameof(Customer.ContactName),
                selectedOrder);
        }

        public SelectList EmployeeLN { get; set; }
        public void PopulateEmployeeDropDownList(PRN_Spr23_B1Context _context,
            object selectedOrder = null)
        {
            var employeequery = from d in _context.Employees select d;

            EmployeeLN = new SelectList(employeequery,
                nameof(Employee.EmployeeId),
                nameof(Employee.FirstName),
                selectedOrder);
        }
    }
}
