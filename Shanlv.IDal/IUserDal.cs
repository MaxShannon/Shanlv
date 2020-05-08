using System.Collections;
using System.Collections.Generic;
using Shanlv.DomainModel;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.IDal
{
    public interface IUserDal : IBaseDal<User>
    {
        IEnumerable<User> GetAllUser();

        User GetUserById(int id);


    }

}
