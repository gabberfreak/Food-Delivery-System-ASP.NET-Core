using System;

namespace FoodDeliverySystem.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Picture { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }
    }
}
