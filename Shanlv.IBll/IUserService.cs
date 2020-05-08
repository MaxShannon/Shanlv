using System.Collections.Generic;
using Shanlv.DomainModel;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.IBll
{
    public interface IUserService : IBaseService<UserViewModel>
    {
        IEnumerable<UserViewModel> GetAllUser();
    }
}