using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class Shipment : BaseEntity
    {
        public string ShipmentNo { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
    }
}