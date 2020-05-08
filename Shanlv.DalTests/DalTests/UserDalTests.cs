using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shanlv.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shanlv.DomainModel;
using Shanlv.IDal;

namespace Shanlv.UnitTests.DalTests
{
    [TestClass()]
    public class UserDalTests
    {
        //private readonly IUserDal _userDal;

        public UserDalTests()//IUserDal userDal
        {
           // _userDal = userDal;
        }

        [TestMethod()]
        public void GetEntitiesTest()
        {
            //_userDal.GetEntities();
            for (int i = 0; i < 10; i++)
            {
                //_userDal.Add(new User()
                //{
                //    UserName = "Max" + i
                //});
            }

            //IQueryable<User> temp = _userDal.GetEntities(a => a.UserName.Contains("1"));
            IQueryable<User> temp = null;
            Assert.AreEqual(true, temp.Count());
        }
    }
}
