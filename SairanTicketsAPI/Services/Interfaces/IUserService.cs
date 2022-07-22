using SairanTicketsDLA.Models;


namespace SairanTicketsAPI.Services
{
    public interface IUserService
    {
        Task<User> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        void UpdateUserAsync(User user);
        void DeleteUserAsync(int id);
    }
}
