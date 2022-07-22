using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SairanTicketsAPI.Models;

namespace SairanTicketsAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                FirstName = "Anuar",
                LastName = "Bora",
                Email = "anuar@mail.ru",
                Password = "anuar123",
                isDeleted = false

            },
            new User()
            {
                Id = 2,
                FirstName = "Elvira",
                LastName = "Nuga",
                Email = "elvira@mail.ru",
                Password = "elvira123",
                isDeleted = false

            },
            new User()
            {
                Id = 3,
                FirstName = "Diyar",
                LastName = "Ush",
                Email = "diyar@mail.ru",
                Password = "diayr123",
                isDeleted = false

            },

        };


        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return Users;
        }

        
    }
}
