using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GAudio.Models;
using GAudio.Models.Enums;

namespace GAudio.Data
{
    public class GAudioContext : DbContext
    {
        public GAudioContext (DbContextOptions<GAudioContext> options)
            : base(options)
        {
        }

        public DbSet<GAudio.Models.Company> Company { get; set; } = default!;

        public DbSet<GAudio.Models.Enums.Unit>? Unit { get; set; }

        public DbSet<GAudio.Models.Employee>? Employee { get; set; }
    }
}
