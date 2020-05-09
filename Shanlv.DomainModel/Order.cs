namespace Shanlv.DomainModel
{
    public class Order : BaseEntity
    {
        public string Content { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}