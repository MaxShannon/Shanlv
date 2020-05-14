using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class Gate : BasePositionEntity
    {
        public string GateName { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}