using System.Collections.Generic;

namespace Shanlv.DomainModel
{
    public class Cargo : BaseEntity
    {
        public string CargoName { get; set; }
        public ICollection<Shipment> Shipments { get; set; }

        public Cargo()
        {
            Shipments = new HashSet<Shipment>();
        }

    }
}