using example.Domain;
using example.Models;

namespace example.Core
{
    public interface IUserProcessor
    {
        bool CreateUser(RegisterModel registerModel);

        bool Authenticate(string email, string password);

        User GetUserByEmail(string email);
    }
}