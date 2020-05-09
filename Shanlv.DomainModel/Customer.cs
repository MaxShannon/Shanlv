using System.Collections.Generic;

namespace Shanlv.DomainModel
{
    public class Customer : User
    {
        public string WxOpenId { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new HashSet<Order>(); // HashSet 与 list 区别
        }
    }
}