using System;
using System.Linq;
using System.Web.Security;
using example.Domain;
using example.Models;

namespace example.Core
{
    public class UserProcessor : IUserProcessor
    {
        public bool CreateUser(RegisterModel model)
        {
            using (DataBaseContext dataBaseContext = new DataBaseContext())
            {
                if (dataBaseContext.Users.ToList().Any(it => (it.UserName.ToLower().Equals(model.UserName.ToLower()) &&
                                                             it.UserSurname.ToLower().Equals(model.UserSurname.ToLower())) ||
                                                             it.Email.ToLower().Equals(model.ToString().ToLower())))
                {
                    return false;
                }
                try
                {
                    Hasher hasher = new Hasher();
                    string salt = hasher.GetSalt();
                    dataBaseContext.Users.Add(new User()
                    {
                        UserName = model.UserName,
                        UserSurname = model.UserSurname,
                        Email = model.Email,
                        Salt = salt,
                        Password = hasher.GetHashString(hasher.GetHashString(model.Password)/* + salt*/),
                        Gender = model.Gender,
                        Birthday = model.Birthday,
                        MaritalStatus = model.MaritalStatus,
                        ListOfInterests = model.ListOfInterests
                    });
                    dataBaseContext.SaveChanges();
                }
                catch (Exception)
                {

                    return false;
                }

                return true;
            }

        }

        public bool Authenticate(string email, string password)
        {
            DataBaseContext dataBaseContext = new DataBaseContext();
            Hasher hasher = new Hasher();

            string passwordHash = hasher.GetHashString(hasher.GetHashString(password) /* + salt*/);
            if (dataBaseContext.Users.Any(it => it.Email.Equals(email.ToLower()) &&
                                               it.Password.Equals(passwordHash)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}