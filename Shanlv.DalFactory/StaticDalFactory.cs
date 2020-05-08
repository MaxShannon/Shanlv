using System;
using Shanlv.Dal;
using Shanlv.EfDbModels;
using Shanlv.IDal;

namespace Shanlv.DalFactory
{
    public class StaticDalFactory
    {
        public static IUserDal GetUserDal()
        {
            ShanlvDbContext db = null;
            return new UserDal(db);
            //用反射去掉new
        }
    }
}
