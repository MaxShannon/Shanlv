using System.ComponentModel.DataAnnotations;
using Shanlv.DomainModel.DataModel.BaseDataTableModel;

namespace Shanlv.DomainModel.DataModel.BaseDataTableModel
{
    public class PersonEntity : BaseEntity
    {
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Display(Name = "密码")]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "手机号")]
        public string Phone { get; set; }
        //public ICollection<Order> Orders { get; set; }

        public PersonEntity()
        {
            //Orders = new HashSet<Order>(); // HashSet 与 list 区别
        }

        //public User(UserViewModel model)
        //{
        //    Id = model.UserId;
        //    UserName = model.UserName;
        //}

        //public UserViewModel ToViewModel()
        //{
        //    var viewModel = new UserViewModel();
        //    viewModel.UserId = Id;
        //    viewModel.UserName = UserName;
        //    return viewModel;
        //}
    }
}
