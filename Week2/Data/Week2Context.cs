using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week2.Models;

namespace Week2.Data
{
    public class Week2Context : DbContext
    {
        public Week2Context (DbContextOptions<Week2Context> options)
            : base(options)
        {
        }

        public DbSet<Week2.Models.Student> Student { get; set; } = default!;
    }
}
