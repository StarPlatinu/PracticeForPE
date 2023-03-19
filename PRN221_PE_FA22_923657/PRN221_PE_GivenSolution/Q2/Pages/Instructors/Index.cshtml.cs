﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly Q2.Models.SchoolContextDBContext _context;

        public IndexModel(Q2.Models.SchoolContextDBContext context)
        {
            _context = context;
        }

        public IList<Instructor> Instructor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Instructors != null)
            {
                Instructor = await _context.Instructors.ToListAsync();
            }
        }
    }
}
