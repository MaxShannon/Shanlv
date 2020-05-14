using Shanlv.DomainModel.DataModel.DataTableModel;

namespace Shanlv.DomainModel.ViewModel
{
    public class UserViewModel
    {
        //public int UserId { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }

        public string SubsidiaryName { get; set; }

        public string DepartmentName { get; set; }

        public User ToUser()
        {
            var user = new User();
            user.UserName = UserName;
            return user;
        }
    }
}