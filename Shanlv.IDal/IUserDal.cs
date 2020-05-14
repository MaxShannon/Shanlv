using Shanlv.DomainModel.DataModel.BaseDataTableModel;
using Shanlv.DomainModel.DataModel.DataTableModel;
using System.Collections.Generic;

namespace Shanlv.IDal
{
    public interface IUserDal : IBaseDal<User>
    {
        IEnumerable<User> GetAllUser();

        User GetUserById(int id);


    }

}
