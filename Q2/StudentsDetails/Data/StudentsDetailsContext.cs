using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsDetails.Models;

namespace StudentsDetails.Data
{
    public class StudentsDetailsContext : DbContext
    {
        public StudentsDetailsContext (DbContextOptions<StudentsDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsDetails.Models.Students> Students { get; set; } = default!;
        public DbSet<StudentsDetails.Models.Course> Course { get; set; } = default!;
    }
}
