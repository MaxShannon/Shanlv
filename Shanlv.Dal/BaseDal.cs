using System;
using Shanlv.EfDbModels;
using System.Linq;
using System.Linq.Expressions;

namespace Shanlv.Dal
{
    public class BaseDal<T> where T : class, new()
    {
        private readonly ShanlvDbContext _db;
        //protected ShanlvDbContext Db;

        public BaseDal(ShanlvDbContext db) // 派生类 -> 子类 赋值
        {
            _db = db;
        }

        public T Add(T model)
        {
            _db.Set<T>().Add(model);
            return _db.SaveChanges() > 0 ? model : null;
        }
        public IQueryable<T> GetAllEntities(Expression<Func<T, bool>> whereLambda)
        {
            IQueryable<T> query = _db.Set<T>();
            if (whereLambda != null)
            {
                query = query.Where(whereLambda);
            }

            return query;
        }

        public IQueryable<T> GetPageEntities<TT>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TT>> orderByLambda, bool isAsc)
        {
            IQueryable<T> list;
            if (isAsc)
            {
                list = _db.Set<T>().Where(whereLambda).OrderBy(orderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                list = _db.Set<T>().Where(whereLambda).OrderByDescending(orderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            var pageList = list;
            total = pageList.Count();
            return pageList;
        }

        //public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda)
        //{
        //    return Db.Users.Where(whereLambda);
        //}

        public T FirstEntity(Expression<Func<T, bool>> whereLambda)
        {
            return GetAllEntities(whereLambda).First();
        }

        public T FirstOrDefaultEntity(Expression<Func<T, bool>> whereLambda)
        {
            return GetAllEntities(whereLambda).FirstOrDefault();
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

    }
}