using Shanlv.DomainModel.DataModel.DataTableModel;
using Shanlv.DomainModel.ViewModel;
using Shanlv.EfDbModels;
using Shanlv.IBll;
using System.Linq;
using Shanlv.DomainModel.DataModel.Extend;
using Shanlv.IDal;

namespace Shanlv.Bll
{
    public class SubsidiaryService : BaseService<Subsidiary>, ISubsidiaryService
    {
        private readonly ISubsidiaryDal _subsidiaryDal;

        public SubsidiaryService(ShanlvDbContext db, ISubsidiaryDal subsidiaryDal)
        {
            _subsidiaryDal = subsidiaryDal;
            Db = db;
        }

        public IQueryable<SubsidiaryViewModel> GetSubsidiaries(in int pageIndex, in int pageSize)
        {
            // check ok
            var query = _subsidiaryDal.GetAllEntities(null);
            //var queryViewModel = query.ToViewModel();
            //return query;
            return null;
        }


        public SubsidiaryViewModel Add(SubsidiaryViewModel model)
        {
            var subsidiary = model.ToSubsidiary();
            var result = _subsidiaryDal.Add(subsidiary);
            //var result = Add(subsidiary);
            return result.ToViewModel<SubsidiaryViewModel>();
        }

        //SubsidiaryViewModel IBaseService<SubsidiaryViewModel>.Add(SubsidiaryViewModel model)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}