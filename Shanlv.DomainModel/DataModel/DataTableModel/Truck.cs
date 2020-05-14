using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class Truck : BaseEntity
    {
        public string TruckCardNo { get; set; }

        public int UserId { get; set; }
    }
}