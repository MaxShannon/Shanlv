using System.Collections.Generic;

namespace Shanlv.DomainModel
{
    public class Cargo : BaseEntity
    {
        public Cargo()
        {
            Shipments = new List<Shipment>();
        }
        public string CargoName { get; set; }
        public List<Shipment> Shipments { get; set; }

    }
}