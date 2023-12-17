using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsDetails.Data;
using StudentsDetails.Models;

namespace StudentsDetails.Pages.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly StudentsDetails.Data.StudentsDetailsContext _context;

        public DetailsModel(StudentsDetails.Data.StudentsDetailsContext context)
        {
            _context = context;
        }

        public Students Students { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);
            if (students == null)
            {
                return NotFound();
            }
            else
            {
                Students = students;
            }
            return Page();
        }
    }
}
