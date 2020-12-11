namespace StarShop.Domain.Entities
{
    public class Product : Entitie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddMessagesValidation("Error: Product name was not informed");

            if (string.IsNullOrEmpty(Description))
                AddMessagesValidation("Error: Description was not informed");

        }
    }
}
