using System;
using Shanlv.EfDbModels;
using Shanlv.IBll;

namespace Shanlv.Bll
{
    public class BaseService<T> : IBaseService<T> where T : class, new()
    {
        private readonly ShanlvDbContext _db;

        public BaseService(ShanlvDbContext db)
        {
            _db = db;
        }

        public int Add(T model)
        {
            _db.Set<T>().Add(model);
            return _db.SaveChanges();
        }

    }
}
