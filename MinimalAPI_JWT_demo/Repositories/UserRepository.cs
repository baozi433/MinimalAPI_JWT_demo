using MinimalAPI_JWT_demo.Models;

namespace MinimalAPI_JWT_demo.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() {UserName = "yuanjie_admin", EmailAddress = "yuanjie.admin@email.com", Password = "Easy_passw0rd",
                   FirstName = "Jason", LastName = "Wu", Role = "Administrator" },
            new() {UserName = "lindsay_standard", EmailAddress = "lindsay.standard@email.com", Password = "Easy_passw0rd",
                   FirstName = "Lindsay", LastName = "Xue", Role = "Standard" },
        };
    }
}
