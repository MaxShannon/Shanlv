using Shanlv.DomainModel.DataModel.BaseDataTableModel;
using System.Collections.Generic;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class Area : BaseEntity
    {
        public string AreaName { get; set; }
        public ICollection<Gate> Gates { get; set; }
        public ICollection<WeightingRoom> WeightingRooms { get; set; }

        public Area()
        {
            Gates = new HashSet<Gate>();
            WeightingRooms = new HashSet<WeightingRoom>();
        }
    }
}