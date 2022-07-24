using SairanTicketsDLA;
using SairanTicketsDLA.Models;

namespace SairanTicketsAPI.Services
{
    public class UserService : BaseService, IUserService
    {

        public UserService(ApplicationDbContext context) : base(context)
        {

        }
        public void DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserAsync(int id)
        {
            User user = new User()
            {
                Id = id
            };
            return user;
        }

        public Task<User> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
