using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Shanlv.EfDbModels.DbTable
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