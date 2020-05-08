using Shanlv.DomainModel;
using Shanlv.EfDbModels;
using Shanlv.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Shanlv.Dal
{
    public class UserDal : BaseDal<User>, IUserDal//UserViewModel
    {

        public UserDal(ShanlvDbContext db)
        {
            Db = db;
        }


        public int Add(User model)
        {
            //var user = new User(model);
            //Db.Users.Add(user);
            return Db.SaveChanges();
        }

        public IEnumerable<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            var user = Db.Users.Find(id);
            return user;
        }

        public IQueryable<User> GetEntities(Expression<Func<User, bool>> whereLambda)
        {
            return Db.Users.Where(whereLambda);
        }

        public IQueryable<User> GetAllEntities(Expression<Func<User, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetPageEntities<T2>(int pageSize, int pageIndex, out int total, Expression<Func<User, bool>> whereLambda, Expression<Func<User, T2>> orderByLambda, bool isAsn)
        {
            throw new NotImplementedException();
        }
    }
}
