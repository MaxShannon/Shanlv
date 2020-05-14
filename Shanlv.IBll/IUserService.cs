using System.Collections.Generic;
using Shanlv.DomainModel.DataModel.DataTableModel;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.IBll
{
    public interface IUserService : IBaseService<User>
    {
        IEnumerable<UserViewModel> GetAllUser();
        bool Login(string userName, string password);

        UserViewModel Add(UserViewModel model);
    }
}