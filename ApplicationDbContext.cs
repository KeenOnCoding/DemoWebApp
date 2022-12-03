
using DemoWebApp.Models;
using Microsoft.EntityFrameworkCore;


namespace DemoWebApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }

}
