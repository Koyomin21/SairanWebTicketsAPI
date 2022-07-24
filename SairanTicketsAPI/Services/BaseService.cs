using SairanTicketsDLA;


namespace SairanTicketsAPI.Services
{
    public abstract class BaseService
    {
        private readonly ApplicationDbContext _context;
        public BaseService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
