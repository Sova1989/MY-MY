using System;

namespace example.Domain
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public bool Gender { get; set; }

        public DateTime Birthday { get; set; }

        public bool? MaritalStatus { get; set; }

        public string ListOfInterests { get; set; }
    }
}