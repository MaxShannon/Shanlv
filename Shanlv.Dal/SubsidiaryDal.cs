using Shanlv.DomainModel.DataModel.DataTableModel;
using Shanlv.IDal;
using System;
using System.Linq;
using System.Linq.Expressions;
using Shanlv.EfDbModels;

namespace Shanlv.Dal
{
    public class SubsidiaryDal : BaseDal<Subsidiary>, ISubsidiaryDal
    {

        public SubsidiaryDal(ShanlvDbContext db) : base(db)
        {

        }

    }
}