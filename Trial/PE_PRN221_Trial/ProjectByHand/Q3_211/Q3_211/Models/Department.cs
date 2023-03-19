using System;
using System.Collections.Generic;

namespace Q3_211.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public string? DepartmentType { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
