using MinimalAPI_JWT_demo.Models;

namespace MinimalAPI_JWT_demo.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
