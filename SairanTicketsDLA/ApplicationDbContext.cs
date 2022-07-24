using Microsoft.EntityFrameworkCore;
using SairanTicketsDLA.Models;


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

        public DbSet<Bus> Buses { get; set; }

        
    }
}