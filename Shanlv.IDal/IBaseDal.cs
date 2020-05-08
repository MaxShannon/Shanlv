using System;
using System.Linq;
using System.Linq.Expressions;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.IDal
{
    /// <summary>
    /// 职责:封装所有dal的公共crud方法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDal<T> where T : class, new()
    {
        int Add(T model);

        IQueryable<T> GetAllEntities(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetPageEntities<T2>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, T2>> orderByLambda, bool isAsn);
    }
}
