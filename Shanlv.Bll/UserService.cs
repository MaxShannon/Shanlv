using Shanlv.DomainModel;
using Shanlv.DomainModel.ViewModel;
using Shanlv.EfDbModels;
using Shanlv.IBll;
using System.Collections.Generic;
using System.Linq;
using Shanlv.DalFactory;
using Shanlv.IDal;

namespace Shanlv.Bll
{
    public class UserService : IUserService // : BaseService<User>
    {
        private readonly ShanlvDbContext _db;
        private readonly IUserDal _userDal;

        public UserService(ShanlvDbContext db, IUserDal userDal)
        {
            _db = db;
            _userDal = StaticDalFactory.GetUserDal(); // userDal;
        }

        public int Add(UserViewModel model)
        {
            _userDal.Add(model.ToUser());
            return _db.SaveChanges();
        }

        public IEnumerable<UserViewModel> GetAllUser()
        {
            //var list = _userDal.GetAllUser();
            var list = _db.Users.Select(a => new UserViewModel
            {
                UserId = a.Id,
                UserName = a.UserName
            }).ToList();
            return list;
        }
    }
}
