using Shanlv.EfDbModels;

namespace Shanlv.Dal
{
    public class BaseDal<T> where T : class, new()
    {
        protected ShanlvDbContext Db;

        public BaseDal()
        {

        }

        public int Add(T model)
        {
            //var user = new User(model);
            //Db.Users.Add(user);
            Db.Set<T>().Add(model);
            return Db.SaveChanges();
        }

    }
}