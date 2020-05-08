using System;
using Shanlv.DomainModel;
using Shanlv.EfDbModels;
using Xunit;

namespace Shanlv.Bll.Tests
{
    public class BaseServiceTest<T>
    {
        private readonly ShanlvDbContext _db;

        public BaseServiceTest(ShanlvDbContext db)
        {
            _db = db;
        }
        [Fact]
        public void Test1() // Ò»¸öcase
        {
            var service = new BaseService<User>(_db);
            User user = new User();
            user.UserName = "newMax";

            var expected = true;
            var actual = service.Add(user) > 0;
            Assert.Equal(expected, actual);
        }
    }


}
