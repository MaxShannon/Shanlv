using System;
using Shanlv.EfDbModels;
using Shanlv.IBll;
using Shanlv.IDal;

namespace Shanlv.Bll
{
    public class BaseService<T> where T : class, new() //: IBaseService<T> 
    {
        protected ShanlvDbContext Db;

        public BaseService()
        {
            //_db = db;
        }

        public T Add(T model)
        {
            //return baseDal.Add(model);
            Db.Set<T>().Add(model);

            //return Db.SaveChanges();
            return model;
        }

    }
}
