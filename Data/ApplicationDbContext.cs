using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task8ss.Models;

namespace AssigmentTask8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Task8ss.Models.Product> Product { get; set; }
        public DbSet<Task8ss.Models.Category> Category { get; set; }
    }
}