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
    public class IndexModel : PageModel
    {
        private readonly StudentsDetails.Data.StudentsDetailsContext _context;

        public IndexModel(StudentsDetails.Data.StudentsDetailsContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
