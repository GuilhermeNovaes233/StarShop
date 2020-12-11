using System;
using System.Collections.Generic;

namespace StarShop.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
