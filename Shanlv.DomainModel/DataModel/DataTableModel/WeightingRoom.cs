using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class WeightingRoom : BasePositionEntity
    {
        public string WeightRoomName { get; set; }

        public string Ip { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}