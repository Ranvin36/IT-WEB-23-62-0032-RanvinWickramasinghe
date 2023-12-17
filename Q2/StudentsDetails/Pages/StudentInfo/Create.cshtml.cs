using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentsDetails.Data;
using StudentsDetails.Models;

namespace StudentsDetails.Pages.Pages
{
    public class CreateModel : PageModel
    {
        private readonly StudentsDetails.Data.StudentsDetailsContext _context;

        public CreateModel(StudentsDetails.Data.StudentsDetailsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Students Students { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Students);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
