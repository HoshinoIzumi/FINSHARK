using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) 
        : base(dbContextOptions)
        {
            
        }
        
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}