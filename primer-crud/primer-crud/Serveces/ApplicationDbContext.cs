using Microsoft.EntityFrameworkCore;
using primer_crud.Models;

namespace primer_crud.Serveces
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> products { get; set; }
    }
}
