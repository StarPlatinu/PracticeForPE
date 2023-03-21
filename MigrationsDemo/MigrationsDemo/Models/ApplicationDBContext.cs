using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MigrationsDemo.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<MigrationsDemo.Models.Products> Products { get; set; } = default!;
    }
}

