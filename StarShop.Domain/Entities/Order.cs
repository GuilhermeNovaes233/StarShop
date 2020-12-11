using StarShop.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarShop.Domain.Entities
{
    public class Order : Entitie
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public DateTime ForecastDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public string Complement { get; set; }
        public int FormPaymentId { get; set; }
        public FormPayment FormPayment { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            ClearMessagesValidation();
            if (!OrderItems.Any())
            {
                AddMessagesValidation("Error: OrderItem cannot be empty");
            }
            if (String.IsNullOrEmpty(CEP))
            {
                AddMessagesValidation("Error: CEP cannot be empty");
            }
        }
    }
}