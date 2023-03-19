using Q2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        private readonly PRN_Sum22_B1Context _context = new();
        public Form1()
        {
            InitializeComponent();
        }
        public List<Employee> Employees = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            courtesy.SelectedIndex = 0;
            department.DataSource = _context.Departments.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fName = firstName.Text;
            string lName = lastName.Text;
            string title = courtesy.Text;
            Department de = (Department)department.SelectedValue;
            DateTime dateBirth = birthDate.Value;
            Employee employee = new()
            {
                TitleOfCourtesy = title,
                FirstName = fName,
                LastName = lName,
                BirthDate = dateBirth,
                Department = de,
            };
            Employees.Add(employee);
            dataGridView1.DataSource = Employees.Select(x => new
            {
                x.FirstName,
                x.LastName,
                DepartmentId = x.Department.DepartmentId,
                x.TitleOfCourtesy,
                BirthDate = x.BirthDate?.ToString("dd/MM/yyyy"),
            }).ToList();
        }

        private void btnInsertAll_Click(object sender, EventArgs e)
        {
            if (Employees.Count > 0)
            {
                _context.Employees.AddRange(Employees);
                if (_context.SaveChanges() > 0)
                {
                    MessageBox.Show($"Insert successfully {Employees.Count} employee(s)");
                }
            }
        }
    }
}
