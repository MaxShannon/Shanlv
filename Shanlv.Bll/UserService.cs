using Shanlv.EfDbModels;
using Shanlv.IBll;
using Shanlv.IDal;
using System.Collections.Generic;
using System.Linq;
using Shanlv.Common;
using Shanlv.DomainModel.DataModel.DataTableModel;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.Bll
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly ShanlvDbContext _db;
        private readonly IUserDal _userDal;

        public UserService(ShanlvDbContext db, IUserDal userDal)
        {
            _db = db;
            _userDal = userDal;
        }

        public UserViewModel Add(UserViewModel model)
        {
            //return _userDal.Add(model.ToUser());
            return null;
        }

        public IEnumerable<UserViewModel> GetAllUser()
        {
            var list = _db.Users.Select(a => new UserViewModel
            {
                UserId = a.Id,
                UserName = a.UserName
            }).ToList();
            return list;
        }

        public bool Login(string userName, string password)
        {
            var result = false;
            var user = _userDal.FirstOrDefaultEntity(a => a.UserName == userName && a.Password == password);
            if (user == null)
            {
                // fail
                return false;
            }
            result = true;
            SessionOp.AddSession(user);
            return true;
        }
    }
}
