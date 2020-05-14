using System.Collections.Generic;
using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
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