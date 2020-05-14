using System.Collections.Generic;
using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class Customer : PersonEntity
    {
        public string WxOpenId { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new HashSet<Order>(); // HashSet 与 list 区别
        }
    }
}