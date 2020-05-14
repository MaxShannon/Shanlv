using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.DataTableModel
{
    public class User : PersonEntity
    {
        public int SubsidiaryId { get; set; }
        public Subsidiary Subsidiary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}