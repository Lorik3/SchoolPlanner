using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolPlanner.Data;
using SchoolPlanner.Models;

namespace SchoolPlanner2.Pages.Teachers
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolPlanner.Data.SchoolContext _context;

        public DetailsModel(SchoolPlanner.Data.SchoolContext context)
        {
            _context = context;
        }

        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teachers.FirstOrDefaultAsync(m => m.TeacherID == id);

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
