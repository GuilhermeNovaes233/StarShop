using System.Collections.Generic;

namespace StarShop.Domain.Entities
{
    public class User : Entitie
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddMessagesValidation("Error: Email cannot be empty");

            if (string.IsNullOrEmpty(Password))
                AddMessagesValidation("Error: Password cannot be empty");

        }
    }
}
