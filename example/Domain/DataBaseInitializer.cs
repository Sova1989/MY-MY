using System.Data.Entity;

namespace example.Domain
{
    public class DataBaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            context.Users.Add(new User()
            {
                UserName =  "aaa",
                UserSurname = "sss",
                Email = "aa@sd.asd",
                Password = "123123",
                Salt = "123",
                Gender = true
            });
            context.SaveChanges();
        }
    }
}