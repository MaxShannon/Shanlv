namespace Shanlv.DomainModel
{
    public class Order : BaseEntity
    {
        public string Content { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}