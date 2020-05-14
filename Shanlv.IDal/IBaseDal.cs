using System;
using System.Linq;
using System.Linq.Expressions;

namespace Shanlv.IDal
{
    /// <summary>
    /// 职责:封装所有dal的公共crud方法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDal<T> where T : class, new()
    {
        T Add(T model);

        IQueryable<T> GetAllEntities(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetPageEntities<TT>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TT>> orderByLambda, bool isAsn);

        T FirstEntity(Expression<Func<T, bool>> whereLambda);

        T FirstOrDefaultEntity(Expression<Func<T, bool>> whereLambda);

        int SaveChanges();

    }
}
