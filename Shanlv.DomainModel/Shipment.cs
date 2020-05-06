namespace Shanlv.DomainModel
{
    public class Shipment : BaseEntity
    {
        public string ShipmentNo { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
    }
}