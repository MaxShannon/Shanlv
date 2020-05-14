using System.Linq;
using Shanlv.DomainModel.DataModel.DataTableModel;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.IBll
{
    public interface ISubsidiaryService : IBaseService<Subsidiary>
    {
        IQueryable<SubsidiaryViewModel> GetSubsidiaries(in int pageIndex, in int pageSize);

        SubsidiaryViewModel Add(SubsidiaryViewModel viewModel);
    }
}