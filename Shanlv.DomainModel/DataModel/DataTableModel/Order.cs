using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class Order : BaseEntity
    {
        public string Content { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public OrderState StateId { get; set; }
    }
}