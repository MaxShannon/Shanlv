using System.Collections.Generic;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.DomainModel
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public ICollection<Order> Orders { get; set; }

        public User()
        {
            Orders = new HashSet<Order>(); // HashSet 与 list 区别
        }

        public User(UserViewModel model)
        {
            Id = model.UserId;
            UserName = model.UserName;
        }

        public UserViewModel ToViewModel()
        {
            var viewModel = new UserViewModel();
            viewModel.UserId = Id;
            viewModel.UserName = UserName;
            return viewModel;
        }
    }
}
