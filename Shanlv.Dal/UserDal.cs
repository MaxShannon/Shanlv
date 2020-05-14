using Shanlv.DomainModel.DataModel.BaseDataTableModel;
using Shanlv.EfDbModels;
using Shanlv.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Shanlv.DomainModel.DataModel.DataTableModel;

namespace Shanlv.Dal
{
    public class UserDal : BaseDal<User>, IUserDal//UserViewModel
    {
        private readonly ShanlvDbContext _db;

        public UserDal(ShanlvDbContext db) : base(db)
        {
            _db = db;
        }


        //public int Add(User model)
        //{
        //    //var user = new User(model);
        //    Db.Users.Add(model);
        //    return Db.SaveChanges();
        //}

        public IEnumerable<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            var user = _db.Users.Find(id);
            return user;
        }



    }
}
