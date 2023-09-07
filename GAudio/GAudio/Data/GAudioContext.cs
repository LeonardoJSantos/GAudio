using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GAudio.Models;

namespace GAudio.Data
{
    public class GAudioContext : DbContext
    {
        public GAudioContext (DbContextOptions<GAudioContext> options)
            : base(options)
        {
        }

        public DbSet<GAudio.Models.Company> Company { get; set; } = default!;
    }
}
