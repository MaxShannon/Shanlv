using Shanlv.DomainModel.ViewModel;
using Shanlv.EfDbModels;
using Shanlv.IBll;
using Shanlv.IDal;
using System.Collections.Generic;
using System.Linq;

namespace Shanlv.Bll
{
    public class UserService : IUserService  //: BaseService<User>
    {
        private readonly ShanlvDbContext _db;
        private readonly IUserDal _userDal;

        public UserService(ShanlvDbContext db, IUserDal userDal)
        {
            _db = db;
            _userDal = userDal; 
        }

        public int Add(UserViewModel model)
        {
            return _userDal.Add(model.ToUser());
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
