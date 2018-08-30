using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }

        public string Alias { get; set; }

        public string CardId { get; set; }

        public string Last4 { get; set; }
    }
}
