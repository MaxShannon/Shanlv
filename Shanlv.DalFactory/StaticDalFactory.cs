using System;
using Shanlv.Dal;
using Shanlv.EfDbModels;
using Shanlv.IDal;

namespace Shanlv.DalFactory
{
    public class StaticDalFactory
    {
        private static readonly ShanlvDbContext _db;

        public StaticDalFactory(ShanlvDbContext db)
        {
            //_db = db;
        }
        public static IUserDal GetUserDal()
        {
            return new UserDal(_db);
            //用反射去掉new
        }
    }
}
