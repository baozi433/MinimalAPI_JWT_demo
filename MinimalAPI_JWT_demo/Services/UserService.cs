using MinimalAPI_JWT_demo.Models;
using MinimalAPI_JWT_demo.Repositories;

namespace MinimalAPI_JWT_demo.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(u => u.UserName.Equals
            (userLogin.Username, StringComparison.OrdinalIgnoreCase) && u.Password.Equals(userLogin.Password));

            return user;
        }
    }
}
