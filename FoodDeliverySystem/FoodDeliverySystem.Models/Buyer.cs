using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class Buyer
    {
        private Buyer()
        {
        }

        public Buyer(string identity) : this()
        {
            Guard.Against.NullOrEmpty(identity, nameof(identity));
            UserId = identity;
        }

        public int Id { get; set; }

        public string UserId { get; set; }

        public ICollection<PaymentMethod> PaymentMethods { get; set; }

    }
}
