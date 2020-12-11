namespace StarShop.Domain.Entities
{
    public class OrderItem : Entitie
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            ClearMessagesValidation();
            if (ProductId == 0)
            {
                AddMessagesValidation("Error: It was not identified which product reference");
            }
            if (Quantity == 0)
            {
                AddMessagesValidation("Error: Quantity cannot be empty");
            }

        }
    }
}
