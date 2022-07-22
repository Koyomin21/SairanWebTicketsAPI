using Microsoft.EntityFrameworkCore;

namespace SairanTicketsDLA
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        
    }
}