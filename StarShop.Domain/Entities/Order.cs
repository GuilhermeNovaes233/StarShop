using StarShop.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace StarShop.Domain.Entities
{
    public class Order
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
    }
}