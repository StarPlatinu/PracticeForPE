using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
         public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { 
        }
        public DbSet<Category> Categiry { get; set; }
    }
}
