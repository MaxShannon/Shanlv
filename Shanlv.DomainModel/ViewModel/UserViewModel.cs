namespace Shanlv.DomainModel.ViewModel
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public User ToUser()
        {
            var user = new User();
            user.UserName = UserName;
            return user;
        }
    }
}